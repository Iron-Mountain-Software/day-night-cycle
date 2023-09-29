using IronMountain.DayNightCycle.Fog;
using UnityEditor;

namespace IronMountain.DayNightCycle.Editor.Fog
{
    [CustomEditor(typeof(FogManager), true)]
    public class FogManagerInspector : UnityEditor.Editor
    {
        private FogManager _fogManager;
        private UnityEditor.Editor _fogSettingsInspector;

        private void OnEnable()
        {
            _fogManager = (FogManager) target;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (_fogManager && _fogManager.ScriptedFogSettings)
            {
                CreateCachedEditor(_fogManager.ScriptedFogSettings, null, ref _fogSettingsInspector);
                _fogSettingsInspector.OnInspectorGUI();
            }
            else _fogSettingsInspector = null;
        }
    }
}