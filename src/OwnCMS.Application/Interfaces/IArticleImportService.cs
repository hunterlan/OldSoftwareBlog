namespace OwnCMS.Application.Interfaces;

public interface IArticleImportService
{
    Guid Import(Stream htmlStreamContent, Stream cssStreamContent, string articleName, 
        CancellationToken cancellationToken, string? articleSlug, string? category);
}