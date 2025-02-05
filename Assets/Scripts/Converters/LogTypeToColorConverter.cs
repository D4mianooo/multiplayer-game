using UnityEngine;

namespace Converters {
    public class LogTypeToColorConverter : IConverter<LogType, Color> {
        public Color ConvertFrom(LogType u) {
            switch (u) {
                case LogType.Error:
                    return Color.red;
                case LogType.Warning:
                    return Color.yellow;
                case LogType.Log:
                    return Color.green;
                default:
                    return Color.white;
            }
        }
        public LogType ConvertTo(Color u) {
            throw new System.NotImplementedException();
        }
    }
}
