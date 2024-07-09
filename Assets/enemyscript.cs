using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    public GameObject heli;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.8f);
        transform.LookAt(heli.transform);
    }
}