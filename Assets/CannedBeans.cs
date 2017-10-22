using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CannedBeans : MonoBehaviour {

    [SerializeField] private GameObject beans;
    [SerializeField] private GameObject spawnPoint;
    private float timeRemaining;
    private const float spawnRate = .40F;
    
    private const int MAX_CEREAL_COUNT = 160;
    private List<GameObject> beansList;

    // Use this for initialization
    void Start()
    {
        timeRemaining = spawnRate;
        beansList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

        if ((Math.Abs(this.transform.rotation.eulerAngles.x % 360) >= 90 
            && Math.Abs(this.transform.rotation.eulerAngles.x % 360) <= 270)
            ||
            (Math.Abs(this.transform.rotation.eulerAngles.z % 360) >= 90
            && Math.Abs(this.transform.rotation.eulerAngles.z % 360) <= 270))
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining <= 0)
            {
                //Spawn stuff
                spawnCereal();
                
                // Delete old cereal
                while (beansList.Count >= MAX_CEREAL_COUNT)
                {
                    Destroy(beansList[0]);
                    beansList.RemoveAt(0);
                }

                timeRemaining = spawnRate;
            }
        }
        else
        {
            timeRemaining = spawnRate;
        }
    }
    
    void spawnCereal()
    {
        GameObject spawnedCereal;
        Quaternion startRotation = Quaternion.Euler(Vector3.zero);
        Vector3 spawnLocation = spawnPoint.transform.position;
        spawnedCereal = GameObject.Instantiate(beans, spawnLocation, startRotation) as GameObject;
        beansList.Add(spawnedCereal);
    }
}
