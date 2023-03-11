namespace WakeBlazor.Models
{
    public class Follower
    {
        public int Id { get; set; }
        public int CountFollows { get; set; }
        public int UserId { get; set; }
        public int ChannelId { get; set; }
        public bool IsFollowing { get; set; }
    }
}
