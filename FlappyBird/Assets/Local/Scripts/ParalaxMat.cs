using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxMat : MonoBehaviour {
    Material mat;
    float speed = 1;

	void Awake () {
        mat = GetComponent<MeshRenderer>().material;
	}

	void Update () {
        Vector2 newOffset = mat.GetTextureOffset("_MainTex");
        newOffset.x += (1 / transform.position.z)*Time.deltaTime;
        if (newOffset.x > 1)
        {
            newOffset.x = 1 - newOffset.x;
        }
        mat.SetTextureOffset("_MainTex", newOffset);
	}
}
