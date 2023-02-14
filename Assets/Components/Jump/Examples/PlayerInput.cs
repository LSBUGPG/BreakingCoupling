using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Jump jump;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            jump.DoJump(5.0f);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            jump.DoJump(10.0f);
        }
    }
}
