using UnityEngine;
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
            CandyCoded.HapticFeedback.CandyCoded.HapticFeedback.iOS.HapticFeedback.PerformHapticFeedback("light");
#elif UNITY_ANDROID && !UNITY_EDITOR
            CandyCoded.HapticFeedback.Android.HapticFeedback.PerformHapticFeedback(CandyCoded.HapticFeedback.Android.HapticFeedbackConstants.CONTEXT_CLICK);
#endif
#if UNITY_EDITOR
				Debug.Log("Light Haptics");
#endif
			}
		}
		public static void PlayMidHaptics()
		{
			if (CanUseHaptics)
			{
				// Play haptics
#if UNITY_IOS && !UNITY_EDITOR
            CandyCoded.HapticFeedback.iOS.HapticFeedback.PerformHapticFeedback("medium");
#elif UNITY_ANDROID && !UNITY_EDITOR
            CandyCoded.HapticFeedback.Android.HapticFeedback.PerformHapticFeedback(CandyCoded.HapticFeedback.Android.HapticFeedbackConstants.VIRTUAL_KEY);
#endif
#if UNITY_EDITOR
				Debug.Log("Medium Haptics");
#endif
			}
		}
		public static void PlayHeavyHaptics()
		{
			if (CanUseHaptics)
			{
				// Play haptics
#if UNITY_IOS && !UNITY_EDITOR
            CandyCoded.HapticFeedback.iOS.HapticFeedback.PerformHapticFeedback("heavy");
#elif UNITY_ANDROID && !UNITY_EDITOR
            CandyCoded.HapticFeedback.Android.HapticFeedback.PerformHapticFeedback(CandyCoded.HapticFeedback.Android.HapticFeedbackConstants.LONG_PRESS);
#endif
#if UNITY_EDITOR
				Debug.Log("Heavy Haptics");
#endif
			}
		}
		public static void PlaySuperHeavyHaptics()
		{
			if (CanUseHaptics)
			{
				// Play haptics
				Handheld.Vibrate();
#if UNITY_EDITOR
				Debug.Log("Super Heavy Haptics");
#endif
			}
		}
	}
}