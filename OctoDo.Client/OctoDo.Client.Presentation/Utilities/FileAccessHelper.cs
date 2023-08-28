namespace OctoDo.Client.Presentation.Utilities;
public class FileAccessHelper
{
    public static string GetLocalFilePath(string fileName)
    {
        return Path.Combine(FileSystem.AppDataDirectory, fileName);
    }
}
