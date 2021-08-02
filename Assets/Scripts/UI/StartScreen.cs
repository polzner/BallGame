using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartScreen : Screen
{
    public event UnityAction StartButtonClick;

    public override void Close()
    {
        _button.interactable = false;
        _endButton.interactable = false;
        _canvasGroup.alpha = 0;
        _canvasGroup.blocksRaycasts = false;
    }

    public override void Open()
    {
        _button.interactable = true;
        _endButton.interactable = true;
        _canvasGroup.alpha = 1;
        _canvasGroup.blocksRaycasts = true;
    }

    protected override void OnButtonClick()
    {
        StartButtonClick?.Invoke();
    }

    protected override void OnEndButtonClick()
    {
        Application.Quit();
    }
}
