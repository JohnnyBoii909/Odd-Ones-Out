using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public Direction direction;
    public int levelIndex;
    void OnTriggerEnter2D(Collider2D triggerbox)
    {
        if(triggerbox.GetComponent<PlayerController>())
        {
            PlayerController.inst.direction = direction;
            SceneManager.LoadScene(levelIndex);
        }
    }
}
