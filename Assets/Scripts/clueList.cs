using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clueList : MonoBehaviour {

	public static clueList instance;
	public int noOfCluesObtained;
	public Text[] clueTexts;
	public GameObject[] cluePanels;

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
		noOfCluesObtained = 0;		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void AddClueToList(int id)
	{
		noOfCluesObtained++;
		cluePanels [id].SetActive (true);
		clueTexts [id].text = "Clue :" + noOfCluesObtained;
		cluePanels [id].transform.SetSiblingIndex (noOfCluesObtained-1);
	}
}
