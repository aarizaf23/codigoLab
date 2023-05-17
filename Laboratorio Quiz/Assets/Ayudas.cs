using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Ayudas : MonoBehaviour
{
    public List<QuestionAndAnsewrs> QnA;
    public GameObject Telefono;
    int TotalQuestions = 0;
    public int currentQuestion;
    private void Start()
    {
        
        


    }
    public void Telefonohelp()
    {
        
        Telefono.SetActive(true);
    }
    void CerrarTelefono() { 
    
    
    }
}
