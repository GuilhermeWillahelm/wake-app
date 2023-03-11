using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace WakeBlazor.Models
{
    public class PostVideo
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime? Posted { get; set; }
        public string VideoFile { get; set; } = string.Empty;
        public string ThumbImage { get; set; } = string.Empty;
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        public int ChannelId { get; set; }
        public virtual Channel? Channel { get; set; }
    }
}
