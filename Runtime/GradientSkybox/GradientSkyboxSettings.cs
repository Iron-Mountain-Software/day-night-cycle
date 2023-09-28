using UnityEngine;

namespace IronMountain.DayNightCycle.GradientSkybox
{
    public class GradientSkyboxSettings : IGradientSkyboxSettings
    {
        public float Intensity { get; }
        public float Exponent1 { get; }
        public float Exponent2 { get; }
        public Color TopColor { get; }
        public Color MiddleColor { get; }
        public Color BottomColor { get; }
        
        public GradientSkyboxSettings()
        {
            Intensity = 1;
            Exponent1 = 1;
            Exponent2 = 1;
            TopColor = Color.white;
            MiddleColor = Color.white;
            BottomColor = Color.white;
        }
    }
}