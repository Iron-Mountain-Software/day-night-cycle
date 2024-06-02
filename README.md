# Day/Night Cycle
*Version: 1.0.5*
## Description: 
Scripted lighting settings, including configurations for day/night cycles, fog, skyboxes, and light sources.
## Use Cases: 
* Managing ambient lighting, directional light directions, fog, and skybox at different times of the day.
## Package Mirrors: 
[<img src='https://img.itch.zone/aW1nLzEzNzQ2ODk4LnBuZw==/original/Rv4m96.png'>](https://iron-mountain.itch.io/day-night-cycle)[<img src='https://img.itch.zone/aW1nLzEzNzQ2ODkyLnBuZw==/original/Fq0ORM.png'>](https://www.npmjs.com/package/com.iron-mountain.day-night-cycle)[<img src='https://img.itch.zone/aW1nLzEzNzQ2ODg3LnBuZw==/original/npRUfq.png'>](https://github.com/Iron-Mountain-Software/day-night-cycle)
---
## Key Scripts & Components: 
1. public class **DynamicLightColor** : MonoBehaviour
1. public static class **GameTimeSystem**
1. public class **GameTimeSystemDebugger** : MonoBehaviour
1. public enum **TimeMode** : Enum
### Ambient Lighting
1. public class **AmbientLightingManager** : MonoBehaviour
   * Properties: 
      * public ScriptedAmbientLightingSettings ***ScriptedSettings***  { get; set; }
      * public IAmbientLightingSettings ***Settings***  { get; }
   * Methods: 
      * public void ***ResetToInitialState***()
1. public class **AmbientLightingSettings**
   * Properties: 
      * public AmbientMode ***Mode***  { get; }
      * public float ***Intensity***  { get; }
      * public Color ***SkyColor***  { get; }
      * public Color ***EquatorColor***  { get; }
      * public Color ***GroundColor***  { get; }
1. public interface **IAmbientLightingSettings**
   * Properties: 
      * public AmbientMode ***Mode***  { get; }
      * public float ***Intensity***  { get; }
      * public Color ***SkyColor***  { get; }
      * public Color ***EquatorColor***  { get; }
      * public Color ***GroundColor***  { get; }
1. public abstract class **ScriptedAmbientLightingSettings** : ScriptableObject
   * Properties: 
      * public AmbientMode ***Mode***  { get; }
      * public float ***Intensity***  { get; }
      * public Color ***SkyColor***  { get; }
      * public Color ***EquatorColor***  { get; }
      * public Color ***GroundColor***  { get; }
1. public class **ScriptedAmbientLightingSettingsDynamic** : ScriptedAmbientLightingSettings
   * Properties: 
      * public float ***Intensity***  { get; }
      * public Color ***SkyColor***  { get; }
      * public Color ***EquatorColor***  { get; }
      * public Color ***GroundColor***  { get; }
1. public class **ScriptedAmbientLightingSettingsStatic** : ScriptedAmbientLightingSettings
   * Properties: 
      * public float ***Intensity***  { get; }
      * public Color ***SkyColor***  { get; }
      * public Color ***EquatorColor***  { get; }
      * public Color ***GroundColor***  { get; }
### Fog
1. public class **FogManager** : MonoBehaviour
   * Properties: 
      * public ScriptedFogSettings ***ScriptedFogSettings***  { get; set; }
      * public IFogSettings ***Settings***  { get; }
   * Methods: 
      * public void ***ResetToInitialState***()
1. public class **FogSettings**
   * Properties: 
      * public Boolean ***Enabled***  { get; set; }
      * public FogMode ***Mode***  { get; set; }
      * public Color ***Color***  { get; set; }
      * public float ***Density***  { get; set; }
      * public float ***StartDistance***  { get; set; }
      * public float ***EndDistance***  { get; set; }
1. public interface **IFogSettings**
   * Properties: 
      * public Boolean ***Enabled***  { get; }
      * public FogMode ***Mode***  { get; }
      * public Color ***Color***  { get; }
      * public float ***Density***  { get; }
      * public float ***StartDistance***  { get; }
      * public float ***EndDistance***  { get; }
1. public abstract class **ScriptedFogSettings** : ScriptableObject
   * Properties: 
      * public Boolean ***Enabled***  { get; }
      * public FogMode ***Mode***  { get; }
      * public Color ***Color***  { get; }
      * public float ***Density***  { get; }
      * public float ***StartDistance***  { get; }
      * public float ***EndDistance***  { get; }
1. public class **ScriptedFogSettingsDynamic** : ScriptedFogSettings
   * Properties: 
      * public Color ***Color***  { get; }
      * public float ***Density***  { get; }
      * public float ***StartDistance***  { get; }
      * public float ***EndDistance***  { get; }
1. public class **ScriptedFogSettingsStatic** : ScriptedFogSettings
   * Properties: 
      * public Color ***Color***  { get; }
      * public float ***Density***  { get; }
      * public float ***StartDistance***  { get; }
      * public float ***EndDistance***  { get; }
### Gradient Skybox
1. public class **GradientSkyboxManager** : MonoBehaviour
   * Properties: 
      * public ScriptedGradientSkyboxSettings ***ScriptedSettings***  { get; set; }
      * public IGradientSkyboxSettings ***Settings***  { get; }
   * Methods: 
      * public void ***ResetToInitialState***()
      * public void ***OnEnable***()
      * public void ***Update***()
1. public class **GradientSkyboxSettings**
   * Properties: 
      * public float ***Intensity***  { get; }
      * public float ***Exponent1***  { get; }
      * public float ***Exponent2***  { get; }
      * public Color ***TopColor***  { get; }
      * public Color ***MiddleColor***  { get; }
      * public Color ***BottomColor***  { get; }
1. public interface **IGradientSkyboxSettings**
   * Properties: 
      * public float ***Intensity***  { get; }
      * public float ***Exponent1***  { get; }
      * public float ***Exponent2***  { get; }
      * public Color ***TopColor***  { get; }
      * public Color ***MiddleColor***  { get; }
      * public Color ***BottomColor***  { get; }
1. public abstract class **ScriptedGradientSkyboxSettings** : ScriptableObject
   * Properties: 
      * public float ***Intensity***  { get; }
      * public float ***Exponent1***  { get; }
      * public float ***Exponent2***  { get; }
      * public Color ***TopColor***  { get; }
      * public Color ***MiddleColor***  { get; }
      * public Color ***BottomColor***  { get; }
1. public class **ScriptedGradientSkyboxSettingsDynamic** : ScriptedGradientSkyboxSettings
   * Properties: 
      * public float ***Intensity***  { get; }
      * public float ***Exponent1***  { get; }
      * public float ***Exponent2***  { get; }
      * public Color ***TopColor***  { get; }
      * public Color ***MiddleColor***  { get; }
      * public Color ***BottomColor***  { get; }
1. public class **ScriptedGradientSkyboxSettingsStatic** : ScriptedGradientSkyboxSettings
   * Properties: 
      * public float ***Intensity***  { get; }
      * public float ***Exponent1***  { get; }
      * public float ***Exponent2***  { get; }
      * public Color ***TopColor***  { get; }
      * public Color ***MiddleColor***  { get; }
      * public Color ***BottomColor***  { get; }
