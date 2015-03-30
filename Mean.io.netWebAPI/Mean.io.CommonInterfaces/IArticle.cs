namespace Mean.io.CommonInterfaces
{
    public interface IArticle
    {
        string Category { get; set; }
        decimal Price { get; set; }
        string username { get; set; }
        int _id { get; set; }
    }
}