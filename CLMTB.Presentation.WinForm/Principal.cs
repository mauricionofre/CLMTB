using CLMTB.Presentation.WinForm.Controls.AthleteForm;
using CLMTB.Presentation.WinForm.Controls.Shared;
using CLMTB.Presentation.WinForm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLMTB.Presentation.WinForm
{
    public partial class Principal : Form
    {
        private DataManager _dataManager;
        private UserControl _control;

        public Principal()
        {
            InitializeComponent();
        }

        private void atletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDataManager(new AthleteDataManager());
        }

        private void LoadDataManager(DataManager dataManager)
        {
            try
            {
                if (_dataManager != null && _dataManager.GetType() == dataManager.GetType())
                    return;

                if (_control != null)
                {
                    pnContent.Controls.Clear();
                }

                lblStatusMessage.Text = "";
                _dataManager = dataManager;

                _control = dataManager.GetControl();
                _control.Dock = DockStyle.Fill;

                pnContent.Controls.Add(_control);

                tsCommand.Visible = _dataManager.GetVisibleCommands();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _dataManager.AddData();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAthletes_Click(object sender, EventArgs e)
        {
            LoadDataManager(new AthleteDataManager());
        }

        private void tbtAdd_Click(object sender, EventArgs e)
        {
            try
            {
                tbtNew.Image = _dataManager.IconAddData();
                _dataManager.AddData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}