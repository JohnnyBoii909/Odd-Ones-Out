using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GamestateTracker gst = GameObject.FindGameObjectWithTag("Player").GetComponent<GamestateTracker>();
         if(gst.Gamestep == 5)
        {
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
