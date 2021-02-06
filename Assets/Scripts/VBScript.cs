using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;

public class VBScript : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject Twingo, Bhemmgo;
    // Start is called before the first frame update
    void Start()
    {
        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vrb.Length; i++)
        {
            vrb[i].RegisterEventHandler(this);
        }
        Twingo.SetActive(false);

        Bhemmgo.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {

    }

    int count = 0;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        if (vb.VirtualButtonName == "Forward")
        {
            int var = count % 2;

            if (var == 0)
            {
                Twingo.SetActive(true);

                Bhemmgo.SetActive(false);
            }

            if (var == 1)
            {
                Twingo.SetActive(false);

                Bhemmgo.SetActive(true);

            }

            
            count++;

        }


    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }
}