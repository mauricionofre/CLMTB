namespace CLMTB.Presentation.WinForm.Controls.AthleteForm
{
    partial class AthleteControl
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
            this.gvAthletes = new System.Windows.Forms.DataGridView();
            this.gbGridAthletes = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvAthletes)).BeginInit();
            this.gbGridAthletes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvAthletes
            // 
            this.gvAthletes.AllowUserToAddRows = false;
            this.gvAthletes.AllowUserToDeleteRows = false;
            this.gvAthletes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvAthletes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAthletes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvAthletes.Location = new System.Drawing.Point(3, 16);
            this.gvAthletes.Name = "gvAthletes";
            this.gvAthletes.ReadOnly = true;
            this.gvAthletes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gvAthletes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvAthletes.Size = new System.Drawing.Size(833, 495);
            this.gvAthletes.TabIndex = 7;
            // 
            // gbGridAthletes
            // 
            this.gbGridAthletes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGridAthletes.Controls.Add(this.gvAthletes);
            this.gbGridAthletes.Location = new System.Drawing.Point(3, 3);
            this.gbGridAthletes.Name = "gbGridAthletes";
            this.gbGridAthletes.Size = new System.Drawing.Size(839, 514);
            this.gbGridAthletes.TabIndex = 8;
            this.gbGridAthletes.TabStop = false;
            this.gbGridAthletes.Text = "Atletas Cadastrados";
            // 
            // AthleteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbGridAthletes);
            this.Name = "AthleteControl";
            this.Size = new System.Drawing.Size(845, 520);
            ((System.ComponentModel.ISupportInitialize)(this.gvAthletes)).EndInit();
            this.gbGridAthletes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvAthletes;
        private System.Windows.Forms.GroupBox gbGridAthletes;
    }
}
