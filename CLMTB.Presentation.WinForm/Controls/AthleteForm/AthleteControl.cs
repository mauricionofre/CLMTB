using CLMTB.ApplicationLayer.DTO;
using CLMTB.ApplicationLayer.Services.Entites;
using CLMTB.Domain.Entities;
using CLMTB.Presentation.WinForm.Controls.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLMTB.Presentation.WinForm.Controls.AthleteForm
{
    public partial class AthleteControl : UserControl
    {
        private IAthleteService _service;

        public AthleteControl()
        {
            InitializeComponent();
        }

        public AthleteControl(IAthleteService service)
            : this()
        {
            _service = service;
        }

        public void RefreshGrid()
        {
            gvAthletes.DataSource = _service.GetAll();
            gvAthletes.Refresh();
        }

        public AthleteDTO GetAthlete()
        {
            if (gvAthletes.SelectedCells.Count > 0)
            {
                var rowIndex = gvAthletes.SelectedCells[0].RowIndex;
                return gvAthletes.Rows[rowIndex].DataBoundItem as AthleteDTO;
            }
            return null;
        }
    }
}