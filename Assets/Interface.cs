using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interface : MonoBehaviour{

    public Slider HealthBar;
    public GameObject quitQuestion;
    private bool isActive = false;
    // Start is called before the first frame update
    void Start()
    {
      DontDestroyOnLoad(gameObject);
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape) && !isActive){
            isActive = true;
            quitQuestion.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isActive){
            isActive = false;
            quitQuestion.SetActive(false);
        }

    }

    public void Exit(){
        Application.Quit();
        Debug.Log("We exit the game...");
    }

    public void BackToGame(){
        isActive = false;
        quitQuestion.SetActive(false);
    }


}
