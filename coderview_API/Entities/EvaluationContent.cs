using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EvaluationContent
    {
        public int Id { get; set; }
        public int EvaluationId { get; set; }
        public int ContentId { get; set; }
        public int ValueId { get; set; }
    }
}
