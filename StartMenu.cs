using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject homeMenu;
    public GameObject levelMenu;
 

    private void Start()
    {
        homeMenu.SetActive(true);
        levelMenu.SetActive(false);
    }
    

    public void GoToLevelMenu()
    {
       
        homeMenu.SetActive(false);
        levelMenu.SetActive(true);
    }

    public void GoToStartMenu()
    {
        Debug.Log("Clicked");
        levelMenu.SetActive(false);
        homeMenu.SetActive(true);
    }

    /*public void level1()
    {
        anim.SetTrigger("FadeOut");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }*/

    
}
