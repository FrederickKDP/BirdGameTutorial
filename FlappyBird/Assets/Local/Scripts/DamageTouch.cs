using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTouch : MonoBehaviour {
    public string tag = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == tag)
        {
            Debug.Log("Game Over!");
            Debug.Break();
        }
    }
}
