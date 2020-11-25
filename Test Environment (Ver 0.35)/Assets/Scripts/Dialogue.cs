using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
	public TextMeshProUGUI textDisplay;
	public string[] sentences;
	private int index;
	public float typingSpeed;
	
	public GameObject continueButton;
	
	void Start() //Starts the whole system
	{
		StartCoroutine(Type());
	}
	
	void Update()
	{
		if(textDisplay.text == sentences[index])
		{
			//Check's to see if there is more text to display after click the continue button
			continueButton.SetActive(true);
		}
	}
	
	IEnumerator Type() //Gives the text a some-what of a fade animation
	{
		foreach(char letter in sentences[index].ToCharArray())
		{
			textDisplay.text += letter;
			yield return new WaitForSeconds(0.03f);
		}
	}
	
	public void NextSentence() //Inputs the next text to display
	{
		//If there is no more text to display, the continue button will do nothing
		continueButton.SetActive(false);
		
		if(index < sentences.Length - 1) //Displaying text where possible
		{
			index++;
			textDisplay.text = "";
			StartCoroutine(Type());
		}
		else //When the dialogue has finished
		{
			textDisplay.text = "";
			continueButton.SetActive(false);
		}
	}
}
