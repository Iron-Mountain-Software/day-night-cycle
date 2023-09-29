using UnityEngine;

namespace IronMountain.DayNightCycle.AmbientLighting
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Gameplay/Lighting/Ambient/Dynamic Settings")]
    public class ScriptedAmbientLightingSettingsDynamic : ScriptedAmbientLightingSettings
    {
        [SerializeField] private AnimationCurve intensity;
        [SerializeField] private Gradient skyColor;
        [SerializeField] private Gradient equatorColor;
        [SerializeField] private Gradient groundColor;

        public override float Intensity => intensity.Evaluate(GameTimeSystem.DayProgressPercent);
        public override Color SkyColor => skyColor.Evaluate(GameTimeSystem.DayProgressPercent);
        public override Color EquatorColor => equatorColor.Evaluate(GameTimeSystem.DayProgressPercent);
        public override Color GroundColor => groundColor.Evaluate(GameTimeSystem.DayProgressPercent);
    }
}