﻿using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public UIToolkit buttonToolkit;

	// Use this for initialization
	void Start ()
	{
        Debug.Log("drawing button");
        var playButton = UIButton.create("button.png", "button.png", 0, 0);
        playButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}