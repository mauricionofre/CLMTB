using CLMTB.ApplicationLayer.Services.Entites;
using CLMTB.Presentation.WinForm.Controls.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLMTB.Presentation.WinForm.Controls.Athlete
{
    public class AthleteDataManager : DataManager
    {
        private AthleteControl _control;
        private AthleteService _service;

        public AthleteDataManager()
        {
            _service = new AthleteService();
            _control = new AthleteControl();
        }

        public override void AddData()
        {
            _service.Add(new Domain.Entities.Athlete("Onofre", DateTime.Now, new Domain.Entities.Address()));
        }

        public override void DeleteData()
        {
            throw new NotImplementedException();
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