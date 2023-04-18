using UnityEngine;

namespace SpellBoundAR.Lighting.Fog
{
    public interface IFogSettings
    {
        public bool Enabled { get; }
        public FogMode Mode { get; }
        public Color Color { get; }
        public float Density { get; }
        public float StartDistance { get; }
        public float EndDistance { get; }
    }
}