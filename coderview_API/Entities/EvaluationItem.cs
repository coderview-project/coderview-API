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
        public int EvaluatorId { get; set; }
        public int EvaluateeUserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }

    }
}
