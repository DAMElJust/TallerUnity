using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class Enemic : MonoBehaviour
{
    protected float direccio;
    // Start is called before the first frame update

    void Start()
    {
        // Establim la direcció de l'enemic (dreta o esquerra)
        // de forma aleatòria i un temporitzador per a que canvie
        if (Random.Range(0.0f, 1.0f)<0.5f) direccio=0.02f;
        else direccio=-0.02f;

        InvokeRepeating("ChangeDirection", 2.0f, 3.0f);

        //InvokeRepeating("RestartGame", 5.0f, 5.0f);

    }
    void RestartGame(){
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void ChangeDirection(){
        direccio*=-1.0f;
    }

    // Update is called once per frame
    void Update()
    {       
     transform.Translate(new Vector2(direccio, 0.0f));   
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player") RestartGame();
    }


}