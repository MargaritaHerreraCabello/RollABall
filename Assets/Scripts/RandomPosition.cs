using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
/*____________________________VARIABLES____________________________*/

    public GameObject pickupPrefab;
    public int numberPickups; //max number of butterflies that will spawn in the scene

/*____________________________METHODS____________________________*/

    // Start is called before the first frame update
    void Start()
    {

        for(int i=0; i<=numberPickups; i++) //Since 1 until the maximun number of butterflies allowed to be in the scene, the array will be traveled
        {
        //////////Random Positions:

            Vector3 initialPosition = new Vector3(1*i, 1*i , 1*i); 
            
            float randomPositionX = Random.Range(-9, 9);
            float randomPositionZ = Random.Range(-9, 9);
            GameObject pickUp;
            pickUp = Instantiate(pickupPrefab, initialPosition, Quaternion.identity);
            pickUp.transform.position = new Vector3(randomPositionX, 0.5f, randomPositionZ); //Instantiate the object depending on the iteration, giving random positions to each object
            pickUp.transform.parent = this.transform;
        }        
    }
}
