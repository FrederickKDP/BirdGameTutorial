using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalConstMotion : MonoBehaviour {
    public static Vector3 speed = -Vector3.right;

	void Update () {
        transform.position += speed * Time.deltaTime;
	}
}
