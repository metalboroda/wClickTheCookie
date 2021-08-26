using System;
using UnityEngine;

namespace Managers
{
    public class SceneManagerScript : MonoBehaviour
    {
        // Singleton
        public static SceneManagerScript Instance { get; private set; }

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
    }
}
