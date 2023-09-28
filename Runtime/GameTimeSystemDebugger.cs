using UnityEngine;

namespace IronMountain.DayNightCycle
{
    [ExecuteAlways]
    public class GameTimeSystemDebugger : MonoBehaviour
    {
        [SerializeField] private TimeMode timeMode;
        [SerializeField] [Range(0, 86400f)] private float staticTime;

        private void OnEnable()
        {
            timeMode = GameTimeSystem.TimeMode;
            staticTime = GameTimeSystem.StaticTime;
        }

        private void OnValidate()
        {
            GameTimeSystem.TimeMode = timeMode;
            GameTimeSystem.StaticTime = staticTime;
        }
    }
}
