using UnityEngine;

namespace Particles
{
    public class CookieParticlesScript : MonoBehaviour
    {
        public ParticleSystem particles;

        public void StartParticles()
        {
            var ps = Instantiate(particles, Vector3.zero, Quaternion.identity);
            ps.Play();
            Destroy(ps.gameObject, 1.2f);
        }
    }
}