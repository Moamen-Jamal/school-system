using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public static class StudentExtensions
    {
        public static StudentViewModel ToViewModel(this Student Model)
        {
            return new StudentViewModel()
            {
                ID = Model.ID,
                Name = Model.Name,
                Email = Model.Email,
                Phone = Model.Phone,
                ClassID = Model.ClassID,
                ClassRoom = Model.ClassRoom.ToViewModel()

            };
        }
        public static StudentEditViewModel ToEditableViewModel(this Student Model)
        {
            return new StudentEditViewModel()
            {
                ID = Model.ID,
                Name = Model.Name,
                Email = Model.Email,
                Phone = Model.Phone,
                ClassID = Model.ClassID
            };
        }
        public static Student ToModel(this StudentEditViewModel EditModel)
        {
            return new Student()
            {
                ID = EditModel.ID,
                Name = EditModel.Name,
                Email = EditModel.Email,
                Phone = EditModel.Phone,
                ClassID = EditModel.ClassID
            };
        }

    }
}
