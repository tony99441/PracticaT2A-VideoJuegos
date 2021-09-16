using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonedasPuntajeController : MonoBehaviour
{ 
    private int PuntoTipo1 = 0; 
    public Text Tipo1Text; 
    
    private int PuntoTipo2 = 0; 
    public Text Tipo2Text; 

    private int PuntoTipo3 = 0; 
    public Text Tipo3Text; 
    
    // Start is called before the first frame update
    void Start()
    {
        Tipo1Text.text = "Moneda Tipo 1: " + PuntoTipo1;
        Tipo1Text.text = "Moneda Tipo 2: " + PuntoTipo2;
        Tipo1Text.text = "Moneda Tipo 3: " + PuntoTipo3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int ObtenerPuntosTipo1()
    {
        return this.PuntoTipo1;
       
    }
    public int ObtenerPuntosTipo2()
    {
        return this.PuntoTipo2;
       
    }
    public int ObtenerPuntosTipo3()
    {
        return this.PuntoTipo3;
       
    }
    

    public void SumaPuntosTipo1(int puntosTipo1)
    {
        this.PuntoTipo1 += puntosTipo1;
        Tipo1Text.text = "Moneda Tipo 1: "+PuntoTipo1;
    }
    
    public void SumaPuntosTipo2(int puntosTipo2)
    {
        this.PuntoTipo2 += puntosTipo2;
        Tipo2Text.text = "Moneda Tipo 2: "+PuntoTipo2;
    }
    public void SumaPuntosTipo3(int puntosTipo3)
    {
        this.PuntoTipo3 += puntosTipo3;
        Tipo3Text.text = "Moneda Tipo 3: "+PuntoTipo3;
    }
}
