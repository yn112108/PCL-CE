namespace PCL.Core.App.Essentials;

/// <summary>
/// Compatibility shim: telemetry and remote error reporting are disabled in this build.
/// </summary>
public sealed class TelemetryService
{
    /// <summary>Telemetry is disabled, so the build is never blocked based on provenance.</summary>
    public static bool IsBuildUntrusted => false;

    /// <summary>No exception data is sent remotely.</summary>
    public static void ReportException(Exception ex, string plain, PCL.Core.Logging.LogLevel level)
    {
    }
}
