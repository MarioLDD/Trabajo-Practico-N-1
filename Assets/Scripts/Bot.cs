using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    public string nuevoNombre;
    public GameObject saludo;
    void Start()
    {
       
    }

    public void Saludar()
    {
        Humano humano = GameObject.Find("Humano").GetComponent<Humano>();
        string nombre = humano.Nombre;
        string mensaje = ("Hola " + nombre + " ahora te llamas " + nuevoNombre);
        humano.Nombre = nuevoNombre;
        saludo.GetComponent<Saludo>().MuestroSaludo(mensaje);
    }
}
