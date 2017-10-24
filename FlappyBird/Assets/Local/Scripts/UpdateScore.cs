using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour {
    public int score = 0;
    public Text text;

    public void AddScore()
    {
        score++;
        UpdateText();
    }

    void UpdateText () {
        text.text = "" + score;
	}
}
