using Animations.GameObjects;
using Audio;
using Managers;
using Particles;
using UnityEngine;
using UnityEngine.Serialization;

namespace GameObjects
{
    public class CookieClickScript : MonoBehaviour
    {
        // Call classes
        [FormerlySerializedAs("_randomSfxScript")]
        public RandomSfxScript randomSfxScript;

        [FormerlySerializedAs("_cookieParticlesScript")]
        public CookieParticlesScript cookieParticlesScript;

        private void OnCollisionEnter2D()
        {
            OnMouseDown();
        }

        private void OnMouseDown()
        {
            if (!Input.GetMouseButtonDown(0)) return;
            if (Camera.main is null) return;
            var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var mousePos2D = new Vector2(mousePos.x, mousePos.y);

            var hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider == null) return;
            // Debug.Log("Click");
            // Call methods
            CookieAnimationsScript.Instance.CookieShake();
            randomSfxScript.PlayRandomSound();
            ScoreManagerScript.Instance.AddCookieScore();
            cookieParticlesScript.StartParticles();
        }
    }
}