using UnityEngine;

namespace IronMountain.DayNightCycle.Fog
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Gameplay/Lighting/Fog/Dynamic Settings")]
    public class ScriptedFogSettingsDynamic : ScriptedFogSettings
    {
        [SerializeField] private Gradient gradient = new ();
        [SerializeField] private AnimationCurve density = new (new Keyframe(0, .02f));
        [SerializeField] private AnimationCurve startDistance = new (new Keyframe(0, 1f));
        [SerializeField] private AnimationCurve endDistance = new (new Keyframe(0, 100f));
        
        public override Color Color => gradient.Evaluate(GameTimeSystem.DayProgressPercent);
        public override float Density => density.Evaluate(GameTimeSystem.DayProgressPercent);
        public override float StartDistance => startDistance.Evaluate(GameTimeSystem.DayProgressPercent);
        public override float EndDistance => endDistance.Evaluate(GameTimeSystem.DayProgressPercent);
    }
}