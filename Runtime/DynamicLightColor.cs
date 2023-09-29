using UnityEngine;

namespace IronMountain.DayNightCycle
{
    [ExecuteAlways]
    [RequireComponent(typeof(Light))]
    public class DynamicLightColor : MonoBehaviour
    {
        [SerializeField] private new Light light;
        [SerializeField] [GradientUsage(true)] private Gradient color;
        
        private void Awake()
        {
            if (!light) light = GetComponent<Light>();
        }

        private void OnValidate()
        {
            if (!light) light = GetComponent<Light>();
        }

        private void Update()
        {
            if (light) light.color = color.Evaluate(GameTimeSystem.DayProgressPercent);
        }
    }
}