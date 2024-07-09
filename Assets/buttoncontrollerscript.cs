using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttoncontrollerscript : MonoBehaviour
{
    public void reloadMainScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
