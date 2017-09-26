using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour {

    public Transform lookOverride;
    public Transform moveOverride;

    void OnTriggerEnter(Collider activator)
    {
        Debug.Log(this.name + " got triggered by " + activator.name);

        CameraController camcontrol = Camera.main.GetComponent<CameraController>();
        //override cameracontrol values with this trigger's values
        if (lookOverride != null)
        {
            camcontrol.lookAtTarget = lookOverride;
        }
        if (moveOverride != null)
        {
            camcontrol.moveToTarget = moveOverride;
        }
    }
    //draw debug lines inside the unity editor's scene view
    void OnDrawGizmos()
    {
        if (lookOverride != null)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(transform.position, lookOverride.position);
        }
        if (moveOverride != null)
        {
            Gizmos.color = Color.magenta;
            Gizmos.DrawLine(transform.position, moveOverride.position);
        }
    }
}
