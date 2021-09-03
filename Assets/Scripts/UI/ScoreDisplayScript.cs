using Managers;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ScoreDisplayScript : MonoBehaviour
    {
        // Singleton
        private static ScoreDisplayScript Instance { get; set; }

        // Objects
        public Text scoreCountText;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void Update()
        {
            DisplayScore();
        }

        private void DisplayScore()
        {
            scoreCountText.text = ScoreManagerScript.Instance.cookieScore.ToString();
        }
    }
}