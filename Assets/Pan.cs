using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pan : MonoBehaviour {
    [SerializeField] private GameObject cylinder;
    [SerializeField] private new ParticleSystem particleSystem;
    private Renderer meshRenderer;
    private int brothDropCount;
    private const int MAX_VOLUME = 100;
    // Use this for initialization
    void Start() {
        meshRenderer = cylinder.GetComponent<Renderer>();
        meshRenderer.enabled = false;
        brothDropCount = 0;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnParticleCollision(GameObject other)
    {
        if (other.GetComponent<ParticleSystem>() == particleSystem)
        {
            brothDropCount++;
            if (brothDropCount >= MAX_VOLUME)
            {
                meshRenderer.enabled = true;
            }
        }
    }
}
