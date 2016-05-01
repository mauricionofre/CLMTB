using CLMTB.ApplicationLayer.Services.Entites;
using CLMTB.Presentation.WinForm.Controls.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLMTB.Presentation.WinForm.Controls.EventForm
{
    public class EventDataManager : DataManager
    {
        private EventControl _control;
        private IEventService _service;

        public EventDataManager()
        {
            _service = new EventService();
            _control = new EventControl();
        }

        public override void AddData()
        {
            throw new NotImplementedException();
        }

        public override void RemoveData()
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

        public override StateButtons GetStateButtons()
        {
            throw new NotImplementedException();
        }

        public override bool GetVisibleCommands()
        {
            throw new NotImplementedException();
        }
    }
}