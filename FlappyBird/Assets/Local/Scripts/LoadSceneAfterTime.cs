using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadSceneAfterTime : MonoBehaviour {
    public float delay = 5f;

    void Awake () {
        Invoke("LoadLevel", delay);
	}


	void LoadLevel () {
        SceneManager.LoadScene(0);
	}
}
