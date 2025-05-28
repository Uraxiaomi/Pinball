using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public bool perdeu = false;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Bola")
        {
            Destroy(coll.gameObject);
            Debug.Log("Você perdeu. Aperte R para reiniciar");
            perdeu = true;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(perdeu && Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
