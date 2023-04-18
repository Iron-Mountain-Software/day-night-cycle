using UnityEngine;

namespace SpellBoundAR.Lighting.Fog
{
    public abstract class ScriptedFogSettings : ScriptableObject, IFogSettings
    {
        [SerializeField] private bool enabled = true;
        [SerializeField] private FogMode mode = FogMode.Linear;

        public bool Enabled => enabled;
        public FogMode Mode => mode;
        
        public abstract Color Color { get; }
        public abstract float Density { get; }
        public abstract float StartDistance { get; }
        public abstract float EndDistance { get; }
    }
}