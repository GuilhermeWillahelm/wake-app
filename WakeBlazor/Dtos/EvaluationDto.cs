namespace WakeBlazor.Dtos
{
    public class EvaluationDto
    {
        public int Id { get; set; }
        public int CountLike { get; set; }
        public int CountDislike { get; set; }
        public int UserId { get; set; }
        public int ChannelId { get; set; }
        public int PostId { get; set; }
        public bool Flag { get; set; }
    }
}
