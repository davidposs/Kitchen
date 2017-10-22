using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishA : MonoBehaviour {
    [SerializeField] GameObject sandwich;
    [SerializeField] GameObject cheese;
    [SerializeField] GameObject bread;
    [SerializeField] GameObject leek;
    [SerializeField] GameObject cube;

    private bool isCheesePresent;
    private bool isBreadPresent;
    private bool isLeekPresent;
    private const int MAX_SPAWN = 1;
    private int sandwichCount;

    private List<GameObject> ingredientsList;
	// Use this for initialization
	void Start () {
        sandwich.SetActive(false);
        isCheesePresent = false;
        isBreadPresent = false;
        isLeekPresent = false;
        sandwichCount = 0;
        ingredientsList = new List<GameObject>();
        cube.GetComponent<MeshRenderer>().enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        GameObject obj = collision.gameObject;
        if (obj.name == cheese.name)
        {
            if(!ingredientsList.Contains(obj))
            {
                ingredientsList.Add(obj);
            }
            isCheesePresent = true;
        }
        if(obj.name == leek.name)
        {
            if (!ingredientsList.Contains(obj))
            {
                ingredientsList.Add(obj);
            }
            isLeekPresent = true;
        }
        if(obj.name == bread.name)
        {
            if (!ingredientsList.Contains(obj))
            {
                ingredientsList.Add(obj);
            }
            isBreadPresent = true;
        }
        if(isBreadPresent && isCheesePresent && isLeekPresent)
        {
            for(int i = 0; i < ingredientsList.Count; i++)
            {
                Destroy(ingredientsList[i]);
            }
            while (sandwichCount < MAX_SPAWN)
            {
                sandwich.SetActive(true);
                sandwichCount++;
            }
        }
    }
}
