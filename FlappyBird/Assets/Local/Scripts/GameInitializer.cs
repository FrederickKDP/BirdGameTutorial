using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitializer : MonoBehaviour {
    public Vector3 speedParalax = Vector3.zero;

	void Awake () {
        GlobalConstMotion.speed = speedParalax;
	}
}
