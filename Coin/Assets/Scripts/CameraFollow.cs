using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform Target;
    public Vector3 offset;

    void LateUptade()
    {
        transform.position =Vector3.Lerp(transform.position, Target.position + offset, 0.3f);
    }
}
