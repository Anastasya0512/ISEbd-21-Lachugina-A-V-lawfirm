using System;
using System.Collections.Generic;
using LawFirmBusinessLogic.BindingModels;
using LawFirmBusinessLogic.ViewModels;
using System.Text;

namespace LawFirmBusinessLogic.Interfaces
{
    public interface IWarehouseStorage
    {
        List<WarehouseViewModel> GetFullList();

        List<WarehouseViewModel> GetFilteredList(WarehouseBindingModel model);

        WarehouseViewModel GetElement(WarehouseBindingModel model);      

        void Insert(WarehouseBindingModel model);

        void Update(WarehouseBindingModel model);

        void Delete(WarehouseBindingModel model);
        bool WriteOff(int DocumentId, int DocumentCount);
    }
}
