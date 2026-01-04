using Markdig;
using OldSoftware.Application.Interfaces;

namespace OldSoftware.Application.Convertors;

public class HtmlToMarkdownConverter : IMarkdownConverter
{
    public string Convert(string markdownContent) => Markdown.ToHtml(markdownContent);
}