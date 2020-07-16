using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ViewModels
{
    public static class AdminExtensions
    {
        public static AdminEditViewModel ToEditableViewModel(this Admin model)
        {
            return new AdminEditViewModel
            {
                ID = model.ID,
                UserName = model.UserName,
                Password = model.Password,
            };
        }
        public static Admin ToModel(this AdminEditViewModel EditModel)
        {
            return new Admin()
            {
                ID = EditModel.ID,
                UserName = EditModel.UserName,
                Password = EditModel.Password,
            };
        }
        public static AdminViewModel ToViewModel(this Admin Model)
        {
            return new AdminViewModel()
            {
                ID = Model.ID,
                UserName = Model.UserName,
                Password = Model.Password,
            };
        }
    }
}
