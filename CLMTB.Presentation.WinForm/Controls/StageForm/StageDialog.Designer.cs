namespace CLMTB.Presentation.WinForm.Controls.StageForm
{
    partial class StageDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StageDialog));
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbStageType = new System.Windows.Forms.ComboBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIdentifier = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSequential = new System.Windows.Forms.Label();
            this.txtSequential = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dpInitialDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 19);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 20);
            this.lblId.TabIndex = 55;
            this.lblId.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(90, 14);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(92, 26);
            this.txtId.TabIndex = 54;
            this.txtId.Text = "0";
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbStageType
            // 
            this.cbStageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStageType.FormattingEnabled = true;
            this.cbStageType.Location = new System.Drawing.Point(241, 48);
            this.cbStageType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStageType.Name = "cbStageType";
            this.cbStageType.Size = new System.Drawing.Size(180, 28);
            this.cbStageType.TabIndex = 49;
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(190, 51);
            this.lbltipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(43, 20);
            this.lbltipo.TabIndex = 53;
            this.lbltipo.Text = "Tipo:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 91);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 51;
            this.lblName.Text = "Nome:";
            // 
            // lblIdentifier
            // 
            this.lblIdentifier.AutoSize = true;
            this.lblIdentifier.Location = new System.Drawing.Point(109, 17);
            this.lblIdentifier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentifier.Name = "lblIdentifier";
            this.lblIdentifier.Size = new System.Drawing.Size(44, 20);
            this.lblIdentifier.TabIndex = 52;
            this.lblIdentifier.Text = "CPF:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Info;
            this.txtName.Location = new System.Drawing.Point(90, 86);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(331, 26);
            this.txtName.TabIndex = 50;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(309, 297);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 60;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(188, 297);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSequential
            // 
            this.lblSequential.AutoSize = true;
            this.lblSequential.Location = new System.Drawing.Point(13, 51);
            this.lblSequential.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSequential.Name = "lblSequential";
            this.lblSequential.Size = new System.Drawing.Size(69, 20);
            this.lblSequential.TabIndex = 63;
            this.lblSequential.Text = "Número:";
            // 
            // txtSequential
            // 
            this.txtSequential.BackColor = System.Drawing.SystemColors.Info;
            this.txtSequential.Location = new System.Drawing.Point(90, 50);
            this.txtSequential.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSequential.Name = "txtSequential";
            this.txtSequential.Size = new System.Drawing.Size(92, 26);
            this.txtSequential.TabIndex = 62;
            this.txtSequential.Text = "0";
            this.txtSequential.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "CPF:";
            // 
            // dpInitialDate
            // 
            this.dpInitialDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpInitialDate.Location = new System.Drawing.Point(90, 120);
            this.dpInitialDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dpInitialDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dpInitialDate.Name = "dpInitialDate";
            this.dpInitialDate.Size = new System.Drawing.Size(126, 26);
            this.dpInitialDate.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Data:";
            // 
            // StageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 346);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpInitialDate);
            this.Controls.Add(this.lblSequential);
            this.Controls.Add(this.txtSequential);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cbStageType);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblIdentifier);
            this.Controls.Add(this.txtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StageDialog";
            this.Text = "StageDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cbStageType;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIdentifier;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSequential;
        private System.Windows.Forms.TextBox txtSequential;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpInitialDate;
        private System.Windows.Forms.Label label1;
    }
}