using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceToStart : MonoBehaviour {

    public GameObject StartPiece;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartPiece.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
