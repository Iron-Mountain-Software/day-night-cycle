using UnityEngine;

namespace SpellBoundAR.Lighting.Fog
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Gameplay/Lighting/Fog/Static Settings")]
    public class ScriptedFogSettingsStatic : ScriptedFogSettings
    {
        [SerializeField] private Color color;
        [SerializeField] private float density = .02f;
        [SerializeField] private float startDistance = 1f;
        [SerializeField] private float endDistance = 100f;
        
        public override Color Color => color;
        public override float Density => density;
        public override float StartDistance => startDistance;
        public override float EndDistance => endDistance;
    }
}