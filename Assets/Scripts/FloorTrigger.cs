using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTrigger : MonoBehaviour
{



    private GameObject Player;

    Movement mov;






    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        mov = Player.GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }


    public void OnTriggerEnter(Collider collision)
    {
        mov.isGrounded = true;
        //Debug.Log ("entra");
    }
    public void OnTriggerExit(Collider collision)
    {
        mov.isGrounded = false;
        //Debug.Log("sale");
    }
    private void OnTriggerStay(Collider colllision)
    {
        mov.isGrounded = true;
    }

}
