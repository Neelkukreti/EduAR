using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GazeVR : MonoBehaviour
{
    public Image imgGaze;
    public GameObject sulfur,carb,bro;

    public float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;

    public int distanceofRay = 40;
    private RaycastHit _hit;

    // Start is called before the first frame update
    void Start()
    {
        sulfur.SetActive(false);
        carb.SetActive(false);
        bro.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;
        }

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Physics.Raycast(ray, out _hit, distanceofRay))
        {
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Teleport"))
            {
                Debug.Log("Teleport");
                sulfur.SetActive(true);

            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Teleport2"))
            {
                Debug.Log("Teleport");
                carb.SetActive(true);

            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Teleport3"))
            {
                Debug.Log("Teleport");
                bro.SetActive(true);

            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("MoveF"))
            {
                Debug.Log("MoveF");
                _hit.transform.gameObject.GetComponent<MovePlayer>().MoveForward();

            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Moving"))
            {
                Debug.Log("Moving");
                _hit.transform.gameObject.GetComponent<Moving>().DirectionActive();

            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("MoveLeft"))
            {
                Debug.Log("MovingLeft");
                _hit.transform.gameObject.GetComponent<UDLR>().MoveLeft();

            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Close"))
            {
                Debug.Log("Closed");
                _hit.transform.gameObject.GetComponent<Moving>().DirectionDeActive();

            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("MoveUp"))
            {
                Debug.Log("MovingUp");
                _hit.transform.gameObject.GetComponent<UDLR>().MoveUP();

            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("MoveRight"))
            {
                Debug.Log("MovingRight");
                _hit.transform.gameObject.GetComponent<UDLR>().MoveRight();

            }
        }
    }

    public void GVROn()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
    }
}
