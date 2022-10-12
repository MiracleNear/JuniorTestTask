using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class InputFiledView : MonoBehaviour
    {
        [SerializeField] private string _inputInformation;
        [SerializeField] private Text _view;

        private string _errorMessage = "Введите положительное число";

        public void ShowInputInformation()
        {
            _view.text = _inputInformation;
        }

        public void ShorErrorMessage()
        {
            _view.text = _errorMessage;
        }
    }
}