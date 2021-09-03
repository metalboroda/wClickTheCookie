using UnityEngine;

namespace UI
{
    public class BackgroundMovementScript : MonoBehaviour
    {
        public float speed;
        private Renderer _renderer;
        
        private void Start()
        {
            _renderer = GetComponent<Renderer>();
        }

        private void Update()
        {
            var offset = new Vector2(Time.time * speed, 0);

            _renderer.material.mainTextureOffset = offset;
        }
    }
}