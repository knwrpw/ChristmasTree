using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour {

    List<GameObject> ToFreeze = new List<GameObject>();
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collision)
    {
        //collision.gameObject.transform.parent = gameObject.transform;
        //Destroy(GetComponent<OVRGrabbable>());
        Destroy(GetComponent<SphereCollider>());
        Destroy(GetComponent<Rigidbody>());
        Destroy(this);
    }
}
