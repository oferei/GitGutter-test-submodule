using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace OneHumus {

	[RequireComponent(typeof(Text))]
	class FpsCounter : MonoBehaviour {

		public string prefix = "FPS: ";

		void Awake() {
			StartCoroutine(show());
		}

		IEnumerator show() {
			Text text = GetComponent<Text>();

			int lastFrameCount = Time.frameCount;

			while (true) {
				yield return new WaitForSeconds(1);
				int fps = Time.frameCount - lastFrameCount;
				lastFrameCount = Time.frameCount;
				text.text = prefix + fps;
			}
		}
	}
}
