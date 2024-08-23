namespace Suzane.WebApp
{
    public interface IMyFileService
    {
        IEnumerable<string> ReadMyFile(string filePath);
    }
}
