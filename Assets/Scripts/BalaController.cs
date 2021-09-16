using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaController : MonoBehaviour
{
    public float velocityX = 10f;
    private Rigidbody2D rb;

    private PuntosController puntosController;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        puntosController = FindObjectOfType<PuntosController>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velocityX, rb.velocity.y);
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Enemigo")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            puntosController.SumaPuntos(10);
            Debug.Log(puntosController.ObtenerPuntos());


        }
       

        
    }
    
}
