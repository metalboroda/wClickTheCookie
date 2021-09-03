using DG.Tweening;
using UnityEngine;

namespace Animations.UI
{
    public class ScoreCountTextAnimationsScript : MonoBehaviour
    {
        // Singleton
        public static ScoreCountTextAnimationsScript Instance { get; private set; }

        // Shake animation vars
        [Header("Shake Animation Vars")] public float duration;
        public float strength;
        public int vibrato;
        public float randomness;
        public bool snapping;
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
        }

        public void ScoreCountTextShake()
        {
            transform.DORewind();
            transform.DOShakePosition(duration, strength, vibrato, randomness, snapping, fadeOut);
        }
    }
}