using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public bool pornit=true;
    public GameObject winText;
    public GameObject restartButton;
    public GameObject backButton;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winTextGUI;

    float score = 113;
    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreAdd(int p)
    {
        score-=p;
        scoreText.text = score.ToString();
    }

    public void VerificaWin()
    {
        GameObject[] mingi= GameObject.FindGameObjectsWithTag("minge");
        if (mingi.Length == 0)
            Win();
        
    }

    public void Win()
    {
        pornit = false;
        winText.SetActive(true);
        float nota = ((score - 79) / (100-79))*10;
        Debug.Log(nota.ToString("0.00"));
        winTextGUI.text= winTextGUI.text+" "+"ai primit nota"+" "+nota.ToString("0.00");
        restartButton.SetActive(true);
        backButton.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void Back()
    {
        SceneManager.LoadScene("Meniu");
    }

    public void Quit()
    {
        Application.Quit();
    }

    /*public void touchLocation()
    {
        //MOBILE
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Debug.Log("Touch Position : " + touch.position.ToString());
        }
        else
        {
            Debug.Log( "No touch contacts");
        }

    }*/
}
