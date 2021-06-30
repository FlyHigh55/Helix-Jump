using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class EndPanel : MonoBehaviour
{
    public Button play, mainm;
    public GameObject abc;
    void Start()
    {
        // SceneManager.UnloadSceneAsync("ActualGame");

        play.onClick.AddListener(t1);
        mainm.onClick.AddListener(t2);
    }
    public void t1()
    {
       // abc.SetActive(false);
        SceneManager.LoadScene("Main");
        // SceneManager.LoadScene("ActualGame", LoadSceneMode.Additive);

    }
    public void t2()
    {
        //abc.SetActive(false);
        SceneManager.LoadScene("Start");
        // SceneManager.LoadScene("ActualGame", LoadSceneMode.Additive);

    }
}
