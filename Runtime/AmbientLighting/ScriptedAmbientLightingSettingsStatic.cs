using UnityEngine;

namespace IronMountain.DayNightCycle.AmbientLighting
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Gameplay/Lighting/Ambient/Static Settings")]
    public class ScriptedAmbientLightingSettingsStatic : ScriptedAmbientLightingSettings
    {
        [SerializeField] private float intensity;
        [SerializeField] private Color skyColor;
        [SerializeField] private Color equatorColor;
        [SerializeField] private Color groundColor;

        public override float Intensity => intensity;
        public override Color SkyColor => skyColor;
        public override Color EquatorColor => equatorColor;
        public override Color GroundColor => groundColor;
    }
}