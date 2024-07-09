using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carcamera : MonoBehaviour
{
    public GameObject Helicopter;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Helicopter.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = offset + Helicopter.transform.position;
        
    }
}
