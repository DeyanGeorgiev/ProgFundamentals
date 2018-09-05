namespace P03_Jarvis
{
    public class Legs
    {
        public int EnergyConsumption { get; set; }

        public int Strength { get; set; }

        public int Speed { get; set; }

        public Legs(int energyConsumption, int strength, int speed)
        {
            EnergyConsumption = energyConsumption;
            Strength = strength;
            Speed = speed;
        }
    }
}