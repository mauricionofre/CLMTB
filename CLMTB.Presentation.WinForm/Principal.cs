using CLMTB.Presentation.WinForm.Controls.AthleteForm;
using CLMTB.Presentation.WinForm.Controls.CategoryForm;
using CLMTB.Presentation.WinForm.Controls.Shared;
using CLMTB.Presentation.WinForm.Controls.StageForm;
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

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDataManager(new CategoryDataManager());
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

                lblStatusMessage.Text = dataManager.GetDescription();
                _dataManager = dataManager;

                _control = dataManager.GetControl();
                _control.Dock = DockStyle.Fill;

                pnContent.Controls.Add(_control);

                tbtEdit.ToolTipText = dataManager.GetToolTipMessage().Edit;
                tbtRemove.ToolTipText = dataManager.GetToolTipMessage().Delete;
                tbtAdd.ToolTipText = dataManager.GetToolTipMessage().Add;
                tsbSearch.ToolTipText = dataManager.GetToolTipMessage().Search;

                tbtEdit.Enabled = dataManager.GetStateButtons().Edit;
                tbtRemove.Enabled = dataManager.GetStateButtons().Delete;
                tbtAdd.Enabled = dataManager.GetStateButtons().Add;

                if (dataManager.GetSearchOptions() != null)
                    tscSearchBy.Items.AddRange(dataManager.GetSearchOptions().ToArray());

                SetToolStripSearch(dataManager.GetStateButtons().Search);

                tsCommand.Visible = _dataManager.GetVisibleCommands();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetToolStripSearch(bool search)
        {
            tslSearchBy.Visible = search;
            tscSearchBy.Visible = search;
            tstSearch.Visible = search;
            tsbSearch.Visible = search;
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

        private void tbtAdd_Click(object sender, EventArgs e)
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

        private void tbtEdit_Click(object sender, EventArgs e)
        {
            try
            {
                _dataManager.UpdateData();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void tbtRemove_Click(object sender, EventArgs e)
        {
            try
            {
                _dataManager.RemoveData();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //_dataManager.Find();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void btnAthletes_Click(object sender, EventArgs e)
        {
            LoadDataManager(new AthleteDataManager());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            LoadDataManager(new CategoryDataManager());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LoadDataManager(new StageDataManager());
        }
    }
}