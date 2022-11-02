using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonHandlerScript : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void startGame(){
        StartCoroutine(startButton());
        Debug.Log("Starting Game...");
    }

    public void exitGame(){
        StartCoroutine(exitButton());
        Debug.Log("Quitting Game...");
    }

    IEnumerator startButton(){
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }

    IEnumerator exitButton(){
        yield return new WaitForSeconds(1);
        Application.Quit();
    }
}
