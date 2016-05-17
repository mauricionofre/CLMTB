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
        }

        public StageDTO Stage { get; set; }
    }
}