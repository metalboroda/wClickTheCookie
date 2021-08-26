using System;
using Managers;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ScoreDisplayScript : MonoBehaviour
    {
        // Singleton
        public static ScoreDisplayScript Instance { get; private set; }

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

            //
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