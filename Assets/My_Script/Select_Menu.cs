using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Select_Menu : MonoBehaviour
{
    
    void Start()
    {
        
    }

    public void Select_Scene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Close_Pan()
    {

    }
    
}
