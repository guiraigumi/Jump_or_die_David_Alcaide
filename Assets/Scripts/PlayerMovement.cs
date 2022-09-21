using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.5f;
    private float horizontal;
    private Transform playerTransform;    
    
    // Start es lo primero que se ejecuta, y solo una vez.
    void Start()
    {
        //Hace que el componente transform sea modificable para conseguir movimiento.
        playerTransform = GetComponent<Transform>();
    }

    // Update es llamado una vez por frame.
    void Update()
    {
        //GetAxisRaw es para el movimiento, GetButtonDown no funciona para ese tipo de función y da error.
        horizontal = Input.GetAxisRaw("Horizontal");
        /*Esto transforma la posición del jugador teniendo en cuenta los vectores (x,y,z). Coge la variable horizontal y la multiplica por la variable velocidad y el timedeltatime ayuda a normalizar el tiempo,
        haciendo que los frames no afecten a la velocidad del personaje (cosa que si que pasa al meter la función en Update)*/ 
        //playerTransform.position += new Vector3 (horizontal * speed * Time.deltaTime, 0, 0); --> forma de movimiento horizontal del personaje.

        //esta es otra forma de movimiento, utilizando translate. El último valor, Space.World, es para indicar dónde se ejecutará ese movimiento. 
        playerTransform.Translate(Vector3.right * horizontal * speed * Time.deltaTime, Space.World);
    }
}
