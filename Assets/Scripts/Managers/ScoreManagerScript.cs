using AndroidData;
using Animations.UI;
using UI;
using UnityEngine;

namespace Managers
{
    public class ScoreManagerScript : MonoBehaviour
    {
        SendAndroidDataScript _sendAndroidDataScript = new SendAndroidDataScript();
        
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

            OnSomeScoreQuitGame();
        }

        public void OnSomeScoreQuitGame()
        {
            if (cookieScore >= 10)
            {
                Debug.Log("Quit!");
                _sendAndroidDataScript.LaunchAppMessage();
                // Application.Quit();
            }
        }
    }
}