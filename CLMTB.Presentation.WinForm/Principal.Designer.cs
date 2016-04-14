namespace CLMTB.Presentation.WinForm
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.atletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnContent = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsCommand = new System.Windows.Forms.ToolStrip();
            this.tbtNew = new System.Windows.Forms.ToolStripButton();
            this.tbtSave = new System.Windows.Forms.ToolStripButton();
            this.tbtRemove = new System.Windows.Forms.ToolStripButton();
            this.btnCron = new System.Windows.Forms.ToolStripButton();
            this.btnAthletes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tsCommand.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.cadastroToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.cadastroToolStripMenuItem.Text = "Arquivo";
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            // 
            // cadastroToolStripMenuItem1
            // 
            this.cadastroToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atletaToolStripMenuItem});
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem1.Text = "Cadastro";
            // 
            // atletaToolStripMenuItem
            // 
            this.atletaToolStripMenuItem.Name = "atletaToolStripMenuItem";
            this.atletaToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.atletaToolStripMenuItem.Text = "Atleta";
            this.atletaToolStripMenuItem.Click += new System.EventHandler(this.atletaToolStripMenuItem_Click);
            // 
            // pnContent
            // 
            this.pnContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnContent.Location = new System.Drawing.Point(0, 105);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(854, 361);
            this.pnContent.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(854, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(53, 17);
            this.lblStatusMessage.Text = "message";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCron,
            this.toolStripSeparator1,
            this.btnAthletes});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(854, 39);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsCommand
            // 
            this.tsCommand.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsCommand.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtNew,
            this.toolStripSeparator2,
            this.tbtRemove,
            this.tbtSave});
            this.tsCommand.Location = new System.Drawing.Point(0, 63);
            this.tsCommand.Name = "tsCommand";
            this.tsCommand.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsCommand.Size = new System.Drawing.Size(854, 39);
            this.tsCommand.TabIndex = 4;
            this.tsCommand.Text = "tsCommand";
            this.tsCommand.Visible = false;
            // 
            // tbtNew
            // 
            this.tbtNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtNew.Image = global::CLMTB.Presentation.WinForm.Properties.Resources._1460612660_file_add;
            this.tbtNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtNew.Name = "tbtNew";
            this.tbtNew.Size = new System.Drawing.Size(36, 36);
            this.tbtNew.Text = "tbtNew";
            this.tbtNew.Click += new System.EventHandler(this.tbtAdd_Click);
            // 
            // tbtSave
            // 
            this.tbtSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtSave.Enabled = false;
            this.tbtSave.Image = global::CLMTB.Presentation.WinForm.Properties.Resources._1460622284_bullet_accept;
            this.tbtSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtSave.Name = "tbtSave";
            this.tbtSave.Size = new System.Drawing.Size(36, 36);
            this.tbtSave.Text = "tbtEdit";
            // 
            // tbtRemove
            // 
            this.tbtRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtRemove.Enabled = false;
            this.tbtRemove.Image = global::CLMTB.Presentation.WinForm.Properties.Resources._1460610202_trash_full;
            this.tbtRemove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtRemove.Name = "tbtRemove";
            this.tbtRemove.Size = new System.Drawing.Size(36, 36);
            this.tbtRemove.Text = "toolStripButton1";
            // 
            // btnCron
            // 
            this.btnCron.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCron.Image = global::CLMTB.Presentation.WinForm.Properties.Resources._1460610867_star_full;
            this.btnCron.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCron.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCron.Name = "btnCron";
            this.btnCron.Size = new System.Drawing.Size(36, 36);
            this.btnCron.Text = "btnCron";
            this.btnCron.ToolTipText = "Cronometro";
            // 
            // btnAthletes
            // 
            this.btnAthletes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAthletes.Image = global::CLMTB.Presentation.WinForm.Properties.Resources._1460609586_user_add;
            this.btnAthletes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAthletes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAthletes.Name = "btnAthletes";
            this.btnAthletes.Size = new System.Drawing.Size(36, 36);
            this.btnAthletes.Text = "btnAthletes";
            this.btnAthletes.ToolTipText = "Adicionar atleta";
            this.btnAthletes.Click += new System.EventHandler(this.btnAthletes_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 491);
            this.Controls.Add(this.tsCommand);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Campeonato Lageano de MTB";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tsCommand.ResumeLayout(false);
            this.tsCommand.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem atletaToolStripMenuItem;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusMessage;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCron;
        private System.Windows.Forms.ToolStripButton btnAthletes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip tsCommand;
        private System.Windows.Forms.ToolStripButton tbtNew;
        private System.Windows.Forms.ToolStripButton tbtSave;
        private System.Windows.Forms.ToolStripButton tbtRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

