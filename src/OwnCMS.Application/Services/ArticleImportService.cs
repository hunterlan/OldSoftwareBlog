using OwnCMS.Application.Contexts;
using OwnCMS.Application.Interfaces;
using OwnCMS.Application.Models;

namespace OwnCMS.Application.Services;

internal class ArticleImportService(OwnCmsContext cmsContext) : IArticleImportService
{
    public Guid Import(Stream htmlStreamContent, Stream cssStreamContent, string articleName, 
        CancellationToken cancellationToken, string? articleSlug, string? category)
    {
        //TODO: Add validations
        var htmlContent = ReadStream(htmlStreamContent);
        var cssContent = ReadStream(cssStreamContent);

        articleSlug ??= articleName.ToLower().Replace(" ", "-");
        
        //TODO: Find category by ID or name or create new if name is provided.
        var content = new Content
        {
            CreatedAt = DateTime.UtcNow,
            Title = articleName,
            Slug = articleSlug,
            HtmlBody = htmlContent,
            Css = cssContent,
        };
        
        cmsContext.Contents.Add(content);
        cmsContext.SaveChangesAsync(cancellationToken);
        
        return content.Id;
    }

    private byte[] ReadStream(Stream stream)
    {
        List<byte> bytes = new();
        byte[] buffer = new byte[128];
        int read;

        while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
        {
            bytes.AddRange(buffer.Take(read));
        }
        
        return bytes.ToArray();
    }
}