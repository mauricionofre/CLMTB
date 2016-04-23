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
            Edit = " ";
            Delete = " ";
            Add = " ";
            Search = " ";
        }

        public string Edit { get; set; }

        public string Delete { get; set; }

        public string Add { get; set; }

        public string Search { get; set; }
    }

    public class SearchToolTipMessage
    {
        public string Options { get; set; }
        public string Search { get; set; }
    }
}