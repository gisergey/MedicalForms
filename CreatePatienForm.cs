using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalForms
{
   

    public partial class CreatePatienForm : Form
    {

        bool IsChoosePhoto = false;
        public CreatePatienForm()
        {
            InitializeComponent();
            SetNameTextBox.Text = "Введите имя";
            SetSecondNameTextBox.Text = "Введите фамилию";
            TextBoxwithDiagnosis.Text = "Диагноз";
            TextBoxWithHisory.Text = "История болезни";
            IsChoosePhoto = false;



        }

        private void Create_new_Pactient(object sender, EventArgs e)
        {

            if (!IsChoosePhoto)
            {
                MessageBox.Show("Вы не выбрали фото");
            }
            else
            {
                ListPactient.Pactients.Add(new Pactient(SetNameTextBox.Text, SetSecondNameTextBox.Text, DateofBirthPicker.Value, ManRadiobutton.Checked, TextBoxwithDiagnosis.Text, TextBoxWithHisory.Text, OpenPhotoDialog.FileName));
                
                Close();
                
               
            }
       
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreatePatienForm_Load(object sender, EventArgs e)
        {
            

        }

        private void Daycombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Choosephotobutton_Click(object sender, EventArgs e)
        {
            OpenPhotoDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIG;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            


            if (OpenPhotoDialog.ShowDialog() == DialogResult.OK)
            {
                IsChoosePhoto = true;
            }
            else
            {
                MessageBox.Show("Вы не выбрали фото");
            }

        }

    }
}
