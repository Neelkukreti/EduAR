using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{

    public GameObject Direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DirectionActive()
    {
        Direction.SetActive(true);
    }

    public void DirectionDeActive()
    {
        Direction.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
