using CLMTB.ApplicationLayer.DTO;
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

namespace CLMTB.Presentation.WinForm.Controls.CategoryForm
{
    public partial class CategoryControl : UserControl
    {
        private ICategoryService _service;

        public CategoryControl()
        {
            InitializeComponent();
        }

        public CategoryControl(ICategoryService service)
            : this()
        {
            _service = service;
        }

        public void RefreshGrid()
        {
            gvCategories.DataSource = _service.GetAll();
            gvCategories.Refresh();
        }

        public CategoryDTO GetCategory()
        {
            if (gvCategories.SelectedCells.Count > 0)
            {
                var rowIndex = gvCategories.SelectedCells[0].RowIndex;
                return gvCategories.Rows[rowIndex].DataBoundItem as CategoryDTO;
            }
            return null;
        }
    }
}