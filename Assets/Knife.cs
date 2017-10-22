using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        GameObject obj = collision.collider.transform.parent.gameObject;
        if(obj != null)
        {
            if(obj.transform.parent != null)
            {
                obj = obj.transform.parent.gameObject;
            }

            Cuttable cutObject = obj.GetComponent<Cuttable>();

            Debug.Log(collision.collider);
            if (cutObject != null)
            {
                cutObject.OnCut();
            }
        }
    }

}
