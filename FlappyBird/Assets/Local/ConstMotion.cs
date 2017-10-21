using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstMotion : MonoBehaviour {
    public Vector3 direction;

	void Update () {
        transform.position += direction * Time.deltaTime;
	}
}
