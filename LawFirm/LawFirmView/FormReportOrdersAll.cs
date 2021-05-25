﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using LawFirmBusinessLogic.BindingModels;
using LawFirmBusinessLogic.BusinessLogics;
using Unity;
using LawFirmBusinessLogic.ViewModels;
using System.Reflection;

namespace LawFirmView
{
    public partial class FormReportOrdersAll : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ReportLogic logic;

        public FormReportOrdersAll(ReportLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void buttonMake_Click(object sender, EventArgs e)
        {
            try
            {
                MethodInfo method = logic.GetType().GetMethod("GetOrdersGroupByDate");
                List<ReportOrdersViewModel> dataSource = (List<ReportOrdersViewModel>)method.Invoke(logic, new object[] { });
                ReportDataSource source = new ReportDataSource("DataSetOrders",
                dataSource);
                reportViewer.LocalReport.DataSources.Add(source);
                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonToPdf_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        logic.SaveOrdersAllDatesToPdfFile(new ReportBindingModel
                        {
                            FileName = dialog.FileName
                        });

                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    }
                }
            }
        }
    }
}
