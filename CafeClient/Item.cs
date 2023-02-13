namespace CafeClient
{
    public class Item : IItem
    {
        public Item(int id, string title, string imageUrl)
        {
            Id = id;
            Title = title;
            ImageUrl = imageUrl;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }

    public interface IItem
    {
        int Id { get; set; }
        string Title { get; set; }
        string ImageUrl { get; set; }
        string Description { get; set; }
    }
}
