using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCucina.Models
{
    public class BatchCardDto
    {
        public int BatchId { get; set; }
        public int OrderId { get; set; }
        public string TableNumber { get; set; }
        public string SpaceName { get; set; }
        public DateTime SentAt { get; set; }
        public int BatchStatus { get; set; }
        public List<BatchItemDto> Items { get; set; } = new List<BatchItemDto>();
    }

}
