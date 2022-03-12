
namespace MedicalForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Datapatient = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TextBoxwithSex = new System.Windows.Forms.TextBox();
            this.TextBoxwithNameandSecondName = new System.Windows.Forms.TextBox();
            this.textBoxwithDateofBirth = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Infomartionbutton = new System.Windows.Forms.Button();
            this.PanelforPantientPhoto = new System.Windows.Forms.Panel();
            this.CreateNewPatientButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datapatient)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Datapatient);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.Infomartionbutton);
            this.splitContainer1.Panel2.Controls.Add(this.PanelforPantientPhoto);
            this.splitContainer1.Panel2.Controls.Add(this.CreateNewPatientButton);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1213, 687);
            this.splitContainer1.SplitterDistance = 662;
            this.splitContainer1.TabIndex = 0;
            // 
            // Datapatient
            // 
            this.Datapatient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(141)))));
            this.Datapatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datapatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Datapatient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(141)))));
            this.Datapatient.Location = new System.Drawing.Point(0, 0);
            this.Datapatient.Name = "Datapatient";
            this.Datapatient.ReadOnly = true;
            this.Datapatient.Size = new System.Drawing.Size(662, 687);
            this.Datapatient.TabIndex = 0;
            this.Datapatient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datapatient_CellClick);
            this.Datapatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datapatient_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.TextBoxwithSex);
            this.panel3.Controls.Add(this.TextBoxwithNameandSecondName);
            this.panel3.Controls.Add(this.textBoxwithDateofBirth);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(236, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 335);
            this.panel3.TabIndex = 7;
            // 
            // TextBoxwithSex
            // 
            this.TextBoxwithSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxwithSex.Location = new System.Drawing.Point(59, 207);
            this.TextBoxwithSex.Name = "TextBoxwithSex";
            this.TextBoxwithSex.ReadOnly = true;
            this.TextBoxwithSex.Size = new System.Drawing.Size(87, 31);
            this.TextBoxwithSex.TabIndex = 3;
            this.TextBoxwithSex.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TextBoxwithNameandSecondName
            // 
            this.TextBoxwithNameandSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxwithNameandSecondName.Location = new System.Drawing.Point(59, 119);
            this.TextBoxwithNameandSecondName.Name = "TextBoxwithNameandSecondName";
            this.TextBoxwithNameandSecondName.ReadOnly = true;
            this.TextBoxwithNameandSecondName.Size = new System.Drawing.Size(203, 31);
            this.TextBoxwithNameandSecondName.TabIndex = 2;
            this.TextBoxwithNameandSecondName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxwithDateofBirth
            // 
            this.textBoxwithDateofBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxwithDateofBirth.Location = new System.Drawing.Point(173, 207);
            this.textBoxwithDateofBirth.Name = "textBoxwithDateofBirth";
            this.textBoxwithDateofBirth.ReadOnly = true;
            this.textBoxwithDateofBirth.Size = new System.Drawing.Size(89, 31);
            this.textBoxwithDateofBirth.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(157, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 51);
            this.panel2.TabIndex = 5;
            // 
            // Infomartionbutton
            // 
            this.Infomartionbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Infomartionbutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Infomartionbutton.Location = new System.Drawing.Point(0, 396);
            this.Infomartionbutton.Name = "Infomartionbutton";
            this.Infomartionbutton.Size = new System.Drawing.Size(547, 291);
            this.Infomartionbutton.TabIndex = 6;
            this.Infomartionbutton.Text = "Информация";
            this.Infomartionbutton.UseVisualStyleBackColor = false;
            this.Infomartionbutton.Click += new System.EventHandler(this.Infomartionbutton_Click);
            // 
            // PanelforPantientPhoto
            // 
            this.PanelforPantientPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelforPantientPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelforPantientPhoto.Location = new System.Drawing.Point(31, 112);
            this.PanelforPantientPhoto.Name = "PanelforPantientPhoto";
            this.PanelforPantientPhoto.Size = new System.Drawing.Size(186, 224);
            this.PanelforPantientPhoto.TabIndex = 1;
            this.PanelforPantientPhoto.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CreateNewPatientButton
            // 
            this.CreateNewPatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CreateNewPatientButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateNewPatientButton.Location = new System.Drawing.Point(0, 0);
            this.CreateNewPatientButton.Name = "CreateNewPatientButton";
            this.CreateNewPatientButton.Size = new System.Drawing.Size(547, 61);
            this.CreateNewPatientButton.TabIndex = 0;
            this.CreateNewPatientButton.Text = "Добавить Нового";
            this.CreateNewPatientButton.UseVisualStyleBackColor = false;
            this.CreateNewPatientButton.Click += new System.EventHandler(this.OpenForm_CreatePatient);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 687);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Таблица пациентов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Datapatient)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Datapatient;
        private System.Windows.Forms.Button CreateNewPatientButton;
        private System.Windows.Forms.Panel PanelforPantientPhoto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxwithDateofBirth;
        private System.Windows.Forms.TextBox TextBoxwithSex;
        private System.Windows.Forms.TextBox TextBoxwithNameandSecondName;
        private System.Windows.Forms.Button Infomartionbutton;
        private System.Windows.Forms.Panel panel3;
    }
}

