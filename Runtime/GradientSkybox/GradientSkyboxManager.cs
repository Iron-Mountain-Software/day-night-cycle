using UnityEngine;

namespace IronMountain.DayNightCycle.GradientSkybox
{
    [ExecuteAlways]
    [DisallowMultipleComponent]
    public class GradientSkyboxManager : MonoBehaviour
    {
        private static readonly int TopColor = Shader.PropertyToID("_TopColor");
        private static readonly int MiddleColor = Shader.PropertyToID("_MiddleColor");
        private static readonly int BottomColor = Shader.PropertyToID("_BottomColor");
        
        public static GradientSkyboxManager Instance { get; private set; }

        [SerializeField] private ScriptedGradientSkyboxSettings scriptedSettings;

        [Header("Cache")]
        private ScriptedGradientSkyboxSettings _initialSettings;
        private IGradientSkyboxSettings _defaultSettings;

        public ScriptedGradientSkyboxSettings ScriptedSettings
        {
            get => scriptedSettings;
            set => scriptedSettings = value;
        }
        
        public IGradientSkyboxSettings Settings
        {
            get
            {
                if (scriptedSettings) return scriptedSettings;
                if (_defaultSettings != null) return _defaultSettings;
                _defaultSettings = new GradientSkyboxSettings();
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
            if (!RenderSettings.skybox) return;
            RenderSettings.skybox.SetColor(TopColor, Settings.TopColor);
            RenderSettings.skybox.SetColor(MiddleColor, Settings.MiddleColor);
            RenderSettings.skybox.SetColor(BottomColor, Settings.BottomColor);
        }
    }
}