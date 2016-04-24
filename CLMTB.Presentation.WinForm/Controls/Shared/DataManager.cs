using CLMTB.Presentation.WinForm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLMTB.Presentation.WinForm.Controls.Shared
{
    public abstract class DataManager
    {
        public abstract void AddData();

        public abstract void RemoveData();

        public abstract void UpdateData();

        public abstract UserControl GetControl();

        public abstract string GetDescription();

        public virtual List<string> GetSearchOptions()
        {
            return null;
        }

        public virtual ToolTipMessage GetToolTipMessage()
        {
            return new ToolTipMessage
            {
                Edit = "Editar",
                Delete = "Deletar",
                Add = "Adicionar",
                Search = "Procurar"
            };
        }

        public abstract StateButtons GetStateButtons();

        public abstract bool GetVisibleCommands();

        public List<string> GetOptions(Type type)
        {
            var options = new List<string>();
            List<PropertyInfo> props = type.GetProperties()
                .Where(prop => Attribute.IsDefined(prop, typeof(DisplayNameAttribute)))
                .ToList();

            props.ForEach(x => options.Add(x.Name));
            return options;
        }
    }
}