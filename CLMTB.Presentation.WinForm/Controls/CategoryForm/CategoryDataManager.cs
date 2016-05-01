using CLMTB.ApplicationLayer.DTO;
using CLMTB.ApplicationLayer.Services.Entites;
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
        private CategoryService _service;

        public CategoryDataManager()
        {
            _service = new CategoryService();
            _control = new CategoryControl(_service);
        }

        public override void AddData()
        {
            var dialog = new CategoryDialog();
            dialog.Category = new CategoryDTO();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _service.Add(dialog.Category);
                _control.RefreshGrid();
            }
        }

        public override void RemoveData()
        {
            CategoryDTO category = _control.GetCategory();

            if (category == null)
            {
                MessageBox.Show("Nenhuma categoris selecionada. Selecionar uma categoria antes de solicitar a exclusão");
                return;
            }

            if (MessageBox.Show("Deseja remover a categoria selecionada?", "", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                try
                {
                    _service.Delete(category.Id);

                    _control.RefreshGrid();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public override void UpdateData()
        {
            CategoryDTO category = _control.GetCategory();

            if (category == null)
            {
                MessageBox.Show("Nenhuma Categoria selecionado. Selecionar uma Categoria antes de solicitar a edição");
                return;
            }

            var dialog = new CategoryDialog();

            dialog.Category = category;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _service.Update(dialog.Category);
                _control.RefreshGrid();
            }
        }

        public override UserControl GetControl()
        {
            if (_control != null)
                _control.RefreshGrid();

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