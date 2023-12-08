
namespace ChinaTest
{
    internal class Controller
    {
        public Connect Connect { get; private set; } = new Connect();
        public SetterSpeed? SetterSpeed { get; set; }

        public AxisModel? AxisModelX { get; private set; }
        public AxisModel? AxisModelY { get; private set; }
        public AxisModel? AxisModelZ { get; private set; }

        /// <summary>
        /// Установить значения оси для текущей оси.
        /// </summary>
        /// <param name="axis"> Текущая ось. </param>
        public void SetAxisValue(AxisModel axis)
        {
            if (axis.Name == "X") AxisModelX = axis;
            else if (axis.Name == "Y") AxisModelY = axis;
            else if (axis.Name== "Z") AxisModelZ = axis;
            //else { MessageBox.Show("Неверное имя оси"); }
        }
    }
}
