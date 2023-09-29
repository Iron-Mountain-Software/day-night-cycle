using IronMountain.DayNightCycle.AmbientLighting;
using UnityEditor;

namespace IronMountain.DayNightCycle.Editor.AmbientLighting
{
    [CustomEditor(typeof(ScriptedAmbientLightingSettings), true)]
    public class ScriptedAmbientLightingSettingsInspector : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty("mode"));
            if (serializedObject.FindProperty("mode").intValue == 0) // Skybox
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("intensity"));
            }
            else if (serializedObject.FindProperty("mode").intValue == 1) // Trilight
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("skyColor"));
                EditorGUILayout.PropertyField(serializedObject.FindProperty("equatorColor"));
                EditorGUILayout.PropertyField(serializedObject.FindProperty("groundColor"));
            }
            else if (serializedObject.FindProperty("mode").intValue == 3) // Flat
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("skyColor"));
            }
            serializedObject.ApplyModifiedProperties();
        }
    }
}
