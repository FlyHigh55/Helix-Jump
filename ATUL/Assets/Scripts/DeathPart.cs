using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPart : MonoBehaviour {

    private void OnEnable()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    public void HittedDeathPart( )
    {
        //GameManager.singleton.RestartLevel();
        SceneManager.LoadScene("END");
    }
}
