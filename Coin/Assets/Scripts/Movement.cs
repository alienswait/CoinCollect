using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float MovementSpeed;
    [SerializeField] float HorSpeed;
    float Hor;

    void Update()
    {
        Hor = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(Hor * HorSpeed * Time.deltaTime, 0, MovementSpeed * Time.deltaTime));
    }
}
