using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnsewrs> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public Text Questiontxt;
    public GameObject Quizpanel;
    public GameObject GOpanel;
    public GameObject Ganarpanel;
    public GameObject Perderpanel;
    public GameObject AyudaTelefono;
    public GameObject AyudaPublico;
    public GameObject Distinguido;
    public Image image;
    public Image image2;
    public Image image3;
    public Button button;
    public Text scoretxt;
    int TotalQuestions=0;
    public int score;
    private void Start()
    {
        TotalQuestions=QnA.Count;
        
        GOpanel.SetActive(false);
        Ganarpanel.SetActive(false);

        GenerateQuestion();
    }
    public void Retry() { 
    
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
     void GameOver() {
        Quizpanel.SetActive(false);
        GOpanel.SetActive(true);
        scoretxt.text = score + "/" + TotalQuestions;

        if (score == TotalQuestions)
        {
            image.enabled = true;
        }
        else {
            if (score == 4)
            {
                image.enabled = false;
                image2.enabled = true;



            }
        }
        
                if (score < 3) {
                    image.enabled = false;
                    image3.enabled= true;
                
                }
            
            }
        
        

    
    
    public void correct() {
        score += 1;
        QnA.RemoveAt(currentQuestion);
        Quizpanel.SetActive(false);
        Ganarpanel.SetActive(true);
        GenerateQuestion();
        
    }
    public void pasarCorrecta() {
        Quizpanel.SetActive(true);
        Ganarpanel.SetActive(false);
        Perderpanel.SetActive(false);


        GenerateQuestion();

    }
    
    public void incorrect()
    {
        
        QnA.RemoveAt(currentQuestion);
        Quizpanel.SetActive(false);
        Perderpanel.SetActive(true);
        GenerateQuestion();
    }
    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
            if (QnA[currentQuestion].CorrectAnswer == i + 1) {

                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        
        
        }

    }
   
    void GenerateQuestion() {

        
        if (QnA.Count > 0)
        {
           

            currentQuestion = Random.Range(0, QnA.Count);
            Questiontxt.text = QnA[currentQuestion].Question;
            SetAnswers();

        }
        else {

            Debug.Log("Fuera del rango");
            GameOver();
        
        }
        
       
    }
    public void Telefono() {
        Quizpanel.SetActive(false);
        AyudaTelefono.SetActive(true);

    }
    public void cerrarTelefono() {

        Quizpanel.SetActive(true);
        AyudaTelefono.SetActive(false);

    }
    public void CincuentaCincuenta() {
        button.interactable = false;
        button.gameObject.SetActive(false);
        
    }

    public void QuitarCincuenta() {
        button.interactable = true;
        button.gameObject.SetActive(true);
    }

    public void Publico() {
        Quizpanel.SetActive(false);
        AyudaPublico.SetActive(true);
        


    }
    public void CerrarPublico() {
        Quizpanel.SetActive(true);
        AyudaPublico.SetActive(false);
    }
    
}
