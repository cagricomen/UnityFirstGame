﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AlphaPanelManager : MonoBehaviour {

	public GameObject alphaPanel;
	// Use this for initialization
	void Start () {
		alphaPanel.GetComponent<CanvasGroup>().DOFade(0,2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
