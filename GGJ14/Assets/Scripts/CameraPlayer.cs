using UnityEngine;
using System.Collections;

public class CameraPlayer : MonoBehaviour
{
	void FixedUpdate ()
    {
        transform.Translate(Vector3.forward * .1f);
	}
}
