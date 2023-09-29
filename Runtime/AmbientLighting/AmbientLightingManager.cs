using UnityEngine;

namespace IronMountain.DayNightCycle.AmbientLighting
{
    [ExecuteAlways]
    [DisallowMultipleComponent]
    public class AmbientLightingManager : MonoBehaviour
    {
        public static AmbientLightingManager Instance { get; private set; }

        [SerializeField] private ScriptedAmbientLightingSettings scriptedSettings;

        [Header("Cache")]
        private ScriptedAmbientLightingSettings _initialSettings;
        private IAmbientLightingSettings _defaultSettings;

        public ScriptedAmbientLightingSettings ScriptedSettings
        {
            get => scriptedSettings;
            set => scriptedSettings = value;
        }
        
        public IAmbientLightingSettings Settings
        {
            get
            {
                if (scriptedSettings) return scriptedSettings;
                if (_defaultSettings != null) return _defaultSettings;
                _defaultSettings = new AmbientLightingSettings();
                return _defaultSettings;
            }
        }
        
        private void Awake()
        {
            if (Instance != this && Instance != null) Destroy(gameObject);
            else Instance = this;
            _initialSettings = scriptedSettings;
        }

        private void OnDestroy()
        {
            if (Instance != this) return;
            Instance = null;
        }

        public void ResetToInitialState()
        {
            ScriptedSettings = _initialSettings;
        }

        private void Update()
        {
            RenderSettings.ambientMode = Settings.Mode;
            RenderSettings.ambientIntensity = Settings.Intensity;
            RenderSettings.ambientEquatorColor = Settings.EquatorColor;
            RenderSettings.ambientLight = Settings.SkyColor;
            RenderSettings.ambientSkyColor = Settings.SkyColor;
            RenderSettings.ambientGroundColor = Settings.GroundColor;
        }
    }
}