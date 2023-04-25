using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EvaluationValue
    {
        public int Id { get; set; }
        public EvaluationValueEnum Title { get; set; }
        public int Value { get; set; }
    }
}
