using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickChangeScene : MonoBehaviour {

    public string SceneTargetName;

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene(SceneTargetName);
        }
	}
}
