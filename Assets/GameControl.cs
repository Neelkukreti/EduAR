using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    //public AnimationClip trajectory;
    //Animation anim;
    public GameObject btl;
    public GameObject mainbtl;
    string btname;

    // Start is called before the first frame update
    void Start()
    {
        btl.SetActive(false);
        /* anim = gameObject.GetComponent<Animation>();
         anim.clip = trajectory;
         anim.Stop();*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit))

            {
                btname = Hit.transform.name;
                switch (btname)
                {
                    case "Mainbtl":
                        _ShowAndroidToastMessage("Btl clicked");
                        //anim.clip = trajectory;
                        //anim.Play();
                        btl.SetActive(true);
                        mainbtl.SetActive(false);
                        break;
                    
                }
            }
        }
    }

    private void _ShowAndroidToastMessage(string message)
    {
        AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject unityActivity =
            unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");

        if (unityActivity != null)
        {
            AndroidJavaClass toastClass = new AndroidJavaClass("android.widget.Toast");
            unityActivity.Call("runOnUiThread", new AndroidJavaRunnable(() =>
            {
                AndroidJavaObject toastObject =
                    toastClass.CallStatic<AndroidJavaObject>(
                        "makeText", unityActivity, message, 0);
                toastObject.Call("show");
            }));
        }
    }
}
