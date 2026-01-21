using Markdig;
using OwnCMS.Application.Interfaces;

namespace OwnCMS.Application.Convertors;

public class HtmlToMarkdownConverter : IMarkdownConverter
{
    public string Convert(string markdownContent) => Markdown.ToHtml(markdownContent);
}