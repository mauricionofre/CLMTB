using CLMTB.ApplicationLayer.DTO;
using CLMTB.ApplicationLayer.Services.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLMTB.Presentation.WinForm.Controls.StageForm
{
    public partial class StageControl : UserControl
    {
        private IStageService _service;

        public StageControl()
        {
            InitializeComponent();
        }

        public StageControl(IStageService service)
            : this()
        {
            _service = service;
        }

        public void RefreshGrid()
        {
            gvStages.DataSource = _service.GetAll();
            gvStages.Refresh();
        }

        public StageDTO GetStage()
        {
            if (gvStages.SelectedCells.Count > 0)
            {
                var rowIndex = gvStages.SelectedCells[0].RowIndex;
                return gvStages.Rows[rowIndex].DataBoundItem as StageDTO;
            }
            return null;
        }
    }
}