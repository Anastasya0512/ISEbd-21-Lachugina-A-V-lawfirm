using LawFirmBusinessLogic.BindingModels;
using LawFirmBusinessLogic.Enums;
using LawFirmBusinessLogic.Interfaces;
using LawFirmBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;

namespace LawFirmBusinessLogic.BusinessLogics
{
    public class WarehouseLogic
    {
        private readonly IWarehouseStorage _warehouseStorage;

        public WarehouseLogic(IWarehouseStorage warehouseStorage)
        {
            _warehouseStorage = warehouseStorage;
        }

        public List<WarehouseViewModel> Read(WarehouseBindingModel model)
        {
            if (model == null)
            {
                return _warehouseStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<WarehouseViewModel> { _warehouseStorage.GetElement(model) };
            }
            return _warehouseStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(WarehouseBindingModel model)
        {
            var element = _warehouseStorage.GetElement(new WarehouseBindingModel
            {
                WarehouseName = model.WarehouseName
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть склад с таким названием");
            }
            if (model.Id.HasValue)
            {
                _warehouseStorage.Update(model);
            }
            else
            {
                _warehouseStorage.Insert(model);
            }
        }

        public void Delete(WarehouseBindingModel model)
        {
            var element = _warehouseStorage.GetElement(new WarehouseBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _warehouseStorage.Delete(model);
        }
    }
}
