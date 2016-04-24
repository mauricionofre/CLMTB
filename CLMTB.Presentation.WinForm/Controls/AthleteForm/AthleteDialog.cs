using CLMTB.ApplicationLayer.DTO;
using CLMTB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLMTB.Presentation.WinForm.Controls.AthleteForm
{
    public partial class AthleteDialog : Form
    {
        public AthleteDialog()
        {
            InitializeComponent();
            cbBloodGroup.DataSource = EnumHelper.GetEnumDescriptions(typeof(BloodGroupEnum));
        }

        private AthleteDTO _athlete;

        public AthleteDTO Athlete
        {
            get { return _athlete; }
            set
            {
                _athlete = value;

                txtId.Text = _athlete.Id.ToString();
                txtName.Text = _athlete.Name;
                txtCPF.Text = _athlete.CPF;
                txtRG.Text = _athlete.RG;
                txtBirthDate.Text = _athlete.BirthDate.ToString("dd/MM/yyyy");
                txtAge.Text = MathAge(_athlete.BirthDate).ToString();

                cbBloodGroup.SelectedItem = EnumHelper.GetEnumDescription(_athlete.BloodType);

                if (_athlete.Gender == null)
                    rbMale.Checked = true;
                else
                    rbMale.Checked = _athlete.Gender.Equals("M");

                txtEmail.Text = _athlete.Email;
                txtFone.Text = _athlete.Fone;

                txtStreet.Text = _athlete.Street;
                txtNumber.Text = _athlete.Number;
                txtNeighborhood.Text = _athlete.Neighborhood;
                txtCity.Text = _athlete.City;
                txtState.Text = _athlete.State;
            }
        }

        private int MathAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            if (birthDate > today.AddYears(-age))
                age--;

            if (age == -1)
                age = 0;

            return age;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Athlete.Id = Convert.ToInt32(txtId.Text);
            Athlete.Name = txtName.Text;
            Athlete.CPF = txtCPF.TextNoFormatting();
            Athlete.RG = txtRG.Text;

            Athlete.BirthDate = DateTime.Parse(txtBirthDate.Text);
            Athlete.Gender = rbMale.Checked ? "M" : "F";
            Athlete.BloodType = EnumHelper.GetEnumFromDescription<BloodGroupEnum>(cbBloodGroup.Text);
            Athlete.Email = txtEmail.Text;
            Athlete.Fone = txtFone.Text;

            Athlete.Street = txtStreet.Text;
            Athlete.Neighborhood = txtNeighborhood.Text;
            Athlete.Number = txtNumber.Text;
            Athlete.City = txtCity.Text;
            Athlete.State = txtState.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBirthDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime dt;
            DateTime.TryParse(txtBirthDate.Text, out dt);
            txtAge.Text = MathAge(dt).ToString();
            txtBirthDate.Text = dt.ToString("dd/MM/yyyy");
        }

        private void txtBirthDate_Enter(object sender, EventArgs e)
        {
            txtBirthDate.SelectAll();
        }
    }
}