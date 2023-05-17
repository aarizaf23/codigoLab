using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuIncial : MonoBehaviour
{

    public string input;
    public GameObject NombredelJugador;
    public GameObject Instrucciones;
    public GameObject menuprincipal;
   

public void Jugar() {
        NombredelJugador.SetActive(true);
        
    }
    public void Salir() {

        Debug.Log("Saliendo");
        Application.Quit();
    }

    public void NombreJugador(string s) { 
    
    input = s;
        Debug.Log(input);

    }
    public void continuarAlJuego() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Instruccionesir() {
        menuprincipal.SetActive(false);
        Instrucciones.SetActive(true);
    }
    public void VolverMenu() {

        menuprincipal.SetActive(true);
        Instrucciones.SetActive(false);
    }
}
