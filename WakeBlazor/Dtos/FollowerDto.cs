namespace WakeBlazor.Dtos
{
    public class FollowerDto
    {
        public int Id { get; set; }
        public int CountFollows { get; set; }
        public int UserId { get; set; }
        public int ChannelId { get; set; }
        public bool IsFollowing { get; set; }
    }
}
