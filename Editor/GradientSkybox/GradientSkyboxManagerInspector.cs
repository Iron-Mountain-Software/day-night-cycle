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
            EditorGUI.BeginDisabledGroup(true);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("m_Script"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("shader"));
            EditorGUI.EndDisabledGroup();
            EditorGUILayout.PropertyField(serializedObject.FindProperty("scriptedSettings"));
            serializedObject.ApplyModifiedProperties();
            if (_gradientSkyboxManager && _gradientSkyboxManager.ScriptedSettings)
            {
                CreateCachedEditor(_gradientSkyboxManager.ScriptedSettings, null, ref _gradientSkyboxSettingsInspector);
                EditorGUI.indentLevel++;
                _gradientSkyboxSettingsInspector.OnInspectorGUI();
                EditorGUI.indentLevel--;
            }
            else _gradientSkyboxSettingsInspector = null;
        }
    }
}