using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLMTB.Presentation.WinForm.Controls.Shared
{
    public abstract class DataManager
    {
        public abstract void AddData();

        public abstract void DeleteData();

        public abstract void UpdateData();

        public abstract UserControl GetControl();

        public abstract string GetDescription();

        public abstract ToolTipMessage GetToolTipMessage();

        public abstract StateButtons GetStateButtons();

        public abstract bool GetVisibleCommands();
    }
}