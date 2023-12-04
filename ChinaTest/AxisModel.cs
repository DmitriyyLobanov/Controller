
namespace ChinaTest
{
    internal class AxisModel
    {
        private string _name;
        private string _stageType;
        private string _runningUnit;
        private double _stepperAngle;
        private double _subdivision;
        private double _screwLead;
        private double _transmissonRatio;
        private double _travelRange;
        private double _speed;
        private double _pulseEquivalent;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string StageType 
        {
            get { return _stageType; }
            set { _stageType = value; } 
        }

        public string RuningUnit 
        {
            get { return _runningUnit; }
            set { _runningUnit = value; } 
        }

        public double StepperAngle 
        {
            get { return _stepperAngle; }
            set { _stepperAngle = value; }
        }

        public double Subdivision 
        {
            get { return _subdivision; }
            set { _subdivision = value; }
        }

        public double ScrewLead 
        {
            get { return _screwLead;}
            set {  _screwLead = value; } 
        }

        public double TransmissonRatio 
        {
            get { return _transmissonRatio;}
            set { _transmissonRatio = value; }
        }

        public double TravelRange
        {
            get { return _travelRange;}
            set { _travelRange = value; } 
        }

        public double Speed 
        {
            get { return _speed; }
            set { _speed = value; }
        }
        public double PulseEquivalent 
        {
            get { return _pulseEquivalent; }
            set { _pulseEquivalent = value; } 
        }

        public override string? ToString()
        {
            return "Name: " + Name + Environment.NewLine
                + "StageType: " + StageType + Environment.NewLine
                + "RunningUnit: " + RuningUnit + Environment.NewLine
                + "StepperUngle: " + StepperAngle + Environment.NewLine
                + "Subdivision: " + Subdivision + Environment.NewLine
                + "ScrewLead: " + ScrewLead + Environment.NewLine
                + "TransmissionRatio: " + TransmissonRatio + Environment.NewLine
                + "TravelRange: " + TravelRange + Environment.NewLine
                + "Speed: " + Speed + Environment.NewLine
                + "PulseEquivalent: " + PulseEquivalent;
        }
    }
}
