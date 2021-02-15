using AbstractLawFirmLogic.BindingModels;
using AbstractLawFirmLogic.ViewModels;
using System.Collections.Generic;

namespace AbstractLawFirmLogic.Interfaces
{
    public interface IDocumentStorage
    {
        List<DocumentViewModel> GetFullList();
        List<DocumentViewModel> GetFilteredList(DocumentBindingModel model);
        DocumentViewModel GetElement(DocumentBindingModel model);
        void Insert(DocumentBindingModel model);
        void Update(DocumentBindingModel model);
        void Delete(DocumentBindingModel model);
    }
}
