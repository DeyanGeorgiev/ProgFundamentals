using System.Dynamic;

namespace P03_Jarvis
{
    public class Arms
    {
        public Arms(int energyConsumption, int armReachDistance, int countOfFingers)
        {
            EnergyConsumption = energyConsumption;
            ArmReachDistance = armReachDistance;
            CountOfFingers = countOfFingers;
        }

        public int	EnergyConsumption { get; set; }
        public int	ArmReachDistance { get; set; }
        public int	CountOfFingers { get; set; }


    }
}