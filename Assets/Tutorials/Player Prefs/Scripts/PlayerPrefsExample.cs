using TMPro;
using UnityEngine;

namespace DapperDino.Tutorials.Spawning
{
    public class PlayerPrefsExample : MonoBehaviour
    {
        [SerializeField] private TMP_Text highScoreText = null;
        [SerializeField] private int score = 0;

        private const string HighScoreKey = "HighScoreKey";

        private void Start()
        {
            int highScore = PlayerPrefs.GetInt(HighScoreKey, 0);

            highScoreText.text = $"High Score: {highScore}";
        }

        [ContextMenu("Reset High Score")]
        private void ResetHighScore()
        {
            PlayerPrefs.DeleteKey(HighScoreKey);

            highScoreText.text = $"High Score: 0";
        }

        [ContextMenu("Submit Score")]
        private void SubmitScore()
        {
            int highScore = PlayerPrefs.GetInt(HighScoreKey, 0);

            if (score > highScore)
            {
                PlayerPrefs.SetInt(HighScoreKey, score);
            }

            highScoreText.text = $"High Score: {score}";
        }
    }
}
