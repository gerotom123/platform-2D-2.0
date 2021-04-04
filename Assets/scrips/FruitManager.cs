using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{
    public Text LevelCleared;

    public GameObject transition;
    private void Update()
    {
        AllFruitCollected();
    }

    public void AllFruitCollected() 
    {
        if (transform.childCount==0)
        {
            Debug.Log("oaaa no quedan frutitas");
            LevelCleared.gameObject.SetActive(true);
            transition.SetActive(true);
            Invoke("ChangeScene", 1);
        }

    }
    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}


    