using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel2Rotation : MonoBehaviour
{

	void Update ()
    {
        transform.Rotate(new Vector3( 0, 0, Time.deltaTime * -20)); //roteerd het voorwerp om zijn as met een bepaalde snelheid
    }
}
