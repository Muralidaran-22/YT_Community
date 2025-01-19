namespace YT_Community.Models
{
    public class VideoLink
    {
        public  int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime PostedDate { get; set; }
        public string UserId { get; set; }
    }
}
