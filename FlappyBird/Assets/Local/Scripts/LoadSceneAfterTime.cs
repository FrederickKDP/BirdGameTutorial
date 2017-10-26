using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadSceneAfterTime : MonoBehaviour {
    public int scene = 0;
    public float delay = 5f;

    void Awake () {
        Invoke("LoadLevel", delay);
	}


	void LoadLevel () {
        SceneManager.LoadScene(scene);
	}
}
