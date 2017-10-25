using UnityEngine.SceneManagement;
using UnityEngine;

public class DamageTouch : MonoBehaviour {
    public string tag = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == tag)
        {
            SceneManager.LoadScene("GameOver");
            //Debug.Log("Game Over!");
            //Debug.Break();
        }
    }
}
