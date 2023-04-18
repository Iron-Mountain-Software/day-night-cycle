using SpellBoundAR.Lighting.Fog;
using UnityEditor;

namespace SpellBoundAR.Lighting.Editor
{
    [CustomEditor(typeof(ScriptedFogSettingsStatic))]
    public class ScriptedFogSettingsStaticInspector : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty("enabled"));
            if (serializedObject.FindProperty("enabled").boolValue)
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("color"));
                EditorGUILayout.PropertyField(serializedObject.FindProperty("mode"));
                if (serializedObject.FindProperty("mode").enumValueIndex == 0)
                {
                    EditorGUILayout.PropertyField(serializedObject.FindProperty("startDistance"));
                    EditorGUILayout.PropertyField(serializedObject.FindProperty("endDistance"));
                }
                else EditorGUILayout.PropertyField(serializedObject.FindProperty("density"));
            }
            serializedObject.ApplyModifiedProperties();
        }
    }
}