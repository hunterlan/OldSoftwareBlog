using OldSoftware.Application.Interfaces;

namespace OldSoftware.Application.Readers;

public class FileReader : IReader
{
    public byte[] Read(string source)
    {
        if (!File.Exists(source))
        {
            throw new FileNotFoundException();
        }
        
        return File.ReadAllBytes(source);
    }
}