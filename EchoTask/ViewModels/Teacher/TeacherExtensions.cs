using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public static class TeacherExtensions
    {
        
            public static TeacherViewModel ToViewModel(this Teacher Model)
            {
                return new TeacherViewModel()
                {
                    ID = Model.ID,
                    Name = Model.Name,
                    Email = Model.Email,
                    Phone = Model.Phone,
                    
                };
            }
            public static TeacherEditViewModel ToEditableViewModel(this Teacher Model)
            {
                return new TeacherEditViewModel()
                {
                    ID = Model.ID,
                    Name = Model.Name,
                    Email = Model.Email,
                    Phone = Model.Phone,
                   
                };
            }
            public static Teacher ToModel(this TeacherEditViewModel EditModel)
            {
                return new Teacher()
                {
                    ID = EditModel.ID,
                    Name = EditModel.Name,
                    Email = EditModel.Email,
                    Phone = EditModel.Phone,
                };
            }
        
    }
}
