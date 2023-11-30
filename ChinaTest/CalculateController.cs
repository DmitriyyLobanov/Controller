
namespace ChinaTest
{
    internal class CalculateController
    {
        private AxisModel? _axisModel;

        /// <summary>
        /// Установить текущкю ось.
        /// </summary>
        /// <param name="axisValue"> Текущая ось. </param>
        public void SetAxisVAlue(AxisModel axisValue) 
        {
            _axisModel = axisValue;
        }

        // Формулы для линейного перемещения (TranslationStage)

        /// <summary>
        /// Расчет интегрального значения шага за один оборот шагового двигателя.
        /// </summary>
        /// <returns> Интегральное значение шага за один оборот шагового двигателя. </returns>
        private double ValuePerRotation()
        {
            return 360 / _axisModel.StepperAngle;
        }

        /// <summary>
        /// Расчет эквивалента пульса.
        /// </summary>
        /// <returns> Эквивалент пульса. </returns>
        public double PulseEquivalentLiner()
        {
            return _axisModel.ScrewLead / (ValuePerRotation() * _axisModel.Subdivision);

        }

        /// <summary>
        /// Расчет смещения по колличеству имульсов.
        /// </summary>
        /// <param name="pulseNumber"> Значение желаемого смещения. </param>
        /// <returns> Значение смещения по колличеству имульсов. </returns>
        public double ActualDisplacement(double pulseNumber)
        {
            return (pulseNumber * PulseEquivalentLiner())*2;  
        }

        /// <summary>
        /// Расчет фактического смещения.
        /// </summary>
        /// <param name="actualDisplacement"> Значение желаемого смещение. </param>
        /// <returns> Значение фактического смещения. </returns>
        public double CountOfImpulseLiner(double actualDisplacement)
        {
            return (actualDisplacement / PulseEquivalentLiner())/2; 
        }

        /// <summary>
        /// Расчет скорости линейного перемещения.
        /// </summary>
        /// <param name="speed"> Значение желаемой скорости. </param>
        /// <returns> Значение скорости. </returns>
        public double ActualSpeedLiner(double speed)
        {
            if (speed > 0 && speed < 255)
                return (speed + 1) * 22000 * PulseEquivalentLiner() / 720; // (мм/сек)

            return 0;
        }

        // Формулы для перемещение по заданным углам (RotaryStage, GoniometrStage)

        /// <summary>
        /// Эквивалент пулься для углового смещения.
        /// </summary>
        /// <returns> Значение эквивалента пулься. </returns>
        private double PulseEquivalentAngle() 
        {
            return _axisModel.StepperAngle / (_axisModel.Subdivision * _axisModel.TransmissonRatio);
        }

        /// <summary>
        /// Расчет смещения в градусах.
        /// </summary>
        /// <param name="pulseNumber"> Значение желаемого смещения. </param>
        /// <returns> Значение смещения.</returns>
        public double ActualRatio(double pulseNumber) //Если необходимо смещать в градусах
        {
            return pulseNumber * PulseEquivalentAngle();
        }

        /// <summary>
        /// Расчет смещения по колличеству импульсов.
        /// </summary>
        /// <param name="actualRatio"> Значение фактического смещения. </param>
        /// <returns> Значения смещения по колличеству импульсов. </returns>
        public double CountOfImpulseAngle(double actualRatio) //Если необходимо смещать по колличеству импульсов
        {
            return actualRatio / PulseEquivalentAngle();
        }

        /// <summary>
        /// Скорость смещения для вращательного движения.
        /// </summary>
        /// <param name="speed"> Значение заданной скорости. </param>
        /// <returns> Значение скорости. </returns>
        public double ActualSpeedAngle(double speed)
        {
            return (speed + 1) * 22000 * PulseEquivalentAngle() / 720; // (Градус/сек)
        }
    }
}
