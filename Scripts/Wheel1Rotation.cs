using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel1Rotation : MonoBehaviour
{

	void Update ()
    {
        transform.Rotate(new Vector3( 0, 0, Time.deltaTime * 10)); //roteerd het voorwerp om zijn as met een bepaalde snelheid
    }
}
