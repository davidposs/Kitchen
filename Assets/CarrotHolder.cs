using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotHolder : Cuttable
{
    [SerializeField] private GameObject babyThree;
    [SerializeField] private GameObject babyTwo;
    [SerializeField] private GameObject babyOne;
    [SerializeField] private GameObject carrot;
    [SerializeField] private GameObject collCylinder;

    // Use this for initialization
    void Start ()
    {
        babyThree.SetActive(false);
        babyTwo.SetActive(false);
        babyOne.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void OnCut()
    {
        babyThree.SetActive(true);
        babyTwo.SetActive(true);
        babyOne.SetActive(true);
        carrot.SetActive(false);
        collCylinder.SetActive(false);
    }
}
