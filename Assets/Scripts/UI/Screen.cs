using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Screen : MonoBehaviour
{
    [SerializeField] protected CanvasGroup _canvasGroup;
    [SerializeField] protected Button _button;
    [SerializeField] protected Button _endButton;

    private void OnEnable()
    {
        _button.onClick.AddListener(OnButtonClick);
        _endButton.onClick.AddListener(OnEndButtonClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnButtonClick);
        _endButton.onClick.RemoveListener(OnEndButtonClick);
    }

    protected abstract void OnButtonClick();

    protected abstract void OnEndButtonClick();

    public abstract void Open();

    public abstract void Close();
}
