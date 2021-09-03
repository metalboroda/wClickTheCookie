using DG.Tweening;
using UnityEngine;

namespace Animations.UI
{
    public class ResetButtonAnimationScript : MonoBehaviour
    {
        // Shake animation vars
        [Header("Shake Animation Vars")] public float duration;
        public float strength;
        public int vibrato;
        public float randomness;
        public bool snapping;
        public bool fadeOut;

        public void ResetButtonShake()
        {
            transform.DORewind();
            transform.DOShakePosition(duration, strength, vibrato, randomness, snapping, fadeOut);
        }
    }
}