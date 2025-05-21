using UnityEngine;
using CandyCoded.HapticFeedback;
namespace DT.Haptics
{
	public class Haptics : MonoBehaviour
	{
		public static bool CanUseHaptics { get; set; } = true;

		public static void PlayLowHaptics()
		{
			if (CanUseHaptics)
			{
				// Play haptics
#if UNITY_IOS && !UNITY_EDITOR
            iOS.HapticFeedback.PerformHapticFeedback("light");
#elif UNITY_ANDROID && !UNITY_EDITOR
            Android.HapticFeedback.PerformHapticFeedback(Android.HapticFeedbackConstants.CONTEXT_CLICK);
#endif
				Debug.Log("Light Haptics");
			}
		}
		public static void PlayMidHaptics()
		{
			if (CanUseHaptics)
			{
				// Play haptics
#if UNITY_IOS && !UNITY_EDITOR
            iOS.HapticFeedback.PerformHapticFeedback("medium");
#elif UNITY_ANDROID && !UNITY_EDITOR
            Android.HapticFeedback.PerformHapticFeedback(Android.HapticFeedbackConstants.VIRTUAL_KEY);
#endif
				Debug.Log("Medium Haptics");
			}
		}
		public static void PlayHeavyHaptics()
		{
			if (CanUseHaptics)
			{
				// Play haptics
#if UNITY_IOS && !UNITY_EDITOR
            iOS.HapticFeedback.PerformHapticFeedback("heavy");
#elif UNITY_ANDROID && !UNITY_EDITOR
            Android.HapticFeedback.PerformHapticFeedback(Android.HapticFeedbackConstants.LONG_PRESS);
#endif
				Debug.Log("Heavy Haptics");
			}
		}
		public static void PlaySuperHeavyHaptics()
		{
			if (CanUseHaptics)
			{
				// Play haptics
				Handheld.Vibrate();
				Debug.Log("Super Heavy Haptics");
			}
		}
	}
}