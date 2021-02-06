using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public GameObject Apple, key, waterm, umbr;
    public AudioClip[] aClips;
    public AudioSource myAudioSource;
    string btname;
    private int ran;
    Random rnd = new Random();
    // Use this for initialization
    void Start()
    {

        Apple.SetActive(false);
        key.SetActive(false);
        waterm.SetActive(false);
        umbr.SetActive(false);
        myAudioSource = GetComponent<AudioSource>();

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
                    case "A":
                        Apple.SetActive(true);
                        myAudioSource.clip = aClips[0];
                        myAudioSource.Play();
                        _ShowAndroidToastMessage("A clicked");
                        break;
                    case "K":
                        key.SetActive(true);
                        myAudioSource.clip = aClips[1];
                        myAudioSource.Play();
                        break;
                    case "W":
                        waterm.SetActive(true);
                        myAudioSource.clip = aClips[2];
                        myAudioSource.Play();
                        break;
                    case "U":
                        umbr.SetActive(true);
                        myAudioSource.clip = aClips[3];
                        myAudioSource.Play();
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

