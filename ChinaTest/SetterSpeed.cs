namespace ChinaTest
{
    internal class SetterSpeed
    {
        private Connect _connect;
        private float _speed;
        private float _maxSpeed = 255;

        public event Action<string>? CalculatedSpeed;

        public SetterSpeed(Connect connect)
        {
            _connect = connect;
        }

        public double PulseEquivalent { get;private set; }

        /// <summary>
        /// Установить скорость для перемещения каретки.
        /// </summary>
        /// <param name="speedText"> Значение скорости. </param>
        public void SetSpeed(string speedText)      //Устанавливает новую скорость
        {
            _speed = Convert.ToInt16(speedText);

            if (_speed < 0 || _speed > _maxSpeed)
            {
                MessageBox.Show("The speed value must be an integer between 0 and 255.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_connect.IsBusy)
            {
                //MessageBox.Show("The connection is busy, please wait.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _connect.ConnectController("V", speedText);            //Установка скорости
            TakeCurrentSpeed();
        }

        /// <summary>
        /// Запросить текущую скорость.
        /// </summary>
        private void TakeCurrentSpeed()  //Получает текущую скорость
        {
            _connect.ConnectController("?V");           //Запрос скорости

            if (_connect.StrReceiver != "")
            {
                _speed = Convert.ToInt16(System.Text.RegularExpressions.Regex.Replace(_connect.StrReceiver, @"[^0-9]+", ""));
                string text = "The speed is " + _speed.ToString();
                CalculatedSpeed?.Invoke(text);
            }
        }
    }
}
