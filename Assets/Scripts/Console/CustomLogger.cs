// 04.02.2025 AI-Tag
// This was created with assistance from Muse, a Unity Artificial Intelligence product

using System;
using Converters;
using TMPro;
using UnityEngine;

public class CustomLogger : MonoBehaviour {
    private MyConsole _console;
    private IConverter<LogType, Color> _logTypeToColorConverter;

    private void Awake() {
        _console = GetComponent<MyConsole>();
        _logTypeToColorConverter = new LogTypeToColorConverter();
        Application.logMessageReceived += HandleLog;
    }

    private void OnDisable() {
        Application.logMessageReceived -= HandleLog;
    }

    private void HandleLog(string logString, string stackTrace, LogType type) {
        Color logColor = _logTypeToColorConverter.ConvertFrom(type);
        string hexColor = ColorUtility.ToHtmlStringRGBA(logColor);
        string trimLogString = logString.Replace("\n", string.Empty);
        DateTime timestamp = DateTime.Now.ToLocalTime();

        string msg = $"<color=#{hexColor}>[{timestamp:hh:mm:ss}] [{type}] {trimLogString}</color>\n";
        _console.Print(msg);
    }
}