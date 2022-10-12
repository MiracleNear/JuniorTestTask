using System;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InputField))]
public class UserInput : MonoBehaviour
{
    public Action<float> UserInputValueChanged;
    
    [SerializeField] private InputFiledView _inputFiledView;

    private InputField _inputField;
    private ParserUserInputStringToFloatNumber _parserUserInputStringToFloatNumber;
    
    private void Awake()
    {
        _inputField = GetComponent<InputField>();
        _parserUserInputStringToFloatNumber = new ParserUserInputStringToFloatNumber();
    }
    private void OnEnable()
    {
        _inputField.onEndEdit.AddListener(HandleUserInput);
    }

    private void OnDisable()
    {
        _inputField.onEndEdit.RemoveListener(HandleUserInput);
    }

    private void HandleUserInput(string input)
    {
        if (string.IsNullOrEmpty(input)) return;
        
        if (_parserUserInputStringToFloatNumber.TryParse(input, out float result))
        {
            UserInputValueChanged?.Invoke(result);
            _inputFiledView.ShowInputInformation();
        }
        else
        {
            _inputFiledView.ShorErrorMessage();
        }

        _inputField.text = "";
    }
    
}
