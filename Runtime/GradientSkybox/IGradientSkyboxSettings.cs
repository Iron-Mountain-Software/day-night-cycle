using UnityEngine;

namespace IronMountain.DayNightCycle.GradientSkybox
{
    public interface IGradientSkyboxSettings
    {
        public float Intensity { get; }
        public float Exponent1 { get; }
        public float Exponent2 { get; }
        public Color TopColor { get; }
        public Color MiddleColor { get; }
        public Color BottomColor { get; }
    }
}