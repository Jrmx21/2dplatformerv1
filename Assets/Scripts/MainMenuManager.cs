using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

  
    public static void ResumeGame()
    {
        Debug.Log("Reanudando juego");
        SceneManager.LoadScene("PlayScene");
    }
}
