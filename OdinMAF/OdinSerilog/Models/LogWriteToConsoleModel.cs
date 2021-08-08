
using Serilog.Sinks.SystemConsole.Themes;

namespace OdinPlugs.OdinWebApi.OdinMAF.OdinSerilog.Models
{
    public class LogWriteToConsoleModel
    {
        public string OutputTemplate { get; set; }
        public SystemConsoleTheme ConsoleTheme { get; set; } = SystemConsoleTheme.Colored;
    }
}