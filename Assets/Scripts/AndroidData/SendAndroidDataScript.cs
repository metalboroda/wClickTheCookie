using UnityEngine;

namespace AndroidData
{
    public class SendAndroidDataScript : MonoBehaviour
    {
            private static ILogger logger = Debug.unityLogger;
            private static string kTAG = "MyDebug";

        public void LaunchAppMessage()
        {
            string bundleId = "com.example.trysendandreturndatafromunityactivity";
            bool fail = false;
            string message = "Йо мафака!";
            AndroidJavaClass up = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject ca = up.GetStatic<AndroidJavaObject>("currentActivity");
            AndroidJavaObject packageManager = ca.Call<AndroidJavaObject>("getPackageManager");
            AndroidJavaObject launchIntent = null;

            try
            {
                launchIntent = packageManager.Call<AndroidJavaObject>("getLaunchIntentForPackage", bundleId);
                launchIntent.Call<AndroidJavaObject>("putExtra", "my_text", message);
                ca.Call<AndroidJavaObject>("setResult",-1,launchIntent);
            }
            catch (System.Exception e)
            {
                logger.Log(kTAG, "ERROR ::: " + e);
                fail = true;
            }

            if (fail)
            {
                logger.Log(kTAG, "ERROR fail ::: fail");
                Application.OpenURL("http://www.kremlin.ru/");
            }
            else
            {
                try
                {
                    logger.Log(kTAG, "startActivity launchIntent ::: launchIntent");
//                    ca.Call("startActivity", launchIntent);
                }
                catch (System.Exception e)
                {
                    logger.Log(kTAG, "ERROR ::: " + e);
                }
            }
            up.Dispose();
            ca.Dispose();
            packageManager.Dispose();
            launchIntent.Dispose();
        }
    }
}
