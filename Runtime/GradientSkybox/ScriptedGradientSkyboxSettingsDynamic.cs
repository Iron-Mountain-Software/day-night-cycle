using UnityEngine;

namespace IronMountain.DayNightCycle.GradientSkybox
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Gameplay/Lighting/Gradient Skybox/Dynamic Settings")]
    public class ScriptedGradientSkyboxSettingsDynamic : ScriptedGradientSkyboxSettings
    {
        [SerializeField] private AnimationCurve intensity = new (new Keyframe(0, 1f));
        [SerializeField] private AnimationCurve exponent1 = new (new Keyframe(0, 1f));
        [SerializeField] private AnimationCurve exponent2 = new (new Keyframe(0, 1f));
        [SerializeField] private Gradient topColor = new ();
        [SerializeField] private Gradient middleColor = new ();
        [SerializeField] private Gradient bottomColor = new ();

        public override float Intensity => intensity.Evaluate(GameTimeSystem.DayProgressPercent);
        public override float Exponent1 => exponent1.Evaluate(GameTimeSystem.DayProgressPercent);
        public override float Exponent2 => exponent2.Evaluate(GameTimeSystem.DayProgressPercent);
        public override Color TopColor => topColor.Evaluate(GameTimeSystem.DayProgressPercent);
        public override Color MiddleColor => middleColor.Evaluate(GameTimeSystem.DayProgressPercent);
        public override Color BottomColor => bottomColor.Evaluate(GameTimeSystem.DayProgressPercent);
    }
}