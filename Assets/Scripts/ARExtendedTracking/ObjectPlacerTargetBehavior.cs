﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ObjectPlacerTargetBehavior : ImageTargetBehaviour {

	private bool trackedSuccess = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void OnTrackerUpdate (Status newStatus)
	{
		base.OnTrackerUpdate (newStatus);
		if (newStatus == Status.TRACKED && this.trackedSuccess == false) {
			EventBroadcaster.Instance.PostEvent (EventNames.ExtendTrackEvents.ON_TARGET_SCAN);
			this.trackedSuccess = true;
		}
	}
}