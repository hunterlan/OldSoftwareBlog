using OwnCMS.Application.Convertors;
using OwnCMS.Application.Interfaces;
using OwnCMS.Application.Readers;
using OwnCMS.Application.Services;

namespace OwnCMS.Presentation.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Register services
        services.AddScoped<IArticleService, ArticleService>();
        
        // Register converters
        services.AddScoped<IMarkdownConverter, HtmlToMarkdownConverter>();
        
        // Register readers
        services.AddScoped<IReader, FileReader>();
        
        return services;
    }
}
