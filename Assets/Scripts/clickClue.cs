using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickClue : MonoBehaviour {
	
	public int id;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void DestroyAndBecomeAClue()
	{
		clueList.instance.AddClueToList (id);	
		Destroy(gameObject);
	}
}
	
