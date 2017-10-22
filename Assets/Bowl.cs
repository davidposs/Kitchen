using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowl : MonoBehaviour {
    [SerializeField] private GameObject cylinder;
    [SerializeField] private new ParticleSystem particleSystem;
	private Renderer meshRenderer;
    private int milkDropCount;
    private const int MAX_VOLUME = 100;
    // Use this for initialization
    void Start () {
        meshRenderer = cylinder.GetComponent<Renderer>(); 
        meshRenderer.enabled = false;
        milkDropCount = 0;   
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnParticleCollision(GameObject other)
    {
        if (other.GetComponent<ParticleSystem>() == particleSystem)
        {
            milkDropCount++;
            if(milkDropCount >= MAX_VOLUME)
            {
                meshRenderer.enabled = true;
            }
        }
    }
}
