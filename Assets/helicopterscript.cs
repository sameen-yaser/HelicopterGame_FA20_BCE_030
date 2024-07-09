using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class helicopterscript : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, 1);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -1);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 1, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -1, 0);
        }

        if (Input.GetKey(KeyCode.U)) //upwards
        {
            transform.Translate(0, 1, 0);
        }

        if (Input.GetKey(KeyCode.D)) //downwards
        {
            transform.Translate(0, -1, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }

    private void OnCollisionEnter(Collision col)
    {
      if(col.gameObject.name.StartsWith("enemy"))
        {
            SceneManager.LoadScene("game_over");

        }
    }
}