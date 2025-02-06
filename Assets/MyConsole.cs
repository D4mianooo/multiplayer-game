using System.Linq;
using TMPro;
using UnityEngine;

public class MyConsole : MonoBehaviour
{
    [SerializeField] private TMP_Text _outputText;

    public void Print(string text) {
        string replaced = text.Replace("\n", string.Empty);
        _outputText.text += replaced + "\n";
    }
}
