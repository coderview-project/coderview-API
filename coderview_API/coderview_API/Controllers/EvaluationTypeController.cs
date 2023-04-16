﻿using coderview_API.IService;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace coderview_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class EvaluationTypeController : ControllerBase
    {
        private readonly IEvaluationTypeService _evaluationTypeService; 
        public EvaluationTypeController(IEvaluationTypeService evaluationTypeService)
        {
            _evaluationTypeService = evaluationTypeService;
        }

        [HttpGet(Name = "GetAllEvaluationType")]

        public List<EvaluationType> GetAllEvaluationType()
        {
            return _evaluationTypeService.GetAllEvaluationType();
        }

        [HttpPost(Name = "PostEvaluationType")]

        public int PostEvaluationType(EvaluationType type)
        {
            return _evaluationTypeService.PostEvaluationType(type);
        }
    }
}