using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _backgroundColor : MonoBehaviour
{
    Camera cm;
    void Start()
    {
        cm = gameObject.GetComponent<Camera>();
        Color[] color ={
            Color.blue,//
            Color.cyan,//
            Color.gray,//
            Color.green,//
            Color.magenta,//
            Color.white,//
            Color.yellow,//
            Color.black,
        };
        int randomVal = Random.Range(0, 7);
        Debug.Log(randomVal.ToString());
        cm.backgroundColor = color[randomVal];
    }
}
