using CLMTB.Presentation.WinForm.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        public virtual Image IconAddData()
        {
            return Resources._1460610221_bullet_add;
        }

        public virtual Image IconDeleteData()
        {
            return Resources._1460610732_bullet_delete;
        }

        public virtual Image IconUpdateData()
        {
            return Resources._1460610789_edit;
        }
    }
}