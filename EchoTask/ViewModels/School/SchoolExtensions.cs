using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public static class SchoolExtensions
    {
        public static SchoolViewModel ToViewModel(this School Model)
        {
            return new SchoolViewModel()
            {
                ID = Model.ID,
                Name = Model.Name
            };
        }
        public static School ToModel(this SchoolEditViewModel EditModel)
        {
            return new School()
            {
                ID = EditModel.ID,
                Name = EditModel.Name
            };
        }
        public static SchoolEditViewModel ToEditableViewModel(this School Model)
        {
            return new SchoolEditViewModel()
            {
                ID = Model.ID,
                Name = Model.Name
            };
        }
    }
}
