using CLMTB.ApplicationLayer.Services.Entites;
using CLMTB.Domain.Entities;
using CLMTB.Presentation.WinForm.Controls.Shared;
using System;
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
            _service.Add(new Athlete("Onofre", DateTime.Now, new Domain.Entities.Address()));
            _control.RefreshGrid();
        }

        public override void DeleteData()
        {
            Athlete athlete = _control.GetAthlete();
            _service.Delete(athlete.Id);
        }

        public override void UpdateData()
        {
            throw new NotImplementedException();
        }

        public override UserControl GetControl()
        {
            if (_control != null)
                _control.RefreshGrid();

            return _control;
        }

        public override string GetDescription()
        {
            throw new NotImplementedException();
        }

        public override ToolTipMessage GetToolTipMessage()
        {
            throw new NotImplementedException();
        }

        public override StateButtons GetStateButtons()
        {
            throw new NotImplementedException();
        }

        public override bool GetVisibleCommands()
        {
            return true;
        }
    }
}