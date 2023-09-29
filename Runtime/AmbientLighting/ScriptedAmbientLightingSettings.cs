using UnityEngine;
using UnityEngine.Rendering;

namespace IronMountain.DayNightCycle.AmbientLighting
{
    public abstract class ScriptedAmbientLightingSettings : ScriptableObject, IAmbientLightingSettings
    {
        [SerializeField] private AmbientMode mode;

        public AmbientMode Mode => mode;

        public abstract float Intensity { get; }
        public abstract Color SkyColor { get; }
        public abstract Color EquatorColor { get; }
        public abstract Color GroundColor { get; }
    }
}