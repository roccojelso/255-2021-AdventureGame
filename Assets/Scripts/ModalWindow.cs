using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ModalWindow : MonoBehaviour
{
    public Text text;
    public Button BackButton;
    public Button NextButton;
    public Button CloseButton;
    public GameObject modalPanelObject;

    private static ModalWindow modalWindow;

    public static ModalWindow Instance()
    {
        if (!modalWindow)
        {
            modalWindow = FindObjectOfType(typeof(ModalWindow)) as ModalWindow;
            if (!modalWindow)
                Debug.LogError("There needs to be one active ModalWindow script on GameObject in your scene.");
        }
        return modalWindow;
    }

    //Back/Next/CLose: A string, a Back event, a Next event and a Close event
    public void Choice(string text, UnityAction backEvent, UnityAction nextEvent, UnityAction closeEvent)
    {
        modalPanelObject.SetActive(true);
        BackButton.onClick.RemoveAllListeners();
        BackButton.onClick.AddListener(backEvent);
        BackButton.onClick.AddListener(ClosePanel);

        modalPanelObject.SetActive(true);
        NextButton.onClick.RemoveAllListeners();
        NextButton.onClick.AddListener(nextEvent);
        NextButton.onClick.AddListener(ClosePanel);

        modalPanelObject.SetActive(true);
        CloseButton.onClick.RemoveAllListeners();
        CloseButton.onClick.AddListener(closeEvent);
        CloseButton.onClick.AddListener(ClosePanel);

        this.text.text = text;

        BackButton.gameObject.SetActive(true);
        NextButton.gameObject.SetActive(true);
        CloseButton.gameObject.SetActive(true);
    }

    void ClosePanel()
    {
        modalPanelObject.SetActive(false);
    }

}
