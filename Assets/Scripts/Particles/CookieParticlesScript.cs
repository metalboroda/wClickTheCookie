using UnityEngine;

namespace Particles
{
    public class CookieParticlesScript : MonoBehaviour
    {
        // Singleton
        public static CookieParticlesScript Instance { get; private set; }

        // Objects
        public GameObject cookieParticles;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                // Destroy(gameObject);
            }

            //
        }

        public void SpawnCookieParticles()
        {
            Instantiate(cookieParticles, transform.position, Quaternion.identity);

            Destroy(cookieParticles, 2f);
        }
    }
}