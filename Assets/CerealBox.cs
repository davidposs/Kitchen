using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CerealBox : MonoBehaviour {

    [SerializeField] private GameObject cereal;
    [SerializeField] private GameObject spawnPoint;
    private float timeRemaining;
    private const float spawnRate = .10F;
    
    private const int MAX_CEREAL_COUNT = 160;
    private List<GameObject> cerealList;

    // Use this for initialization
    void Start()
    {
        timeRemaining = spawnRate;
        cerealList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

        if ((Math.Abs(this.transform.rotation.eulerAngles.x % 360) >= 0) 
            && (Math.Abs(this.transform.rotation.eulerAngles.x % 360) <= 180))
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining <= 0)
            {
                //Spawn stuff
                spawnCereal();
                
                // Delete old cereal
                while (cerealList.Count >= MAX_CEREAL_COUNT)
                {
                    Destroy(cerealList[0]);
                    cerealList.RemoveAt(0);
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
        spawnedCereal = GameObject.Instantiate(cereal, spawnLocation, startRotation) as GameObject;
        cerealList.Add(spawnedCereal);
    }
}
