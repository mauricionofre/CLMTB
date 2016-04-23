using CLMTB.ApplicationLayer.DTO;
using CLMTB.ApplicationLayer.Services.Entites;
using CLMTB.Domain.Entities;
using CLMTB.Presentation.WinForm.Controls.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CLMTB.Presentation.WinForm.Controls.AthleteForm
{
    public class AthleteDataManager : DataManager
    {
        private AthleteControl _control;
        private AthleteService _service;

        public AthleteDataManager()
        {
            _service = new AthleteService();
            _control = new AthleteControl(_service);
        }

        public override void AddData()
        {
            var dialog = new AthleteDialog();
            dialog.Athlete = new AthleteDTO();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _service.Add(dialog.Athlete);
                _control.RefreshGrid();
            }
        }

        public override void RemoveData()
        {
            AthleteDTO athlete = _control.GetAthlete();

            if (athlete == null)
            {
                MessageBox.Show("Nenhum atleta selecionado. Selecionar um atleta antes de solicitar a exclusão");
                return;
            }

            if (MessageBox.Show("Deseja remover o atleta selecionado?", "", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                try
                {
                    _service.Delete(athlete.Id);

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
            AthleteDTO athlete = _control.GetAthlete();

            if (athlete == null)
            {
                MessageBox.Show("Nenhum atleta selecionado. Selecionar um atleta antes de solicitar a edição");
                return;
            }

            var dialog = new AthleteDialog();

            dialog.Athlete = athlete;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _service.Update(dialog.Athlete);
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
            return "Cadastro de Atleta";
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

        public override ToolTipMessage GetToolTipMessage()
        {
            return new ToolTipMessage()
            {
                Add = "Adicionar Atleta",
                Delete = "Deletar Atleta",
                Edit = "Editar Atleta",
                Search = "Procurar Atleta"
            };
        }

        public override bool GetVisibleCommands()
        {
            return true;
        }

        public override List<string> GetSearchOptions()
        {
            return GetOptions(typeof(AthleteDTO));
        }
    }
}