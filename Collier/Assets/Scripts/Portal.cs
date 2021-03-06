﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour {

    public string scene;
    public GameObject trans;
    public Sprite spr;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && GameObject.FindGameObjectWithTag("SceneTransition") == null)
        {
            GameObject go = Instantiate(trans);
            if (go.GetComponent<SceneTransition>() != null)
            {
                go.GetComponent<SceneTransition>().Initialize(scene);
            }
            if (go.GetComponent<StoryTransition>() != null)
            {
                go.GetComponent<StoryTransition>().Initialize(scene, spr);
            }
        }
    }
}
