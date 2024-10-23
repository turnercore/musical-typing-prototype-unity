using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField]
    private GameObject Word2;

    public bool canPushM = false;
    public bool canPushU = false;
    public bool canPushS = false;
    public bool canPushI = false;
    public bool canPushC = false;
    public bool canPushA = false;
    public bool canPushL = false;
    public int score = 0;
    public AudioSource failSound;
    public TMP_Text scoreText;
    public TMP_Text WinText;

    private void Update()
    {
        if (canPushM && Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("nailed it");
            score++;
            canPushM = false;
        }
        else if (canPushU && Input.GetKeyDown(KeyCode.U))
        {
            Debug.Log("nailed it");
            score++;
            canPushU = false;
        }
        else if (canPushS && Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("nailed it");
            score++;
            canPushS = false;
        }
        else if (canPushI && Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("nailed it");
            score++;
            canPushI = false;
        }
        else if (canPushC && Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("nailed it");
            score++;
            canPushC = false;
        }
        else if (canPushA && Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("nailed it");
            score++;
            canPushA = false;
        }
        else if (canPushL && Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("nailed it");
            score++;
            canPushL = false;
        }
        // Check if any key is pushed
        else if (Input.anyKeyDown)
        {
            Debug.Log("wrong key");
            failSound.Play();
        }
        else if (score == 7)
        {
            Debug.Log("You Win!");
            WinText.text = "You Win!";
        }

        // Update score text
        scoreText.text = "Score: " + score;
    }
}
