using CLMTB.ApplicationLayer.DTO;
using CLMTB.Domain.Entities;
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
    public partial class CategoryDialog : Form
    {
        public CategoryDialog()
        {
            InitializeComponent();

            cbCategoryType.DataSource = EnumHelper.GetEnumDescriptions(typeof(CategoryTypeEnum));
        }

        private CategoryDTO _category;

        public CategoryDTO Category
        {
            get { return _category; }
            set
            {
                _category = value;

                txtId.Text = _category.Id.ToString();
                txtName.Text = _category.Name;
                txtDescription.Text = _category.Description;

                cbCategoryType.SelectedItem = EnumHelper.GetEnumDescription(_category.Type);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Category.Id = Convert.ToInt32(txtId.Text);
            Category.Name = txtName.Text;
            Category.Description = txtDescription.Text;
            Category.Type = EnumHelper.GetEnumFromDescription<CategoryTypeEnum>(cbCategoryType.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}