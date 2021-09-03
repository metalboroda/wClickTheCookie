using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace Animations.UI
{
    public class SFXButtonScript : MonoBehaviour
    {
        public AudioMixer soundsChannel;
        public Image soundImage;
        public Sprite soundOn;
        public Sprite soundOff;

        private bool soundIsOn;

        private void Start()
        {
            SoundChannelChecker();
        }

        public void ToggleSoundChannel()
        {
            if (soundIsOn == false)
            {
                soundIsOn = true;
                PlayerPrefs.SetInt("SFX", 1);
                soundsChannel.SetFloat("SFXChannel", 0.0f);
                soundImage.sprite = soundOn;
                soundImage.color = new Color32(255, 152, 0, 255);
            }
            else
            {
                soundIsOn = false;
                PlayerPrefs.SetInt("SFX", 0);
                soundsChannel.SetFloat("SFXChannel", -80.0f);
                soundImage.sprite = soundOff;
                soundImage.color = new Color32(200, 0, 0, 255);
            }
        }

        private void SoundChannelChecker()
        {
            if (PlayerPrefs.GetInt("SFX") == 1)
            {
                soundIsOn = true;
                soundsChannel.SetFloat("SFXChannel", 0.0f);
                soundImage.sprite = soundOn;
                soundImage.color = new Color32(255, 152, 0, 255);
            }
            else
            {
                soundIsOn = false;
                soundsChannel.SetFloat("SFXChannel", -80.0f);
                soundImage.sprite = soundOff;
                soundImage.color = new Color32(200, 0, 0, 255);
            }
        }
    }
}