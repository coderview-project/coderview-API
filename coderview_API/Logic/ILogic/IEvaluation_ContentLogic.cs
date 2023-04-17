using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IEvaluation_ContentLogic
    {
        int PostEvaluation_Content(Evaluation_Content econtent);
        List<Evaluation_Content> GetAllEvaluation_Content();
        void DeleteEvaluation_Content(int id); 
    }
}
