﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileGaze : MonoBehaviour, IGvrGazeResponder {

	/// Called when the user is looking on a GameObject with this script,
	/// as long as it is set to an appropriate layer (see GvrGaze).
	public void OnGazeEnter() {
		GetComponent<Renderer>().material.color = Color.green;
	}

	/// Called when the user stops looking on the GameObject, after OnGazeEnter
	/// was already called.
	public void OnGazeExit() {
		GetComponent<Renderer>().material.color = Color.red;
	}

	/// Called when the viewer's trigger is used, between OnGazeEnter and OnGazeExit.
	public void OnGazeTrigger() {
		GetComponent<Renderer>().material.color = Color.blue;
	}
}
