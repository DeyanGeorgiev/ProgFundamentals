namespace P03_Jarvis
{
    public class Head
    {
        public Head(int energyConsumption, int iq, string skinMaterial)
        {
            EnergyConsumption = energyConsumption;
            IQ = iq;
            SkinMaterial = skinMaterial;
        }

        public int	EnergyConsumption { get; set; }
        public int	IQ { get; set; }
        public string	SkinMaterial { get; set; }

    }
}