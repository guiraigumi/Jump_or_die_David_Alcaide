using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocity : MonoBehaviour
{
    public float speed = 5.5f;
    private float horizontal;
    private Rigidbody2D rb ;
    private void Awake(){
        rb = GetComponent<Rigidbody2D>();

    }
    private void FixedUpdate(){
        rb.velocity = new Vector2 (horizontal * speed, 0f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
    }
}
