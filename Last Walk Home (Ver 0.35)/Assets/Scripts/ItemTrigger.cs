using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTrigger : MonoBehaviour
{
    public GameObject button;
    public bool buttonActive;
    public ItemTrade ProgressChecker;
    [SerializeField] Items item;
    public bool thisInterract = false;

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
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (!thisInterract)
                {
                    print("Interact");
                    ProgressChecker.haveItem(item);
                    thisInterract = true;
                }
            }
        }

        if (thisInterract)
        {
            button.SetActive(false);
        }


    }
}
