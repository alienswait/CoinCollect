using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMovement : MonoBehaviour
{
    public Transform connectNode;
    public float nodeSpeed;

    private void Update()
    {
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, connectNode.position.x, Time.deltaTime * 20), connectNode.position.y, connectNode.position.z + 1);
    }
}
