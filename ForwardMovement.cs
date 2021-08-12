using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovement : Movement
{
    private void FixedUpdate()
    {
        Move(Vector3.forward);
    }
}
