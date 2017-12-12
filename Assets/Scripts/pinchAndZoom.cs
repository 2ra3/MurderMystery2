using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinchAndZoom : MonoBehaviour {

	public float speed;
	public RectTransform content;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// If there are two touches on the device...
		if (Input.touchCount == 2) {
			// Store both touches.

			Touch touchZero = Input.GetTouch (0);
			Touch touchOne = Input.GetTouch (1);

			// Find the position in the previous frame of each touch.
			Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
			Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

			// Find the magnitude of the vector (the distance) between the touches in each frame.
			float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
			float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

			// Find the difference in the distances between each frame.
			float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

			content.sizeDelta = new Vector2 (Mathf.Clamp (content.sizeDelta.x+deltaMagnitudeDiff*speed, 2765, 2765 * 4),
				Mathf.Clamp (content.sizeDelta.y+deltaMagnitudeDiff*speed, 3629, 3629 * 4));
			Debug.Log(content.sizeDelta);
		}
	}
}
