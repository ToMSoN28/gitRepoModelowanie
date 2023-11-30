public static class Version
{
    private static int major = 1;
    private static int minor = 0;
    private static int patch = 1;

    public static string Current => $"{major}.{minor}.{patch}";

    public static void IncreaseVersion()
    {
        patch++;
    }
}
