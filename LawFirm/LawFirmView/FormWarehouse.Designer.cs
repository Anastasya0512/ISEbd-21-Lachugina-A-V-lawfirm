namespace LawFirmView
{
    partial class FormWarehouse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxResponsible = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridBoxTextBoxColumnComponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResponsible = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(432, 463);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(296, 463);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 28);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // textBoxResponsible
            // 
            this.textBoxResponsible.Location = new System.Drawing.Point(202, 93);
            this.textBoxResponsible.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResponsible.Name = "textBoxResponsible";
            this.textBoxResponsible.Size = new System.Drawing.Size(229, 22);
            this.textBoxResponsible.TabIndex = 13;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxKey,
            this.DataGridBoxTextBoxColumnComponent,
            this.DataGridViewTextBoxColumnCount});
            this.dataGridView.Location = new System.Drawing.Point(61, 150);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(497, 287);
            this.dataGridView.TabIndex = 12;
            // 
            // DataGridViewTextBoxKey
            // 
            this.DataGridViewTextBoxKey.HeaderText = "";
            this.DataGridViewTextBoxKey.MinimumWidth = 6;
            this.DataGridViewTextBoxKey.Name = "DataGridViewTextBoxKey";
            this.DataGridViewTextBoxKey.Visible = false;
            this.DataGridViewTextBoxKey.Width = 125;
            // 
            // DataGridBoxTextBoxColumnComponent
            // 
            this.DataGridBoxTextBoxColumnComponent.HeaderText = "Компонент";
            this.DataGridBoxTextBoxColumnComponent.MinimumWidth = 6;
            this.DataGridBoxTextBoxColumnComponent.Name = "DataGridBoxTextBoxColumnComponent";
            this.DataGridBoxTextBoxColumnComponent.Width = 222;
            // 
            // DataGridViewTextBoxColumnCount
            // 
            this.DataGridViewTextBoxColumnCount.HeaderText = "Количество";
            this.DataGridViewTextBoxColumnCount.MinimumWidth = 6;
            this.DataGridViewTextBoxColumnCount.Name = "DataGridViewTextBoxColumnCount";
            this.DataGridViewTextBoxColumnCount.Width = 111;
            // 
            // labelResponsible
            // 
            this.labelResponsible.AutoSize = true;
            this.labelResponsible.Location = new System.Drawing.Point(61, 97);
            this.labelResponsible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResponsible.Name = "labelResponsible";
            this.labelResponsible.Size = new System.Drawing.Size(115, 17);
            this.labelResponsible.TabIndex = 11;
            this.labelResponsible.Text = "Ответственный:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(202, 44);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(229, 22);
            this.textBoxName.TabIndex = 10;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(61, 44);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(76, 17);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Название:";
            // 
            // FormWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 536);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxResponsible);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.labelResponsible);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "FormWarehouse";
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.FormWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxResponsible;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridBoxTextBoxColumnComponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnCount;
        private System.Windows.Forms.Label labelResponsible;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
    }
}