using OldSoftware.Application.Convertors;
using OldSoftware.Application.Interfaces;
using OldSoftware.Application.Readers;
using OldSoftware.Application.Services;

namespace OldSoftware.Presentation.Extensions;

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

