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
    public delegate void EventDelegate();

    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("Имя", typeof(string));
            table.Columns.Add("Фамилия", typeof(string));
            table.Columns.Add("Дата рождения", typeof(string));
            table.Columns.Add("Пол", typeof(string));
            for (int i = 0; i < ListPactient.Pactients.Count(); i++)
            {
                if (ListPactient.Pactients[i].Sex)
                {
                    table.Rows.Add(ListPactient.Pactients[i].Id, ListPactient.Pactients[i].Name, ListPactient.Pactients[i].SecondName, ListPactient.Pactients[i].DateofBirth, "муж");
                }
                else 
                {
                    table.Rows.Add(ListPactient.Pactients[i].Id, ListPactient.Pactients[i].Name, ListPactient.Pactients[i].SecondName, ListPactient.Pactients[i].DateofBirth, "жен");
                }
            }
           Datapatient.DataSource = table;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TextBoxwithNameandSecondName.Enabled = false;
            TextBoxwithNameandSecondName.Visible = false;
            TextBoxwithSex.Visible = false;
            TextBoxwithSex.Enabled = false;
            textBoxwithDateofBirth.Visible = false;
            textBoxwithDateofBirth.Enabled = false;
            panel2.Visible = false;
            Infomartionbutton.Enabled = false;
            Infomartionbutton.Visible = false;






            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("Имя", typeof(string));
            table.Columns.Add("Фамилия", typeof(string));
            table.Columns.Add("Дата рождения", typeof(string));
            table.Columns.Add("Пол", typeof(string));
            for (int i = 0; i < ListPactient.Pactients.Count(); i++)
            {
                if (ListPactient.Pactients[i].Sex)
                {
                    table.Rows.Add(ListPactient.Pactients[i].Id, ListPactient.Pactients[i].Name, ListPactient.Pactients[i].SecondName, ListPactient.Pactients[i].DateofBirth, "муж");
                }
                else 
                {
                    table.Rows.Add(ListPactient.Pactients[i].Id, ListPactient.Pactients[i].Name, ListPactient.Pactients[i].SecondName, ListPactient.Pactients[i].DateofBirth, "жен");
                }
            }
            Datapatient.DataSource = table;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Datapatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OpenForm_CreatePatient(object sender, EventArgs e)
        {
           
            Hide();
            new CreatePatienForm().ShowDialog();
            Show();
            this.AddRow();
        }
        
        public void AddRow()
        {
            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("Имя", typeof(string));
            table.Columns.Add("Фамилия", typeof(string));
            table.Columns.Add("Дата рождения", typeof(string));
            table.Columns.Add("Пол", typeof(string));
            for (int i = 0; i < ListPactient.Pactients.Count(); i++)
            {
                if (ListPactient.Pactients[i].Sex)
                {
                    table.Rows.Add(ListPactient.Pactients[i].Id, ListPactient.Pactients[i].Name, ListPactient.Pactients[i].SecondName, ListPactient.Pactients[i].DateofBirth, "муж");
                }
                else
                {
                    table.Rows.Add(ListPactient.Pactients[i].Id, ListPactient.Pactients[i].Name, ListPactient.Pactients[i].SecondName, ListPactient.Pactients[i].DateofBirth, "жен");
                }
            }
            Datapatient.DataSource = table;
        }

        private void Datapatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id =(int)Datapatient.Rows[e.RowIndex].Cells[0].Value;
                TextBoxwithNameandSecondName.Enabled = true ;
                TextBoxwithNameandSecondName.Visible = true;
                TextBoxwithSex.Visible = true;
                TextBoxwithSex.Enabled = true;
                textBoxwithDateofBirth.Visible = true;
                textBoxwithDateofBirth.Enabled = true;
                panel2.Visible = true;
                Infomartionbutton.Enabled = true ;
                Infomartionbutton.Visible = true ;
                for (int i = 0; i < ListPactient.Pactients.Count(); i++)
                {
                    if (ListPactient.Pactients[i].Id == id)
                    {
                        ListPactient.ActiveId = i;
                        PanelforPantientPhoto.BackgroundImage = Image.FromFile(ListPactient.Pactients[i].PathPhoto);
                        TextBoxwithNameandSecondName.Text = ListPactient.Pactients[i].Name + " " + ListPactient.Pactients[i].SecondName;
                        TextBoxwithSex.Text= (string)Datapatient.Rows[e.RowIndex].Cells[4].Value;
                        textBoxwithDateofBirth.Text = ListPactient.Pactients[i].DateofBirth;
                    }
                }
            }
            catch
            {

            }


        }

        private void Infomartionbutton_Click(object sender, EventArgs e)
        {
            Hide();
            new InfromationaboutPatientform().ShowDialog();
            Show();
            this.AddRow();
        }
    }
}
