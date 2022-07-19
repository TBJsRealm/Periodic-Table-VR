using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring_Rotation : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.1f, 0.1f, 0.5f);
    }
}
