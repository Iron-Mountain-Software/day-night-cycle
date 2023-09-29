using UnityEngine;
using UnityEngine.Rendering;

namespace IronMountain.DayNightCycle.AmbientLighting
{
    public class AmbientLightingSettings : IAmbientLightingSettings
    {
        public AmbientMode Mode { get; }
        public float Intensity { get; }
        public Color SkyColor { get; }
        public Color EquatorColor { get; }
        public Color GroundColor { get; }

        public AmbientLightingSettings()
        {
            Mode = AmbientMode.Flat;
            Intensity = 0;
            SkyColor = Color.gray;
            EquatorColor = Color.gray;
            GroundColor = Color.gray;
        }
    }
}