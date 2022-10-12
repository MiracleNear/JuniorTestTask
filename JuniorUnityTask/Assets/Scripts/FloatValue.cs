using System;
using UnityEngine;

public class FloatValue : MonoBehaviour
{
    public float Value => _value;

    [SerializeField] private FloatValueView _floatValueView;
    [SerializeField] private UserInput _userInput;
    [SerializeField] private float _value;

    private void OnEnable()
    {
        _userInput.UserInputValueChanged += UserInputValueChanged;
    }

    private void OnDisable()
    {
        _userInput.UserInputValueChanged -= UserInputValueChanged;
    }

    private void Start()
    {
        _floatValueView.UpdateView(_value);
    }

    private void UserInputValueChanged(float value)
    {
        _value = value;
        _floatValueView.UpdateView(value);
    }
}
