using System;
using LawFirmBusinessLogic.BindingModels;
using LawFirmBusinessLogic.BusinessLogics;
using LawFirmBusinessLogic.ViewModels;
using System.Windows.Forms;
using Unity;

namespace LawFirmView
{
    public partial class FormCreateOrder : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly DocumentLogic _logicD;

        private readonly OrderLogic _logicO;

        private readonly ClientLogic _logicC;

        public FormCreateOrder(DocumentLogic logicD, OrderLogic logicO, ClientLogic logicC)
        {
            InitializeComponent();
            _logicD = logicD;
            _logicO = logicO;
            _logicC = logicC;
        }

        private void FormCreateOrder_Load(object sender, EventArgs e)
        {
            try
            {
                var listDocuments = _logicD.Read(null);
                foreach (var component in listDocuments)
                {
                    comboBoxDocument.DisplayMember = "DocumentName";
                    comboBoxDocument.ValueMember = "Id";
                    comboBoxDocument.DataSource = listDocuments;
                    comboBoxDocument.SelectedItem = null;
                }

                var listClients = _logicC.Read(null);
                foreach (var component in listClients)
                {
                    comboBoxClient.DisplayMember = "ClientFIO";
                    comboBoxClient.ValueMember = "Id";
                    comboBoxClient.DataSource = listClients;
                    comboBoxClient.SelectedItem = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void CalcSum()
        {
            if (comboBoxDocument.SelectedValue != null &&
            !string.IsNullOrEmpty(textBoxCount.Text))
            {
                try
                {
                    int id = Convert.ToInt32(comboBoxDocument.SelectedValue);
                    DocumentViewModel document = _logicD.Read(new DocumentBindingModel { Id = id })?[0];
                    int count = Convert.ToInt32(textBoxCount.Text);
                    textBoxSum.Text = (count * document?.Price ?? 0).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void TextBoxCount_TextChanged(object sender, EventArgs e)
        {
            CalcSum();
        }

        private void ComboBoxDocument_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSum();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCount.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxDocument.SelectedValue == null)
            {
                MessageBox.Show("Выберите документ", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            if (comboBoxClient.SelectedValue == null)
            {
                MessageBox.Show("Выберите клиента", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            try
            {
                _logicO.CreateOrder(new CreateOrderBindingModel
                {
                    ClientId = Convert.ToInt32(comboBoxClient.SelectedValue),
                    DocumentId = Convert.ToInt32(comboBoxDocument.SelectedValue),
                    Count = Convert.ToInt32(textBoxCount.Text),
                    Sum = Convert.ToDecimal(textBoxSum.Text)
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
