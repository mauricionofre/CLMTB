namespace CLMTB.Presentation.WinForm.Controls.CategoryForm
{
    partial class CategoryControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.gvCategories = new System.Windows.Forms.DataGridView();
            this.gbCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCategory
            // 
            this.gbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCategory.Controls.Add(this.gvCategories);
            this.gbCategory.Location = new System.Drawing.Point(3, 3);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(839, 514);
            this.gbCategory.TabIndex = 0;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "Categorias Cadastradas";
            // 
            // gvCategories
            // 
            this.gvCategories.AllowUserToAddRows = false;
            this.gvCategories.AllowUserToDeleteRows = false;
            this.gvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvCategories.Location = new System.Drawing.Point(3, 16);
            this.gvCategories.Name = "gvCategories";
            this.gvCategories.ReadOnly = true;
            this.gvCategories.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCategories.Size = new System.Drawing.Size(833, 495);
            this.gvCategories.TabIndex = 0;
            // 
            // CategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbCategory);
            this.Name = "CategoryControl";
            this.Size = new System.Drawing.Size(845, 520);
            this.gbCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.DataGridView gvCategories;
    }
}
