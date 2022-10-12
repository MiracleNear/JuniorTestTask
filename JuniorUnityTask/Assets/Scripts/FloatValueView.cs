using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class FloatValueView : MonoBehaviour
{
    [SerializeField] private string _format;
    
    private Text _view;

    private void Awake()
    {
        _view = GetComponent<Text>();
    }

    public void UpdateView(float value)
    {
        _view.text = string.Format(_format, value);
    }
}
