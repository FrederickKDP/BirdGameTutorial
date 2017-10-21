using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfRangeXSelfDestroy : MonoBehaviour {
    public float xLimitNeg = -4f;

	void Update () {
        if (transform.position.x < xLimitNeg)
        {
            Destroy(gameObject);
        }
	}
}
