using System.IO.Ports;

namespace ChinaTest
{
    internal class Connect
    {
        private bool _isSet;                                   //Если отправленная команда является заданной командой или командой запроса. TRUE - команда установлена
        private bool _isStopCommand;                            //Остановка ожидания
        private bool _isConnect;                                //Статус соединения
        private short _portNumber;                              //Номер серийного порта

        private Mover _mover;

        public static SerialPort s_SerialPort;

        public event Action<bool> EnabledConnaction;

        public bool IsRead { get; private set; }                                   //Если чтение завершено, возвращает TRUE
        public bool IsBusy { get; private set; }                                  //Если контроллер занят
        public string StrReceiver { get; private set; }                            //Получение строки от контроллера

        /// <summary>
        /// Производит подключение к текущему USB порут.
        /// </summary>
        /// <param name="port"> Числовое значение порта. </param>
        public void ConnectPort(short port)
        {
            s_SerialPort = new SerialPort();

            if (s_SerialPort.IsOpen == true)
                s_SerialPort.Close();

            s_SerialPort.PortName = "COM" + port.ToString();            //Установка серийного номера порта
            s_SerialPort.BaudRate = 9600;                                //Установка скорости передачи данных в битах
            s_SerialPort.DataBits = 8;                                   //Установка битов данных
            s_SerialPort.StopBits = StopBits.One;                        //Установка стоп бита
            s_SerialPort.Parity = Parity.None;                           //Установка паритета
            s_SerialPort.ReadBufferSize = 2048;
            s_SerialPort.WriteBufferSize = 1024;
            s_SerialPort.DtrEnable = true;
            s_SerialPort.Handshake = Handshake.None;
            s_SerialPort.ReceivedBytesThreshold = 1;
            s_SerialPort.RtsEnable = false;

            // Этот делегат должен быть триггерным событием для асинхронной выборки данных,
            //  оно будет запущено при передаче данных с последовательного порта.
            s_SerialPort.DataReceived += new SerialDataReceivedEventHandler(SCPort_DataReceived);     //DataReceivedEvent delegate

            try
            {
                s_SerialPort.Open();                                     //Открытие сирийного порта

                if (s_SerialPort.IsOpen)
                {
                    ConnectController("?R");

                    if (StrReceiver == "?R\rOK\n")
                    {
                        _isConnect = true;                         //Подключение успешно
                        _portNumber = port;                          //Номер серийного порта
                        EnabledConnaction?.Invoke(true);
                    }
                    else
                    {
                        IsBusy = false;
                        _isConnect = false;
                        MessageBox.Show("Failed to connect", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            catch
            {
                EnabledConnaction?.Invoke(false);
            }
        }

        /// <summary>
        /// Отправляет команду в контроллер.
        /// </summary>
        /// <param name="commandString"> Символьная команда. </param>
        public void SendCommand(string commandString)
        {
            if (s_SerialPort.IsOpen)
            {
                s_SerialPort.Write(commandString);
                s_SerialPort.DiscardOutBuffer();
            }
        }

        /// <summary>
        /// Назначает время ожидания и выходит из режима ожидания до завершения считывания данных 
        /// или при нажатии кнопки стоп, или при закрытии окна, или при истечении времени ожидания.
        /// </summary>
        /// <param name="milliSecond"> Длительность задержки в милисекундах. </param>
        public void Delay(long milliSecond = 500)
        {
            int start = Environment.TickCount;

            IsRead = false;
            _isStopCommand = false;

            while (Math.Abs(Environment.TickCount - start) < milliSecond)
            {
                if (IsRead == true)
                {
                    IsRead = false;
                    return;
                }

                if (_isStopCommand == true)
                    return;

                Application.DoEvents();
            }
        }

        /// <summary>
        /// Получает данные, отправленные с последовательного порта, и обрабатывает.
        /// </summary>
        /// <param name="sender"> Присылаемый объект. </param>
        /// <param name="e"> Параметр для передачи события. </param>
        public void SCPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string sCurString = "";
                sCurString = s_SerialPort.ReadExisting();

                if (sCurString != "")
                    StrReceiver = StrReceiver + sCurString;

                if (_isSet == true)
                {
                    if (StrReceiver.Length >= 4 || StrReceiver.Length == 3)
                    {
                        if (StrReceiver.Substring(StrReceiver.Length - 3) == "OK\n" || StrReceiver.Substring(StrReceiver.Length - 4) == "OK\nS" ||
                            StrReceiver.Substring(StrReceiver.Length - 5) == "ERR1\n" || StrReceiver.Substring(StrReceiver.Length - 5) == "ERR5\n")
                            IsRead = true;
                    }
                }
                else
                {
                    if (StrReceiver.Length > 1)
                    {
                        if (StrReceiver.Substring(StrReceiver.Length - 1, 1) == "\n")
                            IsRead = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Failed to receive data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Соединение с контроллером.
        /// </summary>
        /// <param name="command"> Команда отправляемая в контроллер. </param>
        /// <param name="speed"> Скорость перемещения каретки. </param>
        public void ConnectController(string command, string speed = null)
        {
            StrReceiver = "";
            IsBusy = true;
            _isSet = false;
            SendCommand(command + speed + "\r");                           //Соединение с контроллером
            Delay(10000);
            IsBusy = false;
        }

        /// <summary>
        /// Установить Mover.
        /// </summary>
        /// <param name="mover"></param>
        public void SetMover(Mover mover)
        {
            _mover = mover;

            _mover.Busyed += SetIsBusy;
            _mover.Set += SetIsSet;
        }

        /// <summary>
        /// Установить значение IsBusy.
        /// </summary>
        /// <param name="isBusy"></param>
        public void SetIsBusy(bool isBusy)
        {
           IsBusy = isBusy;
        }

        /// <summary>
        /// Установить значение IsSet.
        /// </summary>
        /// <param name="isSet"></param>
        public void SetIsSet(bool isSet)
        {
            _isSet = isSet;
        }
    }
}
