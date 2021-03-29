using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personatge : MonoBehaviour
{
    public Boolean jumping;
    private Animator anim;
    private Boolean lookingLeft;
    

    // Start is called before the first frame update
    void Start()
    {
        jumping=false;
        anim = gameObject.GetComponent<Animator>();
        lookingLeft=true;
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            //Movem a l'esquerra
            transform.Translate(new Vector2(-0.02f, 0.0f));
            anim.SetBool ("isRunning", true);
            
            // Si no està mirant a l'esquerra, li afegim la transició
            if (!lookingLeft) 
                {
                    transform.localScale *= new Vector2(-1,1);
                    lookingLeft=true;
                }
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            //Movem a la dreta
            transform.Translate(new Vector2(0.02f, 0.0f));
            anim.SetBool ("isRunning", true);
            
            if (lookingLeft) 
                {
                    transform.localScale *= new Vector2(-1,1);
                    lookingLeft=false;
                }

        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)){
            //Botem
              if (GetComponent<Rigidbody2D>()!=null && !jumping){
                jumping=true;
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, 300.0f));
            }
        }

        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.LeftArrow)&&
            !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.RightArrow)) 
            anim.SetBool ("isRunning", false);

    }

    void OnCollisionEnter2D(Collision2D _col){
        //Entra si dos objectes col·lisionen per primera vegada
        if(_col.gameObject.tag == "Plataformes" && _col.contacts[0].normal.y>=0)
            jumping = false;
    }
}
