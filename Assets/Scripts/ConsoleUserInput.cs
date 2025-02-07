using UnityEngine;

public class ConsoleUserInput : MonoBehaviour
{
    private string _inputUser;
    public void GetUserInput(string input) {
        _inputUser = input;
        Debug.Log(_inputUser);
    }
}
