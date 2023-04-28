using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EvaluationData
    {
        public int Id { get; set; }
        public int ProjectM { get; set; }
        public int FuncTech1 { get; set; }
        public int FuncTech2 { get; set; }
        public int FuncTech3 { get; set; }
        public int Front1 { get; set; }
        public int Front2 { get; set; }
        public int Back1 { get; set; }
        public int Back2 { get; set; }
        public int Archit { get; set; }   
        public int Qa1 { get; set; }
        public int Qa2 { get; set; }
        public int Qa3 { get; set; }
        public int EvaluatorId { get; set; }
        public int EvaluateeId { get; set; }
        public int EvaluationId { get; set; }
            
    }
}
