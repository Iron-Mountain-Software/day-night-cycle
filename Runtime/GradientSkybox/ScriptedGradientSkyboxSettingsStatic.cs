using UnityEngine;

namespace IronMountain.DayNightCycle.GradientSkybox
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Gameplay/Lighting/Gradient Skybox/Static Settings")]
    public class ScriptedGradientSkyboxSettingsStatic : ScriptedGradientSkyboxSettings
    {
        [SerializeField] private float intensity = 1f;
        [SerializeField] private float exponent1 = 1f;
        [SerializeField] private float exponent2 = 1f;
        [SerializeField] private Color topColor = new (0f, 0.64f, 1f);
        [SerializeField] private Color middleColor = new (0f, 0.53f, 1f);
        [SerializeField] private Color bottomColor = new (0f, 0.21f, 0.52f);

        public override float Intensity => intensity;
        public override float Exponent1 => exponent1;
        public override float Exponent2 => exponent2;
        public override Color TopColor => topColor;
        public override Color MiddleColor => middleColor;
        public override Color BottomColor => bottomColor;
    }
}