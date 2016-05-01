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

namespace CLMTB.Presentation.WinForm.Controls.EventForm
{
    public partial class EventControl : UserControl
    {
        private IEventService _service;

        public EventControl()
        {
            InitializeComponent();
        }

        public EventControl(IEventService service)
            : this()
        {
            _service = service;
        }

        public void RefreshGrid()
        {
            gvEvents.DataSource = _service.GetAll();
            gvEvents.Refresh();
        }
    }
}