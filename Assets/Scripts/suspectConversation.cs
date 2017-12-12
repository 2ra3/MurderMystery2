using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class suspectConversation : MonoBehaviour {

	public Button[] questions;
	public GameObject continueButton;
	public Text[] questionText;
	public Text answerText;
	public GameObject QuestionPanel;
	public int answer;
	public int id;
	public string question;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
	}

	public void StartConversation()
	{
		QuestionPanel.SetActive (true);
		question = "";
		answer = 0;
		continueButton.SetActive (true);
		IntialQuestions ();
	}

	public void IntialQuestions()
	{
		questionText[0].text = "Hello";
		questionText[1].text = "Hey";
		questionText[2].text = "Bye";
	}

	public void Question1()
	{
		questionText[0].text = "Hello1";
		questionText[1].text = "Hey1";
		questionText[2].text = "Bye1";
	}
	public void Question11()
	{
		questionText[0].text = "Hello11";
		questionText[1].text = "Hey11";
		questionText[2].text = "Bye11";
	}
	public void Question2()
	{
		questionText[0].text = "Hello2";
		questionText[1].text = "Hey2";
		questionText[2].text = "Bye2";
	}
	public void Question3()
	{
		continueButton.SetActive (false);
	}
	public void Answer()
	{
		switch (answer) 
		{
		case 1:
			{
				answerText.text = "Ans for Hello";
				break;}
		case 2:{
				answerText.text = "Ans for hye";
				suspectList.instance.AddSuspectToList (id);
				break;}
		case 3:{
				answerText.text = "Ans for Bye";
				break;}
		case 11:
			break;
		}
	}

	public void CalculateAnswer(int i)
	{
		answer = answer * 10 + i ;
		question = "Question" + answer; 
		Answer ();
		Invoke (question,0f);
	}

}
