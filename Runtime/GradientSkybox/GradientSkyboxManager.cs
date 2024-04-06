using System;
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

        [SerializeField] private Shader shader;
        [SerializeField] private ScriptedGradientSkyboxSettings scriptedSettings;

        [Header("Cache")]
        private Material _material;
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

        private void OnValidate()
        {
            if (!shader) shader = Shader.Find("Skybox/Gradient Skybox");
        }

        private void Awake()
        {
            OnValidate();
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
        
        public void OnEnable() => RefreshSkybox();
        public void Update() => RefreshSkybox();

        private void RefreshSkybox()
        {
            if (!_material && shader) _material = new Material(shader);
            if (!_material) return;
            RenderSettings.skybox = _material;
            RenderSettings.skybox.SetColor(TopColor, Settings.TopColor);
            RenderSettings.skybox.SetColor(MiddleColor, Settings.MiddleColor);
            RenderSettings.skybox.SetColor(BottomColor, Settings.BottomColor);
        }
    }
}