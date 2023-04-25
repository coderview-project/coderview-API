using Data;
using Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class BootcampLogic : IBootcampLogic
    {
        private readonly ServiceContext _serviceContext; 
        public BootcampLogic(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public void DeactivateBootcamp(int id)
        {
            try
            {
                var bootcampToDeactivate = _serviceContext.Set<BootcampItem>().Where(b => b.Id == id).First();
                bootcampToDeactivate.IsActive = false;
                _serviceContext.SaveChanges();
            } catch
            {
                throw new Exception("Algo salió mal");
            }
            
        }

        public List<BootcampItem> GetAllBootcamp()
        {
            return _serviceContext.Set<BootcampItem>().Where(b => b.IsActive == true).ToList();
        }

        public int PostBootcamp(BootcampItem bootcamp)
        {
            try
            {
                _serviceContext.Bootcamps.Add(bootcamp);
                _serviceContext.SaveChanges();
                return bootcamp.Id;
            }
            catch
            {
                throw new Exception("¡Vaya! El bootcamp no ha sido registrado correctamente.");
            }
        }

        public void UpdateBootcamp(BootcampItem bootcamp)
        {
            _serviceContext.Bootcamps.Update(bootcamp);
            _serviceContext.SaveChanges();
        }
    }
}
