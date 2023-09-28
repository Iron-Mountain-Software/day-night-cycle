using IronMountain.DayNightCycle.Fog;
using UnityEditor;

namespace IronMountain.DayNightCycle.Editor.Fog
{
    [CustomEditor(typeof(ScriptedFogSettingsDynamic))]
    public class ScriptedFogSettingsDynamicInspector : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty("enabled"));
            if (serializedObject.FindProperty("enabled").boolValue)
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("gradient"));
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