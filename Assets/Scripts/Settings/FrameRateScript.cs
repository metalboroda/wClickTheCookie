using UnityEngine;

namespace Settings
{
    public class FrameRateScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Application.targetFrameRate = 300;
        }
    }
}
