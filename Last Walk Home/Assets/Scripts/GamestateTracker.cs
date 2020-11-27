using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamestateTracker : MonoBehaviour
{
    public BoxCollider2D dco;

    public int Gamestep = 0;
    public void Updatestep()
    {
        switch (Gamestep)
        {
            case 0:
                //nothing 
                break;
            case 1:
                //All functions 1
                break;
            case 2:
                //All functions 2
                break;
            case 3:
                //All functions 3
                break;
            case 4:
                //All functions 4
                break;
            case 5:
                dco = GameObject.FindGameObjectWithTag("Dog").GetComponent<BoxCollider2D>();
                dco.enabled = false;
                break;
        }
    }
}
