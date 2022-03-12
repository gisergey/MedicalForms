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
    public partial class InfromationaboutPatientform : Form
    {
        public InfromationaboutPatientform()
        {
            InitializeComponent();
        }

        private void InfromationaboutPatientform_Load(object sender, EventArgs e)
        {
            NameInformationTextbox.Text = ListPactient.Pactients[ListPactient.ActiveId].Name;
            SeconNameInformationTextBox.Text = ListPactient.Pactients[ListPactient.ActiveId].SecondName;
            diagnoziinformationbox.Text = ListPactient.Pactients[ListPactient.ActiveId].Information;
            Historyinformationtextbox.Text = ListPactient.Pactients[ListPactient.ActiveId].History;
            PIcureBoxwithinformationphoto.BackgroundImage = Image.FromFile(ListPactient.Pactients[ListPactient.ActiveId].PathPhoto);
        }
    }
}
