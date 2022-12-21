using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizControl : MonoBehaviour
{
    private const double V = 0.047;
    private const double B = 0.049;
    private const double N = 0.039;

    public GameObject bola1;
    public GameObject bola2;
    public GameObject bola3;
    public GameObject bola4;
    public GameObject bola5;
    public GameObject bola6;
    public GameObject bola7;
    public GameObject bola8;


    [SerializeField]
    private Text questionTextElement;
    [SerializeField]
    private Button[] buttons;
    

    [SerializeField]

    private Question[] questions;

    private int currentQuestionIndex = 0;

    public Question GetCurrentQuestion()
    {
        var question = questions[currentQuestionIndex];
        return question;
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 8; i++){
            GameObject bola = new GameObject("balls"+i);
        }

        bola3.gameObject.SetActive(false);
        bola6.gameObject.SetActive(false);
        bola7.gameObject.SetActive(false);
        bola8.gameObject.SetActive(false);


        InitializeButtons();
        PresentCurrentQuestion();

        
        //CreateBalls((float)-0.09, (float)0.02, (float)-0.0283);
        //CreateBalls((float)-0.0774, (float)0.0227, (float)0.0481);
        //GameObject ball1 =
        //    GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //ball1.transform.localScale = new Vector3((float)V, (float)B, (float)N);
        //ball1.transform.position = new Vector3((float)0.0826, (float)0.0128, (float)-0.0415);

        //GameObject ball2 =
          //  GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //ball2.transform.localScale = new Vector3((float)V, (float)B, (float)N);
        //ball2.transform.position = new Vector3((float)0.0139, (float)0.0112, (float)-0.0353);

        //GameObject ball3 =
          //  GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //ball3.transform.localScale = new Vector3((float)V, (float)B, (float)N);
        //ball3.transform.position = new Vector3((float)-0.0774, (float)0.0227, (float)0.0481);
        
        //GameObject ball4 =
          //  GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //ball4.transform.localScale = new Vector3((float)V, (float)B, (float)N);
        //ball4.transform.position = new Vector3((float)-0.09, (float)0.02, (float)-0.0283);

    }



    private void CreateBalls(float a,float b,float c)
    {
        GameObject ball3 =
            GameObject.CreatePrimitive(PrimitiveType.Sphere);
        ball3.transform.localScale = new Vector3((float)V, (float)B, (float)N);
        ball3.transform.position = new Vector3((float)a, (float)b, (float)c);
    }

    private void PresentCurrentQuestion()
    {
        var question = GetCurrentQuestion();
        questionTextElement.text = question.QuestionText;
        
        for (int i = 0; i < buttons.Length; i++)
        {
            if (i >= question.Answers.Length)
            {
                buttons[i].gameObject.SetActive(false);
                continue;

            }

            string answerText = question.Answers[i];
            buttons[i].gameObject.SetActive(true);
            buttons[i].GetComponentInChildren<Text>().text = answerText;

        }



    }

    private void InitializeButtons()
    {
        for (int i=0; i < buttons.Length; i++)

        {
            Button button = buttons[i];
            int buttonIndex = i;

            button.onClick.AddListener(() => ShowResponse(buttonIndex));

        }



    }

    private void ShowResponse(int buttonIndex)
    {
        var question = GetCurrentQuestion();
        //questionTextElement.text = question.Responses[buttonIndex];

        StartCoroutine(MoveToNextQuestionAfterDelay());

    }

    private IEnumerator MoveToNextQuestionAfterDelay()
    {
        yield return new WaitForSeconds(0.5f);
        currentQuestionIndex++;
        PresentCurrentQuestion();

    }


    // Update is called once per frame
    void Update()
    {
        if (currentQuestionIndex == 1)
        {
            bola1.gameObject.SetActive(true);
            bola2.gameObject.SetActive(true);
            bola3.gameObject.SetActive(false);
            bola4.gameObject.SetActive(true);
            bola5.gameObject.SetActive(true);
            bola6.gameObject.SetActive(false);
            bola7.gameObject.SetActive(false);
            bola8.gameObject.SetActive(true);
        }
        if (currentQuestionIndex == 2)
        {
            bola1.gameObject.SetActive(true);
            bola2.gameObject.SetActive(true);
            bola3.gameObject.SetActive(true);
            bola4.gameObject.SetActive(true);
            bola5.gameObject.SetActive(true);
            bola6.gameObject.SetActive(true);
            bola7.gameObject.SetActive(false);
            bola8.gameObject.SetActive(false);
        }
        if (currentQuestionIndex == 3)
        {
            bola1.gameObject.SetActive(true);
            bola2.gameObject.SetActive(true);
            bola3.gameObject.SetActive(true);
            bola4.gameObject.SetActive(false);
            bola5.gameObject.SetActive(false);
            bola6.gameObject.SetActive(true);
            bola7.gameObject.SetActive(true);
            bola8.gameObject.SetActive(true);
        }
        if (currentQuestionIndex == 4)
        {
            bola1.gameObject.SetActive(false);
            bola2.gameObject.SetActive(true);
            bola3.gameObject.SetActive(false);
            bola4.gameObject.SetActive(true);
            bola5.gameObject.SetActive(false);
            bola6.gameObject.SetActive(true);
            bola7.gameObject.SetActive(false);
            bola8.gameObject.SetActive(true);
        }
        if (currentQuestionIndex == 5)
        {
            bola1.gameObject.SetActive(true);
            bola2.gameObject.SetActive(false);
            bola3.gameObject.SetActive(false);
            bola4.gameObject.SetActive(true);
            bola5.gameObject.SetActive(true);
            bola6.gameObject.SetActive(false);
            bola7.gameObject.SetActive(true);
            bola8.gameObject.SetActive(true);
        }
        if (currentQuestionIndex == 6)
        {
            bola1.gameObject.SetActive(true);
            bola2.gameObject.SetActive(true);
            bola3.gameObject.SetActive(true);
            bola4.gameObject.SetActive(true);
            bola5.gameObject.SetActive(true);
            bola6.gameObject.SetActive(true);
            bola7.gameObject.SetActive(true);
            bola8.gameObject.SetActive(true);
        }
        if (currentQuestionIndex == 7)
        {
            bola1.gameObject.SetActive(true);
            bola2.gameObject.SetActive(true);
            bola3.gameObject.SetActive(false);
            bola4.gameObject.SetActive(true);
            bola5.gameObject.SetActive(true);
            bola6.gameObject.SetActive(false);
            bola7.gameObject.SetActive(false);
            bola8.gameObject.SetActive(true);
        }
        if (currentQuestionIndex == 8)
        {
            bola1.gameObject.SetActive(false);
            bola2.gameObject.SetActive(false);
            bola3.gameObject.SetActive(false);
            bola4.gameObject.SetActive(false);
            bola5.gameObject.SetActive(true);
            bola6.gameObject.SetActive(true);
            bola7.gameObject.SetActive(true);
            bola8.gameObject.SetActive(true);
        }
        if (currentQuestionIndex == 9)
        {
            bola1.gameObject.SetActive(true);
            bola2.gameObject.SetActive(true);
            bola3.gameObject.SetActive(true);
            bola4.gameObject.SetActive(false);
            bola5.gameObject.SetActive(true);
            bola6.gameObject.SetActive(true);
            bola7.gameObject.SetActive(true);
            bola8.gameObject.SetActive(true);
        }
        if (currentQuestionIndex == 10)
        {
            bola1.gameObject.SetActive(true);
            bola2.gameObject.SetActive(true);
            bola3.gameObject.SetActive(false);
            bola4.gameObject.SetActive(false);
            bola5.gameObject.SetActive(true);
            bola6.gameObject.SetActive(false);
            bola7.gameObject.SetActive(true);
            bola8.gameObject.SetActive(true);
        }
    }
}


[Serializable]
public class Question
{
    public string QuestionText;
    public string[] Answers;
    public string[] Responses;
}