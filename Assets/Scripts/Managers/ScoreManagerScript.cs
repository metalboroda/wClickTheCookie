using UnityEngine;

namespace Managers
{
    public class ScoreManagerScript : MonoBehaviour
    {
        // SendAndroidDataScript _sendAndroidDataScript = new SendAndroidDataScript();

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
        }

        private void Start()
        {
            cookieScore = PlayerPrefs.GetInt("Score");
        }

        public void AddCookieScore()
        {
            cookieScore += 1;

            // OnSomeScoreQuitGame();
        }

        /*private void OnSomeScoreQuitGame()
        {
            if (cookieScore >= 10)
            {
                Debug.Log("Quit!");
                Application.Quit();
                _sendAndroidDataScript.LaunchAppMessage();
            }
        }*/

        public void ResetCookieScore()
        {
            cookieScore = 0;
        }

        private void OnDestroy()
        {
            PlayerPrefs.SetInt("Score", cookieScore);
        }
    }
}