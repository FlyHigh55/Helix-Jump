using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
   public GameObject ScoreBoardPanel;
    private int best;
    [SerializeField] private Text txtBest;

    void Update()
    {
        txtBest.text = "Best: " + GameManager.singleton.best;
    }
        public void S()
   {
       ScoreBoardPanel.SetActive(true);
        Time.timeScale = 0;
   }
   public void Back()
   {
       SceneManager.LoadScene("Start");
   }
}
