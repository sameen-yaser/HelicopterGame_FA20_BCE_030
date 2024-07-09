using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyLauncherScript : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i <= 9; i++)
        {
            Vector3 enemypos = new Vector3(Random.Range(100,1000), Random.Range(20, 70), Random.Range(700,1000));
            Instantiate(enemy, enemypos, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}