using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
 
    



    void Start()
    {


    }



    void Update()
    {
        

   
    }


    void OnTriggerEnter(Collider collider)
    {
       
        if (collider.gameObject.CompareTag("Player")){
            Debug.Log("Entra");

            collider.gameObject.SetActive(false);
        }

    }



}

