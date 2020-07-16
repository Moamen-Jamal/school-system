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
    public class ClassDayService
    {
        UnitOfWork unitOfWork;
        Generic<ClassDay> ClassDayRepo;
        public ClassDayService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            ClassDayRepo = unitOfWork.ClassDayRepo;
        }
        public ClassDayEditViewModel Add(ClassDayEditViewModel ClassDayEditViewModel)
        {
            ClassDay ClassDay = ClassDayRepo.Add(ClassDayEditViewModel.ToModel());
            unitOfWork.commit();
            return ClassDay.ToEditableViewModel();
        }
        public ClassDayEditViewModel Update(ClassDayEditViewModel ClassDayEditViewModel)
        {
            ClassDay ClassDay = ClassDayRepo.Update(ClassDayEditViewModel.ToModel());
            unitOfWork.commit();
            return ClassDay.ToEditableViewModel();
        }
        public void Remove(int id)
        {
            ClassDayRepo.Remove(ClassDayRepo.GetByID(id));
            unitOfWork.commit();
        }
        public IEnumerable<ClassDayViewModel> Get(int id)
        {
            return ClassDayRepo.Get(i => i.ID == id).ToList().Select(i => i.ToViewModel());
        }
        public IEnumerable<ClassDayViewModel> GetAll()
        {
            return ClassDayRepo.GetAll().ToList().Select(i => i.ToViewModel());
        }
        public ClassDay GetByID(int id)
        {
            return ClassDayRepo.GetByID(id);
        }
    }
}
