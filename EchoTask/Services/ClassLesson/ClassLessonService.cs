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
    public class ClassLessonService
    {
        UnitOfWork unitOfWork;
        Generic<ClassLesson> ClassLessonRepo;
        public ClassLessonService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            ClassLessonRepo = unitOfWork.ClassLessonRepo;
        }
        public ClassLessonEditViewModel Add(ClassLessonEditViewModel ClassLessonEditViewModel)
        {
            ClassLesson ClassLesson = ClassLessonRepo.Add(ClassLessonEditViewModel.ToModel());
            unitOfWork.commit();
            return ClassLesson.ToEditableViewModel();
        }
        public ClassLessonEditViewModel Update(ClassLessonEditViewModel ClassLessonEditViewModel)
        {
            ClassLesson ClassLesson = ClassLessonRepo.Update(ClassLessonEditViewModel.ToModel());
            unitOfWork.commit();
            return ClassLesson.ToEditableViewModel();
        }
        public void Remove(int id)
        {
            ClassLessonRepo.Remove(ClassLessonRepo.GetByID(id));
            unitOfWork.commit();
        }
        public IEnumerable<ClassLessonViewModel> Get(int id)
        {
            return ClassLessonRepo.Get(i => i.ID == id).ToList().Select(i => i.ToViewModel());
        }
        public IEnumerable<ClassLessonViewModel> GetAll()
        {
            return ClassLessonRepo.GetAll().ToList().Select(i => i.ToViewModel());
        }
        public ClassLessonViewModel GetByID(int id)
        {
            return ClassLessonRepo.GetByID(id).ToViewModel();
        }
    }
}
