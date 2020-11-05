using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinCase : MonoBehaviour{

    public GameObject congratsQuestion;
    //public bool isActive = false;

    // Start is called before the first frame update
    void Start()
    {
      DontDestroyOnLoad(gameObject);
    }

    public void Exit(){
        Application.Quit();
        //Debug.Log("We exit the game...");
    }

    public void PlayAgain(string sceneName){
        SceneManager.LoadScene(sceneName);
        //GameObject.SetActive(false)
        congratsQuestion.SetActive(false);
    }


}
