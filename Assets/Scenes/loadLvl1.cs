using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLvl1 : MonoBehaviour
{   
    public void NextScene()
    {
        SceneManager.LoadScene("LVL 1");
    }
}