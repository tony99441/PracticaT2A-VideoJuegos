using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatoController : MonoBehaviour
{
    public float velocityX;
    public float JumpForce; 
    
    private SpriteRenderer sr;
    private Rigidbody2D rb;
    private Animator animator;

    private const int Idle = 0;
    private const int Run = 1;
    private const int Jump = 2;
    private const int Slide = 3;
    private const int Dead = 4;

    private int estaMuerto = 0;

    public GameObject balaDerecha;

    public GameObject balaIzquierda;



    private MonedasPuntajeController monedasController;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        monedasController = FindObjectOfType<MonedasPuntajeController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (estaMuerto == 0)
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            animator.SetInteger("Estado",0);

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.velocity = new Vector2(-velocityX, rb.velocity.y);
                sr.flipX = true;
                changeAnimation(Run);
            } 
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.velocity = new Vector2(velocityX, rb.velocity.y);
                sr.flipX = false;
                changeAnimation(Run);
            }

            if (Input.GetKey(KeyCode.Z) && Input.GetKey(KeyCode.RightArrow))
            {
                rb.velocity = new Vector2(velocityX, 0); 
                changeAnimation(Slide);

            } 
            if (Input.GetKey(KeyCode.Z) && Input.GetKey(KeyCode.LeftArrow))
            {
                sr.flipX = true;
                rb.velocity = new Vector2(-velocityX, 0); 
                changeAnimation(Slide);

            } 
            if (Input.GetKeyUp(KeyCode.Space))
            {
                rb.AddForce(Vector2.up*JumpForce, ForceMode2D.Impulse);
                changeAnimation(Jump);
            }

            if (Input.GetKeyUp(KeyCode.X))
            {
                var bala = sr.flipX ? balaIzquierda : balaDerecha;
                 var position = new Vector2(transform.position.x, transform.position.y);
                  var rotation = balaDerecha.transform.rotation;
                 Instantiate(bala, position, rotation);
            }



        }

        if (estaMuerto == 1)
        {
            changeAnimation(Dead);
        }



    }
    private void changeAnimation(int animation)
    {
        animator.SetInteger("Estado", animation);
    }
    
    
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Enemigo"))
        {
            Debug.Log("Muere");
            estaMuerto = 1;
        }
        
        if (collision.gameObject.CompareTag("Tipo1"))
        {
            Destroy(collision.gameObject);
            monedasController.SumaPuntosTipo1(1);
            Debug.Log(monedasController.ObtenerPuntosTipo1());
        }
        if (collision.gameObject.CompareTag("Tipo2"))
        {
            Destroy(collision.gameObject);
            monedasController.SumaPuntosTipo2(1);
            Debug.Log(monedasController.ObtenerPuntosTipo2());
        }
        if (collision.gameObject.CompareTag("Tipo3"))
        {
            Destroy(collision.gameObject);
            monedasController.SumaPuntosTipo3(1);
            Debug.Log(monedasController.ObtenerPuntosTipo3());
        }
        
        
        
        

    }


}
