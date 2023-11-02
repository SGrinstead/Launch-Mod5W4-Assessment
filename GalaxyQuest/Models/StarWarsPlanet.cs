namespace GalaxyQuest.Models
{
    public class StarWarsPlanet
    {
        public string Name { get; set; }
        public string Diameter { get; set; }
        public string RotationPeriod { get; set; }
        public string OrbitalPeriod { get; set; }
        public string Gravity { get; set; }
        public long Population { get; set; }
        public string Climate { get; set; }
        public string Terrain { get; set; }
        public string SurfaceWater { get; set; }
        public string[] Residents { get; set; }
        public string[] Films { get; set; }
        public string Url { get; set; }
        public string Created { get; set; }
        public string Edited { get; set; }
    }
}
