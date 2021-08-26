using System;
using Animations;
using Managers;
using Particles;
using UnityEngine;

namespace GameObjects
{
    public class CookieClickScript : MonoBehaviour
    {
        // Singleton
        public static CookieClickScript Instance { get; private set; }

        // Vars
        bool touchedLastFrame;

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
            OnCookieClick();
        }

        private void OnCookieClick()
        {
            if (touchedLastFrame && Input.touchCount == 0)
            {
                touchedLastFrame = false;
            }
            else if (!touchedLastFrame && Input.touchCount > 0)
            {
                touchedLastFrame = true;
            
                // Methods
                ScoreManagerScript.Instance.AddCookieScore();
                CookieAnimationsScript.Instance.CookieShake();
            }
        }
    }
}