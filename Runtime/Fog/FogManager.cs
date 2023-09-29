using UnityEngine;

namespace IronMountain.DayNightCycle.Fog
{
    [ExecuteAlways]
    [DisallowMultipleComponent]
    public class FogManager : MonoBehaviour
    {
        public static FogManager Instance { get; private set; }

        [SerializeField] private ScriptedFogSettings scriptedFogSettings;

        [Header("Cache")]
        private ScriptedFogSettings _initialSettings;
        private IFogSettings _defaultSettings;

        public ScriptedFogSettings ScriptedFogSettings
        {
            get => scriptedFogSettings;
            set => scriptedFogSettings = value;
        }
        
        public IFogSettings Settings
        {
            get
            {
                if (scriptedFogSettings) return scriptedFogSettings;
                if (_defaultSettings != null) return _defaultSettings;
                _defaultSettings = new FogSettings();
                return _defaultSettings;
            }
        }
        
        private void Awake()
        {
            if (Instance != this && Instance != null) Destroy(gameObject);
            else Instance = this;
            _initialSettings = scriptedFogSettings;
        }

        private void OnDestroy()
        {
            if (Instance != this) return;
            Instance = null;
        }

        public void ResetToInitialState()
        {
            ScriptedFogSettings = _initialSettings;
        }

        private void Update()
        {
            RenderSettings.fog = Settings.Enabled;
            RenderSettings.fogColor = Settings.Color;
            RenderSettings.fogMode = Settings.Mode;
            RenderSettings.fogDensity = Settings.Density;
            RenderSettings.fogStartDistance = Settings.StartDistance;
            RenderSettings.fogEndDistance = Settings.EndDistance;
        }
    }
}