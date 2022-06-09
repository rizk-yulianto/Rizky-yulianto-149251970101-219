using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenAuthor()
    {
        Debug.Log("Created By Gue");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Created by Rizky - 149251970101-219");
    }
}
