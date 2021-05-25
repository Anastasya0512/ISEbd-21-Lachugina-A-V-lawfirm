﻿using Microsoft.Reporting.WebForms;
using LawFirmBusinessLogic.BindingModels;
using LawFirmBusinessLogic.ViewModels;
using LawFirmBusinessLogic.BusinessLogics;
using System;
using System.Windows.Forms;
using Unity;
using System.Collections.Generic;
namespace LawFirmView
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly OrderLogic _orderLogic;
        private readonly ReportLogic _reportLogic;
        private readonly WorkModeling workModeling;
        private BackUpAbstractLogic _backUpAbstractLogic;
        public FormMain(OrderLogic orderLogic, ReportLogic reportLogic, WorkModeling modeling, BackUpAbstractLogic backUp)
        {
            InitializeComponent();
            this._orderLogic = orderLogic;
            this._reportLogic = reportLogic;
            workModeling = modeling;
            _backUpAbstractLogic = backUp;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                Program.ConfigGrid(_orderLogic.Read(null), dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void компонентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormComponents>();
            form.ShowDialog();
        }

        private void документыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormDocuments>();
            form.ShowDialog();
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCreateOrder>();
            form.ShowDialog();
            LoadData();
        }

        private void buttonPayOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                try
                {
                    _orderLogic.PayOrder(new ChangeStatusBindingModel { OrderId = id });
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void документыПоКомпонентамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormReportComponentDocument>();
            form.ShowDialog();
        }

        private void списокДокументовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _reportLogic.SaveDocumentsToWordFile(new ReportBindingModel
                    {
                        FileName = dialog.FileName
                    });
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
        }

        private void списокЗаказовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormClientOrders>();
            form.ShowDialog();
        }

        private void складыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormWarehouses>();
            form.ShowDialog();
        }

        private void пополнениеСкладаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormFullingWarehouse>();
            form.ShowDialog();
        }

        private void списокСкладовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _reportLogic.SaveWarehousesToWordFile(new ReportBindingModel
                    {
                        FileName = dialog.FileName
                    });

                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void компонентыНаСкладахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormReportWarehouseComponents>();
            form.ShowDialog();
        }

        private void списокЗаказовЗаВесьПериодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormReportOrdersAll>();
            form.ShowDialog();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormClients>();
            form.ShowDialog();
        }

        private void запускРаботToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workModeling.DoWork();
            LoadData();
        }

        private void исполнителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormImplementers>();
            form.ShowDialog();
        }

        private void письмаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormMails>();
            form.ShowDialog();
        }

        private void создатьБэкапToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_backUpAbstractLogic != null)
                {
                    var fbd = new FolderBrowserDialog();
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        _backUpAbstractLogic.CreateArchive(fbd.SelectedPath);
                        MessageBox.Show("Бекап создан", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
