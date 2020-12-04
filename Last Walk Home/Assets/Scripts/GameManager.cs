using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GamestateTracker stateTracker;


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckState()
    {
        stateTracker = GameObject.FindGameObjectWithTag("Player").GetComponent<GamestateTracker>();
        if(stateTracker != null)
        {
            stateTracker.Updatestep();
        }
    }
}
