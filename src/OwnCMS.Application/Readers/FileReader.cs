using System.IO;
using OwnCMS.Application.Interfaces;

namespace OwnCMS.Application.Readers;

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