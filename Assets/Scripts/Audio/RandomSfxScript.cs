using UnityEngine;
using Random = UnityEngine.Random;

namespace Audio
{
    public class RandomSfxScript : MonoBehaviour
    {
        public AudioSource audioSource;

        // Vars
        public AudioClip[] audioCLipArray;

        private void Awake()
        {
            audioSource = GetComponent<AudioSource>();
        }

        public void PlayRandomSound()
        {
            audioSource.clip = audioCLipArray[Random.Range(0, audioCLipArray.Length)];
            audioSource.pitch = Random.Range(0.85f, 1.15f);
            audioSource.PlayOneShot(audioSource.clip);
            // Debug.Log("Sound");
        }
    }
}