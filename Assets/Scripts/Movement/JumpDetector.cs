using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpDetector : MonoBehaviour
{
    public bool onGround = false;
    private void OnTriggerEnter(Collider other)
    {
        onGround = true;
    }

    private void OnTriggerExit(Collider other)
    {
        onGround = false;
    }
}
