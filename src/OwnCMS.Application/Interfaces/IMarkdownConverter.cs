namespace OwnCMS.Application.Interfaces;

public interface IMarkdownConverter
{
    string Convert(string markdownContent);
}