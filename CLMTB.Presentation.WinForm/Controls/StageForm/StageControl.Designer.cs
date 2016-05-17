namespace CLMTB.Presentation.WinForm.Controls.StageForm
{
    partial class StageControl
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
            this.gbStages = new System.Windows.Forms.GroupBox();
            this.gvStages = new System.Windows.Forms.DataGridView();
            this.gbStages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStages)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStages
            // 
            this.gbStages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStages.Controls.Add(this.gvStages);
            this.gbStages.Location = new System.Drawing.Point(3, 3);
            this.gbStages.Name = "gbStages";
            this.gbStages.Size = new System.Drawing.Size(839, 514);
            this.gbStages.TabIndex = 1;
            this.gbStages.TabStop = false;
            this.gbStages.Text = "Etapas Cadastradas";
            // 
            // gvStages
            // 
            this.gvStages.AllowUserToAddRows = false;
            this.gvStages.AllowUserToDeleteRows = false;
            this.gvStages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvStages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvStages.Location = new System.Drawing.Point(3, 16);
            this.gvStages.Name = "gvStages";
            this.gvStages.ReadOnly = true;
            this.gvStages.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gvStages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvStages.Size = new System.Drawing.Size(833, 495);
            this.gvStages.TabIndex = 0;
            // 
            // StageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbStages);
            this.Name = "StageControl";
            this.Size = new System.Drawing.Size(845, 520);
            this.gbStages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvStages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStages;
        private System.Windows.Forms.DataGridView gvStages;
    }
}
