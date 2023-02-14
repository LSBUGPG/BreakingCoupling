using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            SendMessage("DoJump");
        }
    }
}
