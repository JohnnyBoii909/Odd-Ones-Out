using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{

    public GameObject button;
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

    // Update is called once per frame
    void Update()
    {
        if (buttonActive)
        {
            if (Input.GetKeyDown("f"))
            {
                print("YIKES!");
            }
        }
    }
    

}
