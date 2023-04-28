using coderview_API.IService;
using coderview_API.Models;
using Entities;
using Logic.ILogic;
using Logic.Logic;

namespace coderview_API.Service
{
    public class BootcampService : IBootcampService
    {
        private readonly IBootcampLogic _bootcampLogic;
        public BootcampService(IBootcampLogic bootcampLogic)
        {
            _bootcampLogic = bootcampLogic;
        }

        public void DeactivateBootcamp(int id)
        {
            _bootcampLogic.DeactivateBootcamp(id);
        }

        public List<BootcampItem> GetAllBootcamp()
        {
            return _bootcampLogic.GetAllBootcamp();
        }

        public int AddBootcamp(BootcampItem bootcamp)
        {
            return _bootcampLogic.AddBootcamp(bootcamp);
        }

        public void UpdateBootcamp(BootcampItem bootcamp)
        {
            _bootcampLogic.UpdateBootcamp(bootcamp);
        }

        // Creamos una nueva clase y Validamos elementos de la clase  BootcampItem
        public int AddUBootcamp(BootcampItem bootcampItem)
        {
            //var bootcamp = bootcampItem.Tobootcamp);

            if (!ValidateBootcamp(bootcampItem))
            {
                throw new InvalidDataException("Vaya! El nombre del bootcamp no es valido");
            }
            _bootcampLogic.AddBootcamp(bootcampItem);
            if (!ValidateInsertedBootcamp(bootcampItem))
            {
                throw new InvalidOperationException("Vaya! El bootcamp no ha sido registrado correctamente.");
            }
            return bootcampItem.Id;

        }      

        // Creamos una nueva clase y Validamos elementos de la clase BootcampItem
        public static bool ValidateBootcamp(BootcampItem bootcampItem)
        {

            if (bootcampItem == null)
            {
                return false;
            }
            if (bootcampItem.CreatorId == null )
            {
                return false;
            }

            if (bootcampItem.StartDate > DateTime.Now /*|| *//*bootcampItem.StartDate == "" || bootcampItem.StartDate.string == ""*/)
            {
                return false;
            }
            if (bootcampItem.EndDate < DateTime.Now)
            {
                return false;
            }

            return true;
        }
        public static bool ValidateInsertedBootcamp(BootcampItem bootcampItem)
        {
            if (!ValidateBootcamp(bootcampItem))
            {
                return false;
            }
            if (bootcampItem.Id < 1)
            {
                return false;
            }
            return true;
        }
    }
}
