﻿using UnityEngine;
using System.Collections;

public class camercontroller : MonoBehaviour {

	// Use this for initialization
    public GameObject player;
    private Vector3 offset;

	void Start () 
    {
        offset = transform.position;
	
	}
	
	// Update is called once per frame
	void LateUpdate () 
    {
        transform.position = player.transform.position + offset;
	}
}
