namespace PhotoApi.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Width { get; set; }
        public int Height { get; set; }
        public DateTime CreatedAt { get; set; } // Set automatically in ApplicationDbContext
        public DateTime UpdatedAt { get; set; } // Set automatically in ApplicationDbContext
    }
}