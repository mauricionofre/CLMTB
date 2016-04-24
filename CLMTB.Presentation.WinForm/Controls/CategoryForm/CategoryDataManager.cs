using CLMTB.Presentation.WinForm.Controls.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLMTB.Presentation.WinForm.Controls.CategoryForm
{
    public class CategoryDataManager : DataManager
    {
        private CategoryControl _control;

        public CategoryDataManager()
        {
            _control = new CategoryControl();
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
            //if (_control != null)
            //_control.RefreshGrid();

            return _control;
        }

        public override string GetDescription()
        {
            return "Cadastro de Categoria";
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

        public override bool GetVisibleCommands()
        {
            return true;
        }
    }
}