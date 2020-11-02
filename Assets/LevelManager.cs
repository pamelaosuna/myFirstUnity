using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string sceneToLoad;
    void OnCollisionEnter(Collision collisionInfo) // can be Collider HardDick if you want.. I'm not judging you
    {
        if(collisionInfo.collider.tag == "text"){
            print("Change of level");
            SceneManager.LoadScene(sceneToLoad);
            //Application.LoadLevelAdditive(1); //1 is the build order it could be 1065 for you if you have that many scenes
        }
    }
}
