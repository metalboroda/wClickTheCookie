using DG.Tweening;
using UnityEngine;

namespace Animations
{
    public class CookieAnimationsScript : MonoBehaviour
    {
        // Singleton
        public static CookieAnimationsScript Instance { get; private set; }

        // Shake animation vars
        [Header("Shake Animation Vars")] public float duration;
        public float strength;
        public int vibrato;
        public float randomness;
        public bool fadeOut;

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

        public void CookieShake()
        {
            transform.DOShakeScale(duration, strength, vibrato, randomness, fadeOut);
        }
    }
}