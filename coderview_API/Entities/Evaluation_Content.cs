using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Evaluation_Content
    {
        public int Id { get; set; }
        public int EvaluationId { get; set; }
        public int ContentId { get; set; }
    }
}
