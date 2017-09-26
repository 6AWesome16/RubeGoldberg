using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //public Transform lookAtTarget, moveToTarget;
    //defines two things of the same type and access level
    public Transform lookAtTarget;
    public Transform moveToTarget;


    void Update()
    {
        //make this transform look at the lookAtTarget

        if (lookAtTarget != null)
        {
            transform.LookAt(lookAtTarget.position);
        }
        //make this transform move towards another transform
        if (moveToTarget != null)
        {
            Vector3 moveDirection = moveToTarget.position - transform.position;
            if (moveDirection.magnitude > 1)
            {
                moveDirection = moveDirection.normalized;
            }
            //actually move the camera now
            transform.position += moveDirection * Time.deltaTime * 10f;
        }
    }
}