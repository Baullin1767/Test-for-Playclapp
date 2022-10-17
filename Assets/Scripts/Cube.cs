using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

[RequireComponent(typeof(Rigidbody))]
public class Cube : MonoBehaviour
{
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    public void SetVelosity(float speed)
    {
        rb.velocity = new Vector3(0, 0, speed);
    }

    public void Destroyer() { Destroy(gameObject); }
}
