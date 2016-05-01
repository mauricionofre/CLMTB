namespace CLMTB.Presentation.WinForm.Controls.EventForm
{
    partial class EventControl
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
            this.gbEvents = new System.Windows.Forms.GroupBox();
            this.gvEvents = new System.Windows.Forms.DataGridView();
            this.gbEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEvents
            // 
            this.gbEvents.Controls.Add(this.gvEvents);
            this.gbEvents.Location = new System.Drawing.Point(3, 3);
            this.gbEvents.Name = "gbEvents";
            this.gbEvents.Size = new System.Drawing.Size(839, 514);
            this.gbEvents.TabIndex = 0;
            this.gbEvents.TabStop = false;
            this.gbEvents.Text = "Eventos Cadastrados";
            // 
            // gvEvents
            // 
            this.gvEvents.AllowUserToAddRows = false;
            this.gvEvents.AllowUserToDeleteRows = false;
            this.gvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvEvents.Location = new System.Drawing.Point(3, 16);
            this.gvEvents.Name = "gvEvents";
            this.gvEvents.ReadOnly = true;
            this.gvEvents.Size = new System.Drawing.Size(833, 495);
            this.gvEvents.TabIndex = 0;
            // 
            // EventControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbEvents);
            this.Name = "EventControl";
            this.Size = new System.Drawing.Size(845, 520);
            this.gbEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEvents;
        private System.Windows.Forms.DataGridView gvEvents;
    }
}
