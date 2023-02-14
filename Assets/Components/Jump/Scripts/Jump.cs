using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody physics;

    public void DoJump(float force)
    {
        physics.AddForce(Vector3.up * force, ForceMode.Impulse);
    }
}
