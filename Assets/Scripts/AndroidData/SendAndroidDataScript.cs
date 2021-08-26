using UnityEngine;

namespace AndroidData
{
    public class SendAndroidDataScript : MonoBehaviour
    {
        public void LaunchAppMessage()
        {
            string bundleId = "com.example.sidenavtest";
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
            }
            catch (System.Exception e)
            {
                fail = true;
            }

            if (fail)
            {
                Application.OpenURL("http://www.kremlin.ru/");
            }
            else
            {
                ca.Call("startActivity", launchIntent);
            }
            up.Dispose();
            ca.Dispose();
            packageManager.Dispose();
            launchIntent.Dispose();
        }
    }
}
