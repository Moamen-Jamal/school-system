using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public static class ClassRoomExtentions
    {
        public static ClassRoomViewModel ToViewModel(this ClassRoom Model)
        {
            return new ClassRoomViewModel()
            {
                ID = Model.ID,
                Name = Model.Name,
                SchoolID = Model.SchoolID,
                School = Model.School.ToViewModel(),
                ClassDays = Model.ClassDays.Select(i => i.ToViewModel())
            };
        }
        public static ClassRoomEditViewModel ToEditableViewModel(this ClassRoom Model)
        {
            return new ClassRoomEditViewModel()
            {
                ID = Model.ID,
                Name = Model.Name,
                SchoolID = Model.SchoolID
            };
        }
        public static ClassRoom ToModel(this ClassRoomEditViewModel EditModel)
        {
            return new ClassRoom()
            {
                ID = EditModel.ID,
                Name = EditModel.Name,
                SchoolID = EditModel.SchoolID
            };
        }
    }
}
