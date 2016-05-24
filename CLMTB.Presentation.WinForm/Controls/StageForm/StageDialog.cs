using CLMTB.ApplicationLayer.DTO;
using CLMTB.Domain.Entities;
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
    public partial class StageDialog : Form
    {
        public StageDialog()
        {
            InitializeComponent();

            cbStageType.DataSource = EnumHelper.GetEnumDescriptions(typeof(StageTypeEnum));
        }

        private StageDTO _stage;

        public StageDTO Stage
        {
            get { return _stage; }
            set
            {
                _stage = value;

                txtId.Text = _stage.Id.ToString();
                txtName.Text = _stage.Name;
                txtSequential.Text = _stage.Sequential.ToString();
                cbStageType.SelectedItem = EnumHelper.GetEnumDescription(_stage.StageType);
                dpInitialDate.Value = _stage.InitialDate;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Stage.Id = Convert.ToInt32(txtId.Text);
            Stage.Name = txtName.Text;
            Stage.Sequential = Convert.ToInt32(txtSequential.Text);
            Stage.StageType = EnumHelper.GetEnumFromDescription<StageTypeEnum>(cbStageType.SelectedItem.ToString());
            Stage.InitialDate = dpInitialDate.Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}