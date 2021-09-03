using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace Animations.UI
{
    public class MusicButtonScript : MonoBehaviour
    {
        // Start is called before the first frame update
        public AudioMixer musicChannel;
        public Image musicImage;
        public Sprite musicOn;
        public Sprite musicOff;

        private bool musicIsOn;

        private void Start()
        {
            MusicChannelChecker();
        }

        public void ToggleMusicChannel()
        {
            if (musicIsOn == false)
            {
                musicIsOn = true;
                PlayerPrefs.SetInt("Music", 1);
                musicChannel.SetFloat("MusicChannel", -6.0f);
                musicImage.sprite = musicOn;
                musicImage.color = new Color32(255, 152, 0, 255);
            }
            else
            {
                musicIsOn = false;
                PlayerPrefs.SetInt("Music", 0);
                musicChannel.SetFloat("MusicChannel", -80.0f);
                musicImage.sprite = musicOff;
                musicImage.color = new Color32(200, 0, 0, 255);
            }
        }

        private void MusicChannelChecker()
        {
            if (PlayerPrefs.GetInt("Music") == 1)
            {
                musicIsOn = true;
                musicChannel.SetFloat("MusicChannel", -6.0f);
                musicImage.sprite = musicOn;
                musicImage.color = new Color32(255, 152, 0, 255);
            }
            else
            {
                musicIsOn = false;
                musicChannel.SetFloat("MusicChannel", -80.0f);
                musicImage.sprite = musicOff;
                musicImage.color = new Color32(200, 0, 0, 255);
            }
        }
    }
}
