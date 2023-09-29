using UnityEngine;
using UnityEngine.Rendering;

namespace IronMountain.DayNightCycle.AmbientLighting
{
    public interface IAmbientLightingSettings
    {
        public AmbientMode Mode { get; }
        public float Intensity { get; }
        public Color SkyColor { get; }
        public Color EquatorColor { get; }
        public Color GroundColor { get; }
    }
}