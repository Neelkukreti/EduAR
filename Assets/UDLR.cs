using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UDLR : MonoBehaviour
{
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MoveLeft()
    {
        obj.transform.Translate(1.0f, 0f, 0f);
    }

    public void MoveUP()
    {
        obj.transform.Translate(0f, 1.0f, 0f);
    }

    public void MoveRight()
    {
        obj.transform.Translate(-1.0f, 0f, 0f);
    }

    public void MoveDown()
    {
        obj.transform.Translate(0f, -1.0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
