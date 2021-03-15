using System.Linq;
using LawFirmBusinessLogic.BindingModels;
using LawFirmBusinessLogic.Interfaces;
using LawFirmBusinessLogic.ViewModels;
using LawFirmListImplement.Models;
using System;
using System.Collections.Generic;

namespace LawFirmListImplement.Implements
{
    public class OrderStorage : IOrderStorage
    {
        private readonly DataListSingleton source;

        public OrderStorage()
        {
            source = DataListSingleton.GetInstance();
        }

        public List<OrderViewModel> GetFullList()
        {
            List<OrderViewModel> result = new List<OrderViewModel>();
            foreach (var component in source.Orders)
            {
                result.Add(CreateModel(component));
            }
            return result;
        }

        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            List<OrderViewModel> result = new List<OrderViewModel>();
            foreach (var order in source.Orders)
            {
                if (order.DocumentId.ToString().Contains(model.DocumentId.ToString()))
                {
                    result.Add(CreateModel(order));
                }
            }

            List<OrderViewModel> resultRep = new List<OrderViewModel>();
            foreach (var order in source.Orders)
            {
                if (order.DateCreate >= model.DateFrom && order.DateImplement <= model.DateTo)
                {
                    resultRep.Add(CreateModel(order));
                }
            }

            return result;
        }

        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            foreach (var component in source.Orders)
            {
                if (component.Id == model.Id || component.DocumentId ==
               model.DocumentId)
                {
                    return CreateModel(component);
                }
            }
            return null;
        }

        public void Insert(OrderBindingModel model)
        {
            Order tempComponent = new Order { Id = 1 };
            foreach (var component in source.Orders)
            {
                if (component.Id >= tempComponent.Id)
                {
                    tempComponent.Id = component.Id + 1;
                }
            }
            source.Orders.Add(CreateModel(model, tempComponent));
        }

        public void Update(OrderBindingModel model)
        {
            Order tempComponent = null;
            foreach (var component in source.Orders)
            {
                if (component.Id == model.Id)
                {
                    tempComponent = component;
                }
            }
            if (tempComponent == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, tempComponent);
        }

        public void Delete(OrderBindingModel model)
        {
            for (int i = 0; i < source.Components.Count; ++i)
            {
                if (source.Components[i].Id == model.Id.Value)
                {
                    source.Components.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Элемент не найден");
        }

        private Order CreateModel(OrderBindingModel model, Order component)
        {
            component.DocumentId = model.DocumentId;
            component.Count = model.Count;
            component.Sum = model.Sum;
            component.Status = model.Status;
            component.DateCreate = model.DateCreate;
            component.DateImplement = model.DateImplement;
            return component;
        }

        private OrderViewModel CreateModel(Order order)
        {
            string documentName = null;
            foreach (var document in source.Documents)
            {
                if (document.Id == order.DocumentId)
                {
                    documentName = document.DocumentName;
                }
            }
            return new OrderViewModel
            {
                Id = order.Id,
                DocumentId = order.DocumentId,
                Count = order.Count,
                Sum = order.Sum,
                DateCreate = order.DateCreate,
                Status = order.Status,
                DateImplement = order.DateImplement,
                DocumentName = documentName
            };
        }
    }
}
