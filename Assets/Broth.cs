using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broth : MonoBehaviour {
    [SerializeField] private new ParticleSystem particleSystem;

	// Use this for initialization
	void Start () {
        particleSystem.Pause();
	}
	
	// Update is called once per frame
	void Update () {
        if ((Math.Abs(this.transform.rotation.eulerAngles.x % 360) >= 90 && Math.Abs(this.transform.rotation.eulerAngles.x % 360) <= 270)
            || (Math.Abs(this.transform.rotation.eulerAngles.z % 360) >= 90 && Math.Abs(this.transform.rotation.eulerAngles.z % 360) <= 270))
        {
            particleSystem.Play();
        }
        else
        {
            particleSystem.Stop();
        }
	}
}
