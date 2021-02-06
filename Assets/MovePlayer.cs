using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public GameObject player;
    public GameObject MoveF;

    public void MoveForward()
    {
        player.transform.Translate(0f, 0f, (15.0f * Time.deltaTime));
        MoveF.transform.Translate(0f, 0f, (15.0f * Time.deltaTime));
    }
}
