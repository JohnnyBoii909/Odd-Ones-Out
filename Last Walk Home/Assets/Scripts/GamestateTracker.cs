using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamestateTracker : MonoBehaviour
{
    public BoxCollider2D dco;
    public GameObject ItemOnUI;
    public int Gamestep = 0;
    public void Updatestep()
    {
        switch (Gamestep)
        {
            case 0:
                //before talking to dog 
               ItemOnUI = GameObject.FindGameObjectWithTag("Coin");
               if (ItemOnUI != null)
                {
                    ItemOnUI.SetActive(true);   
                }
                break;
            case 1:
                //after dog interaction
                break;
            case 2:
                //after employee interaction
                break;
            case 3:
                //After cigarette
                break;
            case 4:
                //get burger
                break;
            case 5:
                //after Dog fed
                dco = GameObject.FindGameObjectWithTag("Dog").GetComponent<BoxCollider2D>();
                dco.enabled = false;
                break;
        }
    }
}
