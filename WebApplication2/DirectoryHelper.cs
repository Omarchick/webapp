namespace TelegramGptBot;

public static class DirectoryHelper
{
    public static string GetProjectRoot()
    {
        return Directory.GetParent(Directory.GetCurrentDirectory()).ToString() ??
                            string.Empty;
    }

    public static string GetFilePathFromDirectory(this string fileName, string directory = "")
    {
        return Path.Combine(GetProjectRoot(), directory, fileName);
    }
    
    public static string GetFullFileName(this string fileName)
    {
        return Path.Combine(Directory.GetCurrentDirectory(), "ResultImages", fileName);
    }
    public static string GetFullJFName(this string fileName)
    {
        return Path.Combine(Directory.GetCurrentDirectory(), "FactAndJokeText", fileName);
    }
}