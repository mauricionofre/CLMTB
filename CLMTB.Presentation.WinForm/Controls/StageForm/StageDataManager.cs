using CLMTB.ApplicationLayer.DTO;
using CLMTB.ApplicationLayer.Services.Entites;
using CLMTB.Presentation.WinForm.Controls.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLMTB.Presentation.WinForm.Controls.StageForm
{
    public class StageDataManager : DataManager
    {
        private StageService _service;
        private StageControl _control;

        public StageDataManager()
        {
            _service = new StageService();
            _control = new StageControl(_service);
        }

        public override void AddData()
        {
            var dialog = new StageDialog();
            dialog.Stage = new StageDTO();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _service.Add(dialog.Stage);
                _control.RefreshGrid();
            }
        }

        public override void RemoveData()
        {
            StageDTO stage = _control.GetStage();

            if (stage == null)
            {
                MessageBox.Show("Nenhuma Etapa selecionada. Selecionar uma Etapa antes de solicitar a exclusão");
                return;
            }

            if (MessageBox.Show("Deseja remover a Etapa selecionada?", "", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                try
                {
                    _service.Delete(stage.Id);

                    _control.RefreshGrid();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public override void UpdateData()
        {
            StageDTO stage = _control.GetStage();

            if (stage == null)
            {
                MessageBox.Show("Nenhuma Etapa selecionada. Selecionar uma Etapa antes de solicitar a edição");
                return;
            }

            var dialog = new StageDialog();

            dialog.Stage = stage;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _service.Update(dialog.Stage);
                _control.RefreshGrid();
            }
        }

        public override UserControl GetControl()
        {
            if (_control != null)
                _control.RefreshGrid();

            return _control;
        }

        public override string GetDescription()
        {
            return "Cadastro de Etapas";
        }

        public override StateButtons GetStateButtons()
        {
            return new StateButtons
            {
                Edit = true,
                Delete = true,
                Add = true,
                Search = false
            };
        }

        public override bool GetVisibleCommands()
        {
            return true;
        }
    }
}