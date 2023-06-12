using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text textScore;

    [SerializeField] private TMP_Text finalScore;

    [SerializeField] private int score;

    private int finalScoreNum;

    private void Update()
    {
        textScore.text = "" + score;
        score++;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            finalScoreNum = score;
            finalScore.text = "" + finalScoreNum;
        }
    }
}
