using CLMTB.ApplicationLayer.Services.Entites;
using CLMTB.Domain.Entities;
using CLMTB.Presentation.WinForm.Controls.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLMTB.Presentation.WinForm.Controls.AthleteForm
{
    public partial class AthleteControl : UserControl
    {
        private IAthleteService _service;

        private Athlete _athlete;

        public AthleteControl()
        {
            InitializeComponent();
            cbBloodGroup.DataSource = EnumHelper.GetEnumDescriptions(typeof(BloodGroupEnum));
        }

        public Athlete Athlete
        {
            get { return _athlete; }
            set
            {
                _athlete = value;
                txtName.Text = _athlete.Name;
                txtIdentifier.Text = _athlete.CPF;
                txtRG.Text = _athlete.RG;
                txtBirthDate.Text = _athlete.BirthDate.ToString("dd/MM/yyyy");
                txtFone.Text = _athlete.Fone;
                txtCity.Text = _athlete.Address.City;
                txtNeighborhood.Text = _athlete.Address.Neighborhood;
                txtNumber.Text = _athlete.Address.Number.ToString();
                txtState.Text = _athlete.Address.UF;
            }
        }

        public AthleteControl(IAthleteService service)
            : this()
        {
            _service = service;
        }

        public void RefreshGrid()
        {
            _service.GetAll();

            gvAthletes.DataSource = _service.GetAll();
            gvAthletes.Refresh();
        }

        public Athlete GetAthlete()
        {
            if (gvAthletes.SelectedCells.Count > 0)
            {
                var rowIndex = gvAthletes.SelectedCells[0].RowIndex;
                return gvAthletes.Rows[rowIndex].DataBoundItem as Athlete;
            }
            return null;
        }

        private void gvAthletes_SelectionChanged(object sender, EventArgs e)
        {
            Athlete athlete = GetAthlete();
            if (athlete != null)
                this.Athlete = athlete;
        }
    }
}