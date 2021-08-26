using System;
using UnityEngine;

namespace AndroidData
{
    public class ReceiveAndroidDataScript : MonoBehaviour
    {
        
        private static ILogger logger = Debug.unityLogger;
        private static string kTAG = "MyDebug";
        private void Awake()
        {
            logger.Log(kTAG, "asdfassssssfgasfasdasdsd ::: ");
            Debug.Log("falskdfalksjdalsjd");
            getIntentData();
        }

        private bool getIntentData()
        {
            
#if (!UNITY_EDITOR && UNITY_ANDROID)
    logger.Log(kTAG, "No UNITY_EDITOR AND UNITY_ANDROID");
    return CreatePushClass (new AndroidJavaClass ("com.unity3d.player.UnityPlayer"));
#endif
            return false;
        }

        public bool CreatePushClass(AndroidJavaClass UnityPlayer)
        {
#if UNITY_ANDROID
            AndroidJavaObject currentActivity = UnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            AndroidJavaObject intent = currentActivity.Call<AndroidJavaObject>("getIntent");
            AndroidJavaObject extras = GetExtras(intent);

            Debug.Log("INTENT ::: " + intent);
            logger.Log(kTAG, "intent ::: " + intent);
            if (extras != null)
            {
                string ex = GetProperty(extras, "my_text");
                Debug.Log("Success ::: " + ex);
                logger.Log(kTAG, "Success ::: " + ex);
                logger.Log(kTAG, "Success ::: " + ex.Length);
                return true;
            }
            else
            {
                Debug.Log("NONE (((( ");
                logger.Log(kTAG, "NONE (((( ");
            }
#endif
            logger.Log(kTAG, "ERROR ::: NO ANDROID");
            return false;
        }

        private AndroidJavaObject GetExtras(AndroidJavaObject intent)
        {
            AndroidJavaObject extras = null;

            try
            {
                extras = intent.Call<AndroidJavaObject>("getExtras");
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
                logger.Log(kTAG, "Error ::: " + e);
            }

            return extras;
        }

        private string GetProperty(AndroidJavaObject extras, string name)
        {
            string s = string.Empty;

            try
            {
                s = extras.Call<string>("getString", name);
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
                logger.Log(kTAG, "Error ::: " + e);
            }

            return s;
        }
    }
}