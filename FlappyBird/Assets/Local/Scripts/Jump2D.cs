using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump2D : MonoBehaviour {
    public Rigidbody2D rb2d;
    public float force = 3f;
    public AudioSource aS;

	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            ///Resets force
            aS.Play();
            rb2d.velocity = Vector3.zero;
            rb2d.AddForce(Vector2.up*force, ForceMode2D.Impulse);
        }
	}
}
