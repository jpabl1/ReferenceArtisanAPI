namespace ReferenceArtisan.Entity
{
    public class Projects
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? Comment { get; set; }
        public string? KeyWords { get; set; }
    }
}
