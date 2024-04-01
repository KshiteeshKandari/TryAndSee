using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// changed scene here
public class ChangeScenes : MonoBehaviour
{
    private bool isChefScene = true; 
    public void SceneChange()
    {

         if (isChefScene)
        {
            SceneManager.LoadScene("HunterScene");
            isChefScene = false;
            // Debug.Log("isChefBool = ", isChefScene);

        }
        else if(isChefScene == false)
        {
            SceneManager.LoadScene("KitchenScene");
            isChefScene = true;
        }
    }
}