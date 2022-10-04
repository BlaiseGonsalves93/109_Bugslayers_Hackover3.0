using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Threading.Tasks;

public class levelManager : MonoBehaviour
{
    // Start is called before the first frame update

    private static levelManager Instance;
    [SerializeField] private GameObject loadingScreen;

   public Animator anim;
   // private int levelToLoad;

   public float transitionTime = 4f;
    
   void Awake()
   {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
   }
    

   /*public async void LevelLoader(string sceneName)
   {
        var scene = SceneManager.LoadSceneAsync(sceneName);
        scene.allowSceneActivation = false;

        loadingScreen.SetActive(true);

        await Task.Delay(4500);
        scene.allowSceneActivation = true;
        loadingScreen.SetActive(false);
   } */

   public void LoadNextLevel()
   {
       StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
   }

   IEnumerator LoadLevel(int levelIndex)
   {
       anim.Settrigger("FadeOut");

       yield return new WaitForSeconds(transitionTime);

       SceneManager.LoadScene(levelIndex);
   }

    
}
