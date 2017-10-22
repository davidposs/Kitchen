using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatHolder : Cuttable
{
    [SerializeField] private GameObject cubeFive;
    [SerializeField] private GameObject cubeFour;
    [SerializeField] private GameObject cubeThree;
    [SerializeField] private GameObject cubeTwo;
    [SerializeField] private GameObject cubeOne;
    [SerializeField] private GameObject meat;
    [SerializeField] private GameObject collCylinder;

    // Use this for initialization
    void Start ()
    {
        cubeOne.SetActive(false);
        cubeTwo.SetActive(false);
        cubeThree.SetActive(false);
        cubeFour.SetActive(false);
        cubeFive.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void OnCut()
    {
        cubeFive.SetActive(true);
        cubeFour.SetActive(true);
        cubeThree.SetActive(true);
        cubeTwo.SetActive(true);
        cubeOne.SetActive(true);
        meat.SetActive(false);
        collCylinder.SetActive(false);
    }
}
