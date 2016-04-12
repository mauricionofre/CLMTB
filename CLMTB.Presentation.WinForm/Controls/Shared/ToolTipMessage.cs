using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.Presentation.WinForm.Controls.Shared
{
    public class ToolTipMessage
    {
        public ToolTipMessage()
        {
            Add = " ";
            Delete = " ";
            Edit = " ";
        }

        public string Add { get; set; }

        public string Delete { get; set; }

        public string Edit { get; set; }
    }
}