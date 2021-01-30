using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TestModalWindow : MonoBehaviour
{
    private ModalWindow modalWindow;
    private DisplayManager displayManager;

    private UnityAction myBackAction;
    private UnityAction myNextAction;
    private UnityAction myCloseAction;

    private void Awake()
    {
        modalWindow = ModalWindow.Instance();
        displayManager = DisplayManager.Instance();

        myBackAction = new UnityAction(TestBackFunction);
        myNextAction = new UnityAction(TestNextFunction);
        myCloseAction = new UnityAction(TestCloseFunction);
    }

    //Send to the Modal Panel to set up the Buttons and Functions to call
    public void TestBNC()
    {
        //modalWindow.Choice("")
    }
    //These are wrapped in UnityActions

    void TestBackFunction()
    {
        displayManager.DisplayMessage("Letss go back a page!");
    }

    void TestNextFunction()
    {
        displayManager.DisplayMessage("Let's go to the next page!");
    }

    void TestCloseFunction()
    {
        displayManager.DisplayMessage("Let's get back to the game!");
    }
}
