using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NonPlayerCharacter : MonoBehaviour
{
    public float displayTimeDB = 4.0f;
    public float displayTimeIA = 1f;
    public GameObject dialogBox;
    public GameObject interactableImage;
    private float timerDisplayDB;
    private float timerDisplayIA;

    public string TextContent;
    void Start()
    {
        dialogBox.SetActive(false);
        interactableImage.SetActive(false);
        timerDisplayIA = -1.0f;
        timerDisplayDB = -1.0f;

        Text messageText = dialogBox.GetComponentInChildren<Text>();
        if (messageText != null) messageText.text = TextContent;
    }

    void Update()
    {
        if (timerDisplayDB >= 0)
        {
            timerDisplayDB -= Time.deltaTime;
            if (timerDisplayDB < 0)
            {
                dialogBox.SetActive(false);
            }
        }
        if (timerDisplayIA >= 0)
        {
            timerDisplayIA -= Time.deltaTime;
            if (timerDisplayIA < 0)
            {
                interactableImage.SetActive(false);
            }
        }
    }

    public void DisplayDialog()
    {
        timerDisplayDB = displayTimeDB;
        dialogBox.SetActive(true);
    }

    public void DisplayInteractable()
    {
        timerDisplayIA = displayTimeIA;
        interactableImage.SetActive(true);
    }
}
