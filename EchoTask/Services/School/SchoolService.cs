using Entities.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Services
{
    public class SchoolService
    {
        UnitOfWork unitOfWork;
        Generic<School> SchoolRepo;
        public SchoolService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            SchoolRepo = unitOfWork.SchoolRepo;
        }
        public SchoolEditViewModel Add(SchoolEditViewModel SchoolEditViewModel)
        {
            School School = SchoolRepo.Add(SchoolEditViewModel.ToModel());
            unitOfWork.commit();
            return School.ToEditableViewModel();
        }
        public SchoolEditViewModel Update(SchoolEditViewModel SchoolEditViewModel)
        {
            School School = SchoolRepo.Update(SchoolEditViewModel.ToModel());
            unitOfWork.commit();
            return School.ToEditableViewModel();
        }
        public void Remove(int id)
        {
            SchoolRepo.Remove(SchoolRepo.GetByID(id));
            unitOfWork.commit();
        }
        public IEnumerable<SchoolViewModel> Get(int id)
        {
            return SchoolRepo.Get(i => i.ID == id).ToList().Select(i => i.ToViewModel());
        }
        public IEnumerable<SchoolViewModel> GetAll()
        {
            return SchoolRepo.GetAll().ToList().Select(i => i.ToViewModel());
        }
        public School GetByID(int id)
        {
            return SchoolRepo.GetByID(id);
        }
    }
}
