using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Displayname : MonoBehaviour
{
    public GameObject sunname,mname,vnam,marnam,junam,satnam,urnam,nepnam,ssnam,emodel,det,moon,sphere,back;
    string btname;
    // Start is called before the first frame update
    void Start()
    {
        sunname.SetActive(false);
        mname.SetActive(false);
        vnam.SetActive(false);
        marnam.SetActive(false);
        junam.SetActive(false);
        satnam.SetActive(false);
        urnam.SetActive(false);
        nepnam.SetActive(false);
        emodel.SetActive(false);
        moon.SetActive(false);
        det.SetActive(false);
        sphere.SetActive(false);
        back.SetActive(false);
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
                    case "Sun":
                        sunname.SetActive(true);
                        break;
                    case "Merc":
                        mname.SetActive(true);
                        break;
                    case "Venus":
                        vnam.SetActive(true);
                        break;
                    case "Earth":
                        ssnam.SetActive(false);
                        emodel.SetActive(true);
                        det.SetActive(true);
                        sphere.SetActive(true);
                        back.SetActive(true);
                        break;
                    case "Mars":
                        marnam.SetActive(true);
                        break;
                    case "Jupiter":
                        junam.SetActive(true);
                        break;
                    case "Saturn":
                        satnam.SetActive(true);
                        break;
                    case "Uranus":
                        urnam.SetActive(true);
                        break;
                    case "Neptune":
                        nepnam.SetActive(true);
                        break;
                    case "Sphere":
                        moon.SetActive(true);
                        break;
                    case "Cube":
                        ssnam.SetActive(true);
                        emodel.SetActive(false);
                        det.SetActive(false);
                        sphere.SetActive(false);
                        back.SetActive(false);
                        moon.SetActive(false);
                        break;

                }
            }
        }
    }
}
