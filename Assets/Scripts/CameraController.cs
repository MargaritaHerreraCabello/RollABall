using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player; //lo asignamos en la camara arrastrando
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;//transform.position es el componente que cambia XYZ de la camara. Es la distancia que hay entre la camara y el objeto, y se guarda esta distancia en el vector 3 declarado previamente. 
    }

    // Update is called once per frame
    private void LateUpdate() //Es concreto para la cámara
    {
        transform.position = player.transform.position + offset; //la posicion de la camara. Mueve la camara añadiendo la diferencia entre la camara y el jugador. Es decir, se va moviendo la camara tomando en consideracion la distancia que la camara tiene con respecto al jugador. Por ello se iguala al player y su posicion que se transforma, y se le suma el offset.
    }
}
