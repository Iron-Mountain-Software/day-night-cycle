using UnityEngine;

namespace SpellBoundAR.Lighting.Fog
{
    public class FogSettings : IFogSettings
    {
        public bool Enabled { get; set; }
        public FogMode Mode { get; set; }
        public Color Color { get; set; }
        public float Density { get; set; }
        public float StartDistance { get; set; }
        public float EndDistance { get; set; }

        public FogSettings()
        {
            Enabled = false;
            Mode = FogMode.Exponential;
            Color = Color.white;
            Density = 0.02f;
            StartDistance = 1f;
            EndDistance = 100f;
        }
    }
}
