namespace PCL;

/// <summary>
/// Compatibility shim for disabled region-based restrictions. Downloads and installations are not
/// restricted according to the user's location.
/// </summary>
internal static class RestrictedFeaturePolicy
{
    internal static bool IsRestricted => false;

    internal static bool Check(string feature, bool showHint = true) => true;

    internal static void ThrowIfRestricted(string feature)
    {
    }
}
