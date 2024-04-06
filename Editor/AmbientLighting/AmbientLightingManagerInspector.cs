using IronMountain.DayNightCycle.AmbientLighting;
using UnityEditor;

namespace IronMountain.DayNightCycle.Editor.AmbientLighting
{
    [CustomEditor(typeof(AmbientLightingManager), true)]
    public class AmbientLightingManagerInspector : UnityEditor.Editor
    {
        private AmbientLightingManager _ambientLightingManager;
        private UnityEditor.Editor _ambientLightingSettingsInspector;

        private void OnEnable()
        {
            _ambientLightingManager = (AmbientLightingManager) target;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (_ambientLightingManager && _ambientLightingManager.ScriptedSettings)
            {
                CreateCachedEditor(_ambientLightingManager.ScriptedSettings, null, ref _ambientLightingSettingsInspector);
                EditorGUI.indentLevel++;
                _ambientLightingSettingsInspector.OnInspectorGUI();
                EditorGUI.indentLevel--;
            }
            else _ambientLightingSettingsInspector = null;
        }
    }
}
