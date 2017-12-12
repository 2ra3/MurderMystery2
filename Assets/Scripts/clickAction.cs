using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class clickAction : MonoBehaviour {

	public static clickAction instance;
	public GameObject messagePanel;

	void Awake() 
	{
		if (instance == null)
			instance = this;
		else if (instance != this) 
		{
			Debug.LogWarning("Another instance of new exists, destroying this instance on the GameObject " + gameObject.name + ".");
			DestroyImmediate(this);
		}

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vuforia.CameraDevice.Instance.SetFocusMode(Vuforia.CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);

		if (Input.GetMouseButtonDown (0)) {

			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				//BoxCollider bc = hit.collider as BoxCollider;
				if (hit.collider.tag == "Clue") {
					//Destroy (bc.gameObject);
					hit.collider.SendMessage("DestroyAndBecomeAClue");
					messagePanel.SetActive (true);
					//Also, Instantiate(Clu	eInfoPanel)
				}
				else if (hit.collider.tag == "Suspect") {
					//Destroy (bc.gameObject);
					hit.collider.SendMessage("StartConversation");
					//Also, Instantiate(Clu	eInfoPanel)
				}
			}
		}
	}
}
