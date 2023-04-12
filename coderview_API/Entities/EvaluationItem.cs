using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EvaluationItem
    {
        public EvaluationItem()
        {
            IsActive = true;
        }
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int StateId { get; set; }
        public int ValueId { get; set; }
        public int Content { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }

        public bool IsActive { get; set; }

    }
}
