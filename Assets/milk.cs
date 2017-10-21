using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Milk : MonoBehaviour {
    [SerializeField] private ParticleSystem particleSystem;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.rotation.eulerAngles.y >= 90)
        {

        }
	}
}
