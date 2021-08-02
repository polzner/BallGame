using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EndScreen : Screen
{
    public event UnityAction RestartButtonClick;

    public override void Close()
    {
        _button.interactable = false;
        _endButton.interactable = false;
        _canvasGroup.alpha = 0;
    }

    public override void Open()
    {
        _button.interactable = true;
        _endButton.interactable = true;
        _canvasGroup.alpha = 1;
    }

    protected override void OnButtonClick()
    {
        RestartButtonClick?.Invoke();
    }

    protected override void OnEndButtonClick()
    {
        Application.Quit();
    }
}
