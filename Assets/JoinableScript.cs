using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoinableScript : MonoBehaviour {

    public GameObject tree;
    private bool isInTree = false;

    // Use this for initialization
    void Start () {
        tree = GameObject.Find("Fir_Tree");
	}
	
	// Update is called once per frame
	void Update () {
        if (isInTree && !(GetComponent<OVRGrabbable>()).isGrabbed)
        {
            transform.parent = tree.transform;
            transform.rotation = Quaternion.identity;
            GetComponent<Rigidbody>().freezeRotation = true;
            //Destroy(GetComponent<OVRGrabbable>());
            //Destroy(GetComponent<SphereCollider>());
            //Destroy(GetComponent<Rigidbody>());
            //Destroy(this);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == tree)
        {
            isInTree = true;

        }
    }

    void OnTriggerExit(Collider collision)
    {

        if (collision.gameObject == tree)
        {
            isInTree = false;
        }
    }

}
