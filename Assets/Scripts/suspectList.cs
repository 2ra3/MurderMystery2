using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class suspectList : MonoBehaviour {

	public static suspectList instance;
	public int noOfSuspectsObtained;
	public Text[] suspectTexts;
	public GameObject[] suspectPanels;
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
	void Start () 
	{
		noOfSuspectsObtained = 0;		
	}

	// Update is called once per frame
	void Update () 
	{

	}

	public void AddSuspectToList(int id)
	{
		noOfSuspectsObtained++;
		suspectPanels [id].SetActive (true);
		suspectTexts [id].text = "Suspect :" + noOfSuspectsObtained;
		suspectPanels [id].transform.SetSiblingIndex (noOfSuspectsObtained-1);
		messagePanel.SetActive (true);
	}
}
