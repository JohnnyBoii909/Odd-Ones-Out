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
	
	public GameObject button;
	public GameObject continueButton;
	public bool buttonActive;
	
	
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
            if (Input.GetKeyDown("f"))
            {
				//Starts the Dialogue
				StartCoroutine(Type());
				
                if(textDisplay.text == sentences[index])
				{
					//Check's to see if there is more text to display after clicking the continue button
					continueButton.SetActive(true);
					
					//If there is no more text to display, the continue button will do nothing
					continueButton.SetActive(false);
				}	
			}	
		}
    }
	
	public void NextSentence() //Inputs the next text to display
	{
		if(index<sentences.Length - 1)
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
	
	IEnumerator Type() //Gives the text a some-what of a fade animation
	{
		foreach(char letter in sentences[index].ToCharArray())
		{
			textDisplay.text += letter;
			yield return new WaitForSeconds(0.03f);
		}
	}
}
