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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idComponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResponseble = new System.Windows.Forms.Label();
            this.textBoxResponsible = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(646, 543);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(127, 42);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(508, 543);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(117, 42);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idComponent,
            this.component,
            this.Count});
            this.dataGridView.Location = new System.Drawing.Point(98, 138);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(623, 386);
            this.dataGridView.TabIndex = 12;
            // 
            // idComponent
            // 
            this.idComponent.HeaderText = "idComponent";
            this.idComponent.MinimumWidth = 6;
            this.idComponent.Name = "idComponent";
            this.idComponent.ReadOnly = true;
            this.idComponent.Visible = false;
            this.idComponent.Width = 125;
            // 
            // component
            // 
            this.component.HeaderText = "Компонент";
            this.component.MinimumWidth = 6;
            this.component.Name = "component";
            this.component.ReadOnly = true;
            this.component.Width = 300;
            // 
            // Count
            // 
            this.Count.HeaderText = "Количество";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 150;
            // 
            // labelResponseble
            // 
            this.labelResponseble.AutoSize = true;
            this.labelResponseble.Location = new System.Drawing.Point(64, 77);
            this.labelResponseble.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResponseble.Name = "labelResponseble";
            this.labelResponseble.Size = new System.Drawing.Size(153, 17);
            this.labelResponseble.TabIndex = 11;
            this.labelResponseble.Text = "ФИО ответственного:";
            // 
            // textBoxResponsible
            // 
            this.textBoxResponsible.Location = new System.Drawing.Point(225, 72);
            this.textBoxResponsible.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResponsible.Name = "textBoxResponsible";
            this.textBoxResponsible.Size = new System.Drawing.Size(385, 22);
            this.textBoxResponsible.TabIndex = 10;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(225, 27);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(385, 22);
            this.textBoxName.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(141, 32);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(76, 17);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Название:";
            // 
            // FormWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 647);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.labelResponseble);
            this.Controls.Add(this.textBoxResponsible);
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
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn component;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.Label labelResponseble;
        private System.Windows.Forms.TextBox textBoxResponsible;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
    }
}