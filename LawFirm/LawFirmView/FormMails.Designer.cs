namespace LawFirmView
{
    partial class FormMails
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonPage2 = new System.Windows.Forms.Button();
            this.buttonPage4 = new System.Windows.Forms.Button();
            this.buttonPage5 = new System.Windows.Forms.Button();
            this.buttonPage3 = new System.Windows.Forms.Button();
            this.buttonPage1 = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(13, 13);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(814, 511);
            this.dataGridView.TabIndex = 1;
            // 
            // buttonPage2
            // 
            this.buttonPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPage2.Location = new System.Drawing.Point(313, 563);
            this.buttonPage2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPage2.Name = "buttonPage2";
            this.buttonPage2.Size = new System.Drawing.Size(61, 28);
            this.buttonPage2.TabIndex = 14;
            this.buttonPage2.Text = "2";
            this.buttonPage2.UseVisualStyleBackColor = false;
            this.buttonPage2.Click += new System.EventHandler(this.buttonPage_Click);
            // 
            // buttonPage4
            // 
            this.buttonPage4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPage4.Location = new System.Drawing.Point(481, 563);
            this.buttonPage4.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPage4.Name = "buttonPage4";
            this.buttonPage4.Size = new System.Drawing.Size(61, 28);
            this.buttonPage4.TabIndex = 13;
            this.buttonPage4.Text = "4";
            this.buttonPage4.UseVisualStyleBackColor = false;
            this.buttonPage4.Click += new System.EventHandler(this.buttonPage_Click);
            // 
            // buttonPage5
            // 
            this.buttonPage5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPage5.Location = new System.Drawing.Point(564, 563);
            this.buttonPage5.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPage5.Name = "buttonPage5";
            this.buttonPage5.Size = new System.Drawing.Size(61, 28);
            this.buttonPage5.TabIndex = 12;
            this.buttonPage5.Text = "5";
            this.buttonPage5.UseVisualStyleBackColor = false;
            this.buttonPage5.Click += new System.EventHandler(this.buttonPage_Click);
            // 
            // buttonPage3
            // 
            this.buttonPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPage3.Location = new System.Drawing.Point(396, 563);
            this.buttonPage3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPage3.Name = "buttonPage3";
            this.buttonPage3.Size = new System.Drawing.Size(61, 28);
            this.buttonPage3.TabIndex = 11;
            this.buttonPage3.Text = "3";
            this.buttonPage3.UseVisualStyleBackColor = false;
            this.buttonPage3.Click += new System.EventHandler(this.buttonPage_Click);
            // 
            // buttonPage1
            // 
            this.buttonPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPage1.Location = new System.Drawing.Point(228, 563);
            this.buttonPage1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPage1.Name = "buttonPage1";
            this.buttonPage1.Size = new System.Drawing.Size(61, 28);
            this.buttonPage1.TabIndex = 10;
            this.buttonPage1.Text = "1";
            this.buttonPage1.UseVisualStyleBackColor = false;
            this.buttonPage1.Click += new System.EventHandler(this.buttonPage_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(645, 563);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(100, 28);
            this.buttonNext.TabIndex = 9;
            this.buttonNext.Text = "Вперёд";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(93, 563);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(100, 28);
            this.buttonPrev.TabIndex = 8;
            this.buttonPrev.Text = "Назад";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // FormMails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 627);
            this.Controls.Add(this.buttonPage2);
            this.Controls.Add(this.buttonPage4);
            this.Controls.Add(this.buttonPage5);
            this.Controls.Add(this.buttonPage3);
            this.Controls.Add(this.buttonPage1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormMails";
            this.Text = "Письма";
            this.Load += new System.EventHandler(this.FormMails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonPage2;
        private System.Windows.Forms.Button buttonPage4;
        private System.Windows.Forms.Button buttonPage5;
        private System.Windows.Forms.Button buttonPage3;
        private System.Windows.Forms.Button buttonPage1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
    }
}