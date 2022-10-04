using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject homeMenu;
    public GameObject levelMenu;
    public GameObject optionsMenu;
    public GameObject menuPanel;
    public GameObject aboutPanel;

    private void Start()
    {
        homeMenu.SetActive(true);
        levelMenu.SetActive(false);
        optionsMenu.SetActive(false);
    }
    

    public void GoToLevelMenu()
    {
       
        homeMenu.SetActive(false);
        levelMenu.SetActive(true);
        //optionsMenu.SetActive(false);
    }

    public void GoToStartMenu()
    {
        levelMenu.SetActive(false);
        homeMenu.SetActive(true);
        //optionsMenu.SetActive(false);
    }

    public void GoToOptionsMenu()
    {
        //homeMenu.SetActive(true);
        //levelMenu.SetActive(false);
        menuPanel.SetActive(false);
        aboutPanel.SetActive(false);
        optionsMenu.SetActive(true);

    }

    public void GoBackToMenuPanel()
    {
        menuPanel.SetActive(true);
        optionsMenu.SetActive(false);
    }

    public void GoToAboutMenu()
    {
        menuPanel.SetActive(false);
        optionsMenu.SetActive(false);
        aboutPanel.SetActive(true);
    }
    
}
