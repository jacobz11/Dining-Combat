using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComSceneManager : MonoBehaviour
{
    public void Start()
    {
        SceneManager.LoadScene("OtherSceneName", LoadSceneMode.Additive);
    }

    public void Update()
    {
        
    }
}
