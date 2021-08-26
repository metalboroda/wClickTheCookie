using UI;
using UnityEngine;

namespace Managers
{
    public class ScoreManagerScript : MonoBehaviour
    {
        // Singleton
        public static ScoreManagerScript Instance { get; private set; }

        // Vars
        public int cookieScore;

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

        public void AddCookieScore()
        {
            cookieScore += 1;
            // ScoreDisplayScript.Instance.DisplayScore();
        }
    }
}