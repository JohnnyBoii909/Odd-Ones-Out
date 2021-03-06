﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    public Direction direction;
    public int levelIndex;
    public void OnTriggerEnter2D(Collider2D triggerbox)
    {
        if(triggerbox.GetComponent<PlayerController>())
        {
            PlayerController.inst.direction = direction;
            SceneManager.LoadScene(levelIndex);
        }
    }

    private void Start()
    {
        GameManager gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        if(gm != null)
        {
            gm.CheckState();
        }
    }
}
