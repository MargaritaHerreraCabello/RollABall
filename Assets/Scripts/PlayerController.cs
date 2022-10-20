using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;    //IMPORTANTE: Importar la librer�a      

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;

    public float speed;
    
    private float movementX;
    private float movementY;

    private void Start()
    {
        rb = GetComponent<Rigidbody>(); //guardo en la variable rb el componente Rigibody
    }

    ///<summary>
    ///<param name="movementValue">Event to control the movement</param>
    ///</summary>

    private void OnMove(InputValue movementValue) 
    { 
        Vector2 movementVector = movementValue.Get<Vector2>(); //uso un vector dos porque solo vamos a usar dos ejes (el X y el Z)
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate() //all the things that have physics shall use the FixedUpdate method instead of the update
    { 
        Vector3 movement = new Vector3(movementX, 0.0f , movementY); // i won't use the Y axis, so I'll give it 0.0f value. For the Z, I use the Y of the Vector2
        rb.AddForce(movement * speed); //force
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false); //this way the prefabs won't be destroyed
        }
    }

}
