using IronMountain.DayNightCycle.GradientSkybox;
using UnityEditor;

namespace IronMountain.DayNightCycle.Editor.GradientSkybox
{
    [CustomEditor(typeof(GradientSkyboxManager), true)]
    public class GradientSkyboxManagerInspector : UnityEditor.Editor
    {
        private GradientSkyboxManager _gradientSkyboxManager;
        private UnityEditor.Editor _gradientSkyboxSettingsInspector;

        private void OnEnable()
        {
            _gradientSkyboxManager = (GradientSkyboxManager) target;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (_gradientSkyboxManager && _gradientSkyboxManager.ScriptedSettings)
            {
                CreateCachedEditor(_gradientSkyboxManager.ScriptedSettings, null, ref _gradientSkyboxSettingsInspector);
                _gradientSkyboxSettingsInspector.OnInspectorGUI();
            }
            else _gradientSkyboxSettingsInspector = null;
        }
    }
}