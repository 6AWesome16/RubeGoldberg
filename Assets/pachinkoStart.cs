using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pachinkoStart : MonoBehaviour {

    // Use this for initialization
    public GameObject removable;
    void OnTriggerEnter()
    {
        Destroy(removable);//this will delete the whole game object
    }
}
