using UnityEngine;
using CandyCoded.HapticFeedback;
namespace DT.Haptics
{
	public class Haptics : MonoBehaviour
	{
		public static bool CanUseHaptics { get; set; }

		public static void PlayLowHaptics()
		{
			if (CanUseHaptics)
			{
				// Play haptics
				HapticFeedback.LightFeedback();
				Debug.Log("Light Haptics");
			}
		}
		public static void PlayMidHaptics()
		{
			if (CanUseHaptics)
			{
				// Play haptics
				HapticFeedback.MediumFeedback();
				Debug.Log("Medium Haptics");
			}
		}
		public static void PlayHeavyHaptics()
		{
			if (CanUseHaptics)
			{
				// Play haptics
				HapticFeedback.HeavyFeedback();
				Debug.Log("Heavy Haptics");
			}
		}
	}
}