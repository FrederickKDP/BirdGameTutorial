using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GivePoints : MonoBehaviour {
    Transform player;
    bool gaveScore = false;

	void Awake () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	void Update () {
        if (player.position.x>transform.position.x &&
            !gaveScore)
        {
            FindObjectOfType<UpdateScore>().AddScore();
            gaveScore = true;
        }
	}
}
