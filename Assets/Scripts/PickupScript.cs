using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    public CounterEnemies count; //reference to the class CounterEnemies, now it is saved in the variable count

    // Update is called once per frame
    void Awake() //I create an Awake method, that initialize all its variables before the game starts
    {
        if(count==null) //if the class CounterEnemies isn't found...
        {
            count = GameObject.Find("Scripter").GetComponent<CounterEnemies>(); //...I look for it to asign it to count, as I tried to do before
            Debug.Log(count); 
        }
    }
    void Update()
    {
        transform.Rotate(new Vector3(15,30,45) * Time.deltaTime); //with Time.deltaTime I make rotation work depending on the time.
    }

    void OnDisable(){ //with this method, 
        count.counter++; //I select the variable counter from the script CounterEnemies (now named count)
        Debug.Log("You have collected " + count.counter + " crystals!"); //and show it in the console
    }
}

