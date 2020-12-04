using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Dialogue : MonoBehaviour
{
	public TextMeshProUGUI textDisplay;
	public string[] sentences1;
	public string[] sentences2;
	public string[] sentences3;
	public string[] sentences4;
	public string[] sentences5;
	public string[] sentences6;
	public int sentenceTracker;
	public int index;
	public float typingSpeed;
	
	public GameObject button;
	public bool buttonActive;
	public bool typing;

    private void Start()
    {
		sentenceTracker = GameObject.FindGameObjectWithTag("Player").GetComponent<GamestateTracker>().Gamestep;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (button != null)
        {
            button.SetActive(true);
            buttonActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (button != null)
        {
            button.SetActive(false);
            buttonActive = false;
        }
    }
	
	void Update()
	{
		if (buttonActive)
        {
            if (Input.GetKeyDown(KeyCode.Space)&&button.activeSelf)
            {

				string[] tempSentence = new string[0];

				switch (sentenceTracker)
				{
					case 0:
						tempSentence = sentences1;
						break;
					case 1:
						tempSentence = sentences2;
						break;
					case 2:
						tempSentence = sentences3;
						break;
					case 3:
						tempSentence = sentences4;
						break;
					case 4:
						tempSentence = sentences5;
						break;
					case 5:
						tempSentence = sentences6;
						break;
				}

				if (!typing)
				{
					typing = true;
					//Starts the Dialogue
					StartCoroutine(Type(tempSentence));
				}

				if (textDisplay.text == tempSentence[index])
				{
					//Check's to see if there is more text to display after clicking the button
					button.SetActive(true);
					
					//If there is no more text to display, the button will do nothing
					button.SetActive(false);
				}
					typing = false;
			}	
		}
    }

    internal void isActiveAndEnabled(bool v)
    {
        throw new NotImplementedException();
    }

    public void NextSentence(string[] incSentence) //Inputs the next text to display
	{
		if(index<incSentence.Length - 1) //Displaying where text where possible
		{
			index++;
		}
		else //When the dialogue has finished
		{
			textDisplay.text = "";
			button.SetActive(false);
		}
	}
	
	IEnumerator Type(string[] incSentence) //Gives the text a some-what of a fade animation
	{
		textDisplay.text = ""; //Resets the line
		
		foreach(char letter in incSentence[index].ToCharArray())
		{
			textDisplay.text += letter;
			yield return new WaitForSeconds(0.03f);
		}
		NextSentence(incSentence); //Plays the next sentence
	}
}
