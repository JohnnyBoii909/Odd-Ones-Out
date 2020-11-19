using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTrigger : MonoBehaviour
{
    public GameObject button;
    public List<int> triggerSteps;
    public GamestateTracker gamestate;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (button != null)
        {
            button.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (button != null)
        {
            button.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)&&button.activeSelf)
        {
            foreach(int i in triggerSteps)
            {
                if (i == gamestate.Gamestep)
                {
                    gamestate.Gamestep ++;
                    print(gamestate.Gamestep);
                    break;
                }
            }
        }
    }
}
