using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LawFirmBusinessLogic.BindingModels;
using LawFirmBusinessLogic.BusinessLogics;
using LawFirmBusinessLogic.ViewModels;
using System.Reflection;

namespace LawFirmView
{
    public partial class FormReportWarehouseComponents : Form
    {

        private readonly ReportLogic logic;
        public FormReportWarehouseComponents(ReportLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void buttonSaveToExcel_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog { Filter = "xlsx|*.xlsx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        MethodInfo method = logic.GetType().GetMethod("SaveWarehouseComponentToExcelFile");
                        method.Invoke(logic, new object[] { new ReportBindingModel
                        {
                            FileName = dialog.FileName
                        } });
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FormReportWarehouseComponents_Load(object sender, EventArgs e)
        {
            try
            {
                MethodInfo method = logic.GetType().GetMethod("GetWarehouseComponent");
                List<ReportWarehouseComponentViewModel> dict = (List<ReportWarehouseComponentViewModel>)
                    method.Invoke(logic, new object[] { });
                if (dict != null)
                {
                    DataGridView.Rows.Clear();
                    foreach (var elem in dict)
                    {
                        DataGridView.Rows.Add(new object[] { elem.WarehouseName, "", "" });
                        foreach (var listElem in elem.Components)
                        {
                            DataGridView.Rows.Add(new object[] { "", listElem.Item1, listElem.Item2 });
                        }
                        DataGridView.Rows.Add(new object[] { "Итого", "", elem.TotalCount });
                        DataGridView.Rows.Add(new object[] { });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
