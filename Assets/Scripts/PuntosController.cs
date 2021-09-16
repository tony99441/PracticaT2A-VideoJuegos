using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntosController : MonoBehaviour
{
    private int Puntos = 0;

    
    public Text PuntosText;
    
  
    
    // Start is called before the first frame update
    void Start()
    {
        PuntosText.text = "Puntos: "+Puntos;

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int ObtenerPuntos()
    {
        return this.Puntos;
       
    }
    
  
    
    

    public void SumaPuntos(int puntos)
    {
        this.Puntos += puntos;
        PuntosText.text = "Puntos: "+Puntos;
    }
    
 
    
}
