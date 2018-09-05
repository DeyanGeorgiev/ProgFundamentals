namespace P03_Jarvis
{
    public class Torso
    {
        public int EnergyConsumption { get; set; }
     
       public double ProcessorSizeCm { get; set; } 
        public string HousinMaterial { get; set; }


        public Torso(int energyConsumption, double processorSizeCm, string housinMaterial)
        {
            EnergyConsumption = energyConsumption;
            ProcessorSizeCm = processorSizeCm;
            HousinMaterial = housinMaterial;
        }
    }
}