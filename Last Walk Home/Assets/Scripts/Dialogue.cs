using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
	public TextMeshProUGUI textDisplay;
	public string[] sentences;
	public int index;
	public float typingSpeed;
	
	public GameObject button;
	public bool buttonActive;
	public bool typing;
	
	
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
				if (!typing)
				{
					typing = true;
					//Starts the Dialogue
					StartCoroutine(Type());
				}
				
                if(textDisplay.text == sentences[index])
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
	
	public void NextSentence() //Inputs the next text to display
	{
		if(index<sentences.Length - 1) //Displaying where text where possible
		{
			index++;
		}
		else //When the dialogue has finished
		{
			textDisplay.text = "";
			button.SetActive(false);
		}
	}
	
	IEnumerator Type() //Gives the text a some-what of a fade animation
	{
		textDisplay.text = ""; //Resets the line
		
		foreach(char letter in sentences[index].ToCharArray())
		{
			textDisplay.text += letter;
			yield return new WaitForSeconds(0.03f);
		}
		NextSentence(); //Plays the next sentence
	}
}
