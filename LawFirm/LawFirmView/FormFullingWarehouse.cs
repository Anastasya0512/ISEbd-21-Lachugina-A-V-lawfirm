using System.Collections.Generic;
using LawFirmBusinessLogic.ViewModels;
using LawFirmBusinessLogic.BusinessLogics;
using System;
using LawFirmBusinessLogic.BindingModels;
using LawFirmFileImplement;
using LawFirmFileImplement.Implements;
using LawFirmFileImplement.Models;
using System.Windows.Forms;
using Unity;
using System.Linq;

namespace LawFirmView
{
    public partial class FormFullingWarehouse : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int ComponentId { get { return Convert.ToInt32(comboBoxComponent.SelectedValue); } set { comboBoxComponent.SelectedValue = value; } }
        public int WarehouseId { get { return Convert.ToInt32(comboBoxWarehouse.SelectedValue); } set { comboBoxWarehouse.SelectedValue = value; } }
        public int Count { get { return Convert.ToInt32(textBoxCount.Text); } set { textBoxCount.Text = value.ToString(); } }

        public string ComponentName { get { return comboBoxComponent.Text; } }

        WarehouseStorage _warehouseStorage;

        WarehouseBindingModel warehouseBindingModel = new WarehouseBindingModel();

        public FormFullingWarehouse(ComponentLogic componentlogic, WarehouseStorage warehouseStorage)
        {
            _warehouseStorage = warehouseStorage;
            InitializeComponent();
            List <ComponentViewModel> listComponent = componentlogic.Read(null);
            if (listComponent != null)
            {
                comboBoxComponent.DisplayMember = "ComponentName";
                comboBoxComponent.ValueMember = "Id";
                comboBoxComponent.DataSource = listComponent;
                comboBoxComponent.SelectedItem = null;
            }

            List<WarehouseViewModel> listWarehouse = _warehouseStorage.GetFullList();
            if (listWarehouse != null)
            {
                comboBoxWarehouse.DisplayMember = "WarehouseName";
                comboBoxWarehouse.ValueMember = "Id";
                comboBoxWarehouse.DataSource = listWarehouse;
                comboBoxWarehouse.SelectedItem = null;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCount.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxComponent.SelectedValue == null)
            {
                MessageBox.Show("Выберите компонент", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            if (comboBoxWarehouse.SelectedValue == null)
            {
                MessageBox.Show("Выберите склад", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            _warehouseStorage.Restocking(warehouseBindingModel, WarehouseId, ComponentId, Count, ComponentName);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
