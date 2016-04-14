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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblIdentifier = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIdentifier = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.gvAthletes = new System.Windows.Forms.DataGridView();
            this.gbGridAthletes = new System.Windows.Forms.GroupBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtNeighborhood = new System.Windows.Forms.TextBox();
            this.lblNeighborhood = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cbBloodGroup = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvAthletes)).BeginInit();
            this.gbGridAthletes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(6, 48);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(92, 13);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Data Nascimento:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(6, 74);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(64, 13);
            this.lblStreet.TabIndex = 2;
            this.lblStreet.Text = "Logradouro:";
            // 
            // lblIdentifier
            // 
            this.lblIdentifier.AutoSize = true;
            this.lblIdentifier.Location = new System.Drawing.Point(433, 22);
            this.lblIdentifier.Name = "lblIdentifier";
            this.lblIdentifier.Size = new System.Drawing.Size(30, 13);
            this.lblIdentifier.TabIndex = 3;
            this.lblIdentifier.Text = "CPF:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(320, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtIdentifier
            // 
            this.txtIdentifier.Location = new System.Drawing.Point(476, 19);
            this.txtIdentifier.Name = "txtIdentifier";
            this.txtIdentifier.Size = new System.Drawing.Size(141, 20);
            this.txtIdentifier.TabIndex = 2;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(104, 45);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(172, 20);
            this.txtBirthDate.TabIndex = 4;
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
            this.gvAthletes.Size = new System.Drawing.Size(833, 376);
            this.gvAthletes.TabIndex = 7;
            this.gvAthletes.SelectionChanged += new System.EventHandler(this.gvAthletes_SelectionChanged);
            // 
            // gbGridAthletes
            // 
            this.gbGridAthletes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGridAthletes.Controls.Add(this.gvAthletes);
            this.gbGridAthletes.Location = new System.Drawing.Point(3, 146);
            this.gbGridAthletes.Name = "gbGridAthletes";
            this.gbGridAthletes.Size = new System.Drawing.Size(839, 395);
            this.gbGridAthletes.TabIndex = 8;
            this.gbGridAthletes.TabStop = false;
            this.gbGridAthletes.Text = "Atletas Cadastrados";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(104, 71);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(320, 20);
            this.txtStreet.TabIndex = 8;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(623, 74);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(47, 13);
            this.lblNumber.TabIndex = 10;
            this.lblNumber.Text = "Número:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(676, 71);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(66, 20);
            this.txtNumber.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(104, 98);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(148, 20);
            this.txtCity.TabIndex = 11;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 101);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(57, 13);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "Município:";
            // 
            // txtNeighborhood
            // 
            this.txtNeighborhood.Location = new System.Drawing.Point(476, 71);
            this.txtNeighborhood.Name = "txtNeighborhood";
            this.txtNeighborhood.Size = new System.Drawing.Size(141, 20);
            this.txtNeighborhood.TabIndex = 9;
            // 
            // lblNeighborhood
            // 
            this.lblNeighborhood.AutoSize = true;
            this.lblNeighborhood.Location = new System.Drawing.Point(433, 74);
            this.lblNeighborhood.Name = "lblNeighborhood";
            this.lblNeighborhood.Size = new System.Drawing.Size(37, 13);
            this.lblNeighborhood.TabIndex = 14;
            this.lblNeighborhood.Text = "Bairro:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbBloodGroup);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFone);
            this.groupBox1.Controls.Add(this.txtState);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblRG);
            this.groupBox1.Controls.Add(this.txtRG);
            this.groupBox1.Controls.Add(this.lbltipo);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtNeighborhood);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.lblNeighborhood);
            this.groupBox1.Controls.Add(this.lblStreet);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.lblIdentifier);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.txtIdentifier);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Controls.Add(this.txtBirthDate);
            this.groupBox1.Controls.Add(this.txtStreet);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 137);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(436, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fone:";
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(626, 45);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(116, 20);
            this.txtFone.TabIndex = 7;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(290, 98);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(80, 20);
            this.txtState.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "UF:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(623, 22);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 18;
            this.lblRG.Text = "RG:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(655, 19);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(87, 20);
            this.txtRG.TabIndex = 3;
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(283, 48);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(87, 13);
            this.lbltipo.TabIndex = 15;
            this.lbltipo.Text = "Tipo Sanguíneo:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(510, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Feminino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // cbBloodGroup
            // 
            this.cbBloodGroup.FormattingEnabled = true;
            this.cbBloodGroup.Location = new System.Drawing.Point(374, 45);
            this.cbBloodGroup.Name = "cbBloodGroup";
            this.cbBloodGroup.Size = new System.Drawing.Size(50, 21);
            this.cbBloodGroup.TabIndex = 5;
            // 
            // AthleteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbGridAthletes);
            this.Name = "AthleteControl";
            this.Size = new System.Drawing.Size(845, 544);
            ((System.ComponentModel.ISupportInitialize)(this.gvAthletes)).EndInit();
            this.gbGridAthletes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblIdentifier;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIdentifier;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.DataGridView gvAthletes;
        private System.Windows.Forms.GroupBox gbGridAthletes;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtNeighborhood;
        private System.Windows.Forms.Label lblNeighborhood;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox cbBloodGroup;
    }
}
