using UnityEngine;

namespace IronMountain.DayNightCycle.GradientSkybox
{
    public abstract class ScriptedGradientSkyboxSettings : ScriptableObject, IGradientSkyboxSettings
    {
        public abstract  float Intensity { get; }
        public abstract float Exponent1 { get; }
        public abstract float Exponent2 { get; }
        public abstract Color TopColor { get; }
        public abstract Color MiddleColor { get; }
        public abstract Color BottomColor { get; }
    }
}