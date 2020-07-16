using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public static class ClassDayExtentions
    {
        public static ClassDayViewModel ToViewModel(this ClassDay Model)
        {
            return new ClassDayViewModel()
            {
                ID = Model.ID,
                
                ClassRoomID = Model.ClassRoomID,
                ClassRoom = Model.ClassRoom.ToViewModel(),
                DayID = Model.DayID,
                Day = Model.Day.ToViewModel(),
                ClassLessons = Model.ClassLessons.Select(i => i.ToViewModel())
            };
        }
        public static ClassDayEditViewModel ToEditableViewModel(this ClassDay Model)
        {
            return new ClassDayEditViewModel()
            {
                ID = Model.ID,
               
                ClassRoomID = Model.ClassRoomID,
                DayID = Model.DayID,

            };
        }
        public static ClassDay ToModel(this ClassDayEditViewModel EditModel)
        {
            return new ClassDay()
            {
                ID = EditModel.ID,
               
                ClassRoomID = EditModel.ClassRoomID,
                DayID = EditModel.DayID,
            };
        }
    }
}
