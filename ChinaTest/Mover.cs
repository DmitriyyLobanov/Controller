
namespace ChinaTest
{
    internal class Mover
    {
        private CalculateController _colculateController = new CalculateController();
        private Connect _connect;
        private AxisModel _axisModel;

        public event Action<bool> Busyed;
        public event Action<bool> Set;
        public event Action<int>? TimerItntervaled;
        public event Action<bool>? TimerEnabled;
        public event Action<string> Recived;
        public event Action<string> SendedPosition;

        public Mover(AxisModel axisValue, Connect connect)
        {
            _colculateController.SetAxisVAlue(axisValue);
            _connect = connect;
            _axisModel = axisValue;
            _connect.SetMover(this);
        }

        public string AxisName => _axisModel.Name;
        public string RunningUnit => _axisModel.RuningUnit;
        public double TravelRange => _axisModel.TravelRange;

        /// <summary>
        /// Этот метод устанавливает параметр для перемещения каретки в указанную точку.
        /// </summary>
        /// <param name="point"> Точка в которую перемещается каретка. </param>
        public void SetToPoint(double point)      
        {
            double step = 0;

            if (_axisModel.StageType == "TranslationStage")
            {
                step = _colculateController.CountOfImpulseLiner(point);
            }
            else if(_axisModel.StageType == "RotaryStage" || _axisModel.StageType == "GoniometrStage")
            {
                step = Math.Round(_colculateController.CountOfImpulseAngle(point));
            }

            string stepString;

            if (step > 0)
                stepString = "+" + step.ToString();
            else
                stepString = step.ToString();

            MoveToPoint(_axisModel.Name, stepString);
        }

        /// <summary>
        /// Перемещение каретки в домашнее положение
        /// </summary>
        public void MoveToHome()   
        {
            MoveToPoint("H"+_axisModel.Name+"0");
        }

        /// <summary>
        /// Перемещение каретки в указанное положение.
        /// </summary>
        /// <param name="command"> Имя оси для которой осуществляется перемещение. </param>
        /// <param name="step"> Шаг на который необходимо сместить каретку. </param>
        private void MoveToPoint(string command, string step = "")  
        {
            Recived?.Invoke("");
            Busyed?.Invoke(true);
            Set?.Invoke(true);

            _connect.SendCommand(command + step + "\r");

            if (_axisModel.StageType == "TranslationStage")
                TimerItntervaled?.Invoke(310 - Convert.ToInt32(_colculateController.ActualSpeedLiner(_axisModel.Speed)));
            else if (_axisModel.StageType == "RotaryStage" || _axisModel.StageType == "GoniometrStage")
                TimerItntervaled?.Invoke(310 - Convert.ToInt32(_colculateController.ActualSpeedAngle(_axisModel.Speed)));

            TimerEnabled?.Invoke(true);

            Busyed?.Invoke(false);
            TimerEnabled?.Invoke(false);
            _connect.Delay(100000000);
        }

        /// <summary>
        /// Получить текущий шаг каретки.
        /// </summary>
        /// <returns></returns>
        private double GetCurrentStep()
        {
            _connect.ConnectController("?" + _axisModel.Name);
            _connect.Delay(500);

            if (_connect.StrReceiver != "")
            {
                if (_connect.StrReceiver.Substring(5, 1) == "-")
                    return  -Convert.ToInt64(System.Text.RegularExpressions.Regex.Replace(_connect.StrReceiver, @"[^0-9]+", ""));
                else
                    return Convert.ToInt64(System.Text.RegularExpressions.Regex.Replace(_connect.StrReceiver, @"[^0-9]+", ""));        }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Получить текущее положение каретки.
        /// </summary>
        /// <returns> Возвращает текущее положение каретки double. </returns>
        public double GetPoint()
        {
            _connect.Delay(500);

            if (_axisModel.StageType == "TranslationStage")
                return Math.Round(_colculateController.ActualDisplacement(GetCurrentStep()), 3);
            else if (_axisModel.StageType == "RotaryStage" || _axisModel.StageType == "GoniometrStage")
                return Math.Round(_colculateController.ActualRatio(GetCurrentStep()), 3);
            else 
                return 0;
        }

        /// <summary>
        /// Остановить движение каретки.
        /// </summary>
        public void StopMove()
        {
            _connect.SendCommand("S");
        }
    }
}
