using System;
using UnityEngine;

namespace SpellBoundAR.Lighting
{
    public static class GameTimeSystem
    {
        public const float SecondsInADay = 86400f;

        [Header("Static Time")]
        public static readonly float MinimumStaticTime = 0f;
        public static readonly float DefaultStaticTime = 43200f;
        public static readonly float MaximumStaticTime = 86400f;
        
        [Header("Game Time")]
        private static float StartTime = 43200f;
        private static float TimeScale = 1f;

        [Header("Cache")]
        private static float _staticTime = DefaultStaticTime;
        private static float _secondsAfterMidnight;
        private static int _lastUpdateFrame = -1;
        
        public static float DayProgressPercent => SecondsAfterMidnight / SecondsInADay;
        public static TimeMode TimeMode { get; set; } = TimeMode.System;

        public static float StaticTime
        {
            get => _staticTime;
            set => _staticTime = Mathf.Clamp(value, MinimumStaticTime, MaximumStaticTime);
        }

        private static float SecondsAfterMidnight
        {
            get
            {
                if (_lastUpdateFrame == Time.frameCount) return _secondsAfterMidnight;
                _lastUpdateFrame = Time.frameCount;
                switch (TimeMode)
                {
                    case TimeMode.Game:
                        _secondsAfterMidnight = GetGameSecondsAfterMidnight();
                        break;
                    case TimeMode.Static:
                        _secondsAfterMidnight = StaticTime;
                        break;
                    case TimeMode.System:
                        _secondsAfterMidnight = GetSystemSecondsAfterMidnight();
                        break;
                }
                return _secondsAfterMidnight;
            }
        }

        private static float GetGameSecondsAfterMidnight()
        {
            float seconds = StartTime + (Time.unscaledTime * TimeScale);
            return seconds < SecondsInADay ? seconds : seconds % SecondsInADay;
        }
        
        private static float GetSystemSecondsAfterMidnight()
        {
            DateTime time = DateTime.Now;
            return time.Hour * 3600 + time.Second;
        }
    }
}