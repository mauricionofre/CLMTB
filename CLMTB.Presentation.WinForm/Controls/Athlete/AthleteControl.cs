using CLMTB.ApplicationLayer.Services.Entites;
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

namespace CLMTB.Presentation.WinForm.Controls.Athlete
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
            _service.GetAll();

            gvAthletes.DataSource = _service.GetAll();
            gvAthletes.Refresh();
        }
    }
}