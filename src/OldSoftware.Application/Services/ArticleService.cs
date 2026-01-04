using OldSoftware.Application.Interfaces;

namespace OldSoftware.Application.Services;

public class ArticleService(IMarkdownConverter markdownConverter, IReader fileReader) : IArticleService
{
    public string GetArticle(string articleName)
    {
        var markdownContent = fileReader.Read($"articles/{articleName}.md");
        
        var markdownContentString = System.Text.Encoding.UTF8.GetString(markdownContent);
        
        return markdownConverter.Convert(markdownContentString);
    }
}