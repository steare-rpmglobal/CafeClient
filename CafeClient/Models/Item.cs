namespace CafeClient.Models
{
    public class Item
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
    }
}
