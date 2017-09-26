using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour {

    // Use this for initialization
    public GameObject projectile;
    void OnTriggerEnter()
    {
        //fire bullet
        projectile.GetComponent<ConstantForce>().enabled = true;
    }
}
