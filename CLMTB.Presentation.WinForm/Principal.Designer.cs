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
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnContent = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsOptions = new System.Windows.Forms.ToolStrip();
            this.btnCron = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAthletes = new System.Windows.Forms.ToolStripButton();
            this.btnCategory = new System.Windows.Forms.ToolStripButton();
            this.btnStage = new System.Windows.Forms.ToolStripButton();
            this.tsCommand = new System.Windows.Forms.ToolStrip();
            this.tbtAdd = new System.Windows.Forms.ToolStripButton();
            this.tbtEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtRemove = new System.Windows.Forms.ToolStripButton();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tstSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tscSearchBy = new System.Windows.Forms.ToolStripComboBox();
            this.tslSearchBy = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tsOptions.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1268, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
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
            this.atletaToolStripMenuItem,
            this.categoriaToolStripMenuItem});
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(66, 19);
            this.cadastroToolStripMenuItem1.Text = "Cadastro";
            // 
            // atletaToolStripMenuItem
            // 
            this.atletaToolStripMenuItem.Name = "atletaToolStripMenuItem";
            this.atletaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.atletaToolStripMenuItem.Text = "Atleta";
            this.atletaToolStripMenuItem.Click += new System.EventHandler(this.atletaToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // pnContent
            // 
            this.pnContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnContent.Location = new System.Drawing.Point(0, 162);
            this.pnContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1557, 678);
            this.pnContent.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 743);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1268, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(53, 17);
            this.lblStatusMessage.Text = "message";
            // 
            // tsOptions
            // 
            this.tsOptions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCron,
            this.toolStripSeparator1,
            this.btnAthletes,
            this.btnCategory,
            this.btnStage});
            this.tsOptions.Location = new System.Drawing.Point(0, 25);
            this.tsOptions.Name = "tsOptions";
            this.tsOptions.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tsOptions.Size = new System.Drawing.Size(1268, 39);
            this.tsOptions.TabIndex = 3;
            this.tsOptions.Text = "toolStrip1";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
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
            // btnCategory
            // 
            this.btnCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCategory.Image = global::CLMTB.Presentation.WinForm.Properties.Resources.tag_add;
            this.btnCategory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(36, 36);
            this.btnCategory.Text = "btnCategory";
            this.btnCategory.ToolTipText = "Adicionar Categoria";
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnStage
            // 
            this.btnStage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStage.Image = global::CLMTB.Presentation.WinForm.Properties.Resources._1463551502_date_add;
            this.btnStage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStage.Name = "btnStage";
            this.btnStage.Size = new System.Drawing.Size(36, 36);
            this.btnStage.Text = "btnStage";
            this.btnStage.ToolTipText = "Adicionar Etapas";
            this.btnStage.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsCommand
            // 
            this.tsCommand.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsCommand.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtAdd,
            this.tbtEdit,
            this.toolStripSeparator2,
            this.tbtRemove,
            this.tsbSearch,
            this.tstSearch,
            this.tscSearchBy,
            this.tslSearchBy});
            this.tsCommand.Location = new System.Drawing.Point(0, 97);
            this.tsCommand.Name = "tsCommand";
            this.tsCommand.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tsCommand.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsCommand.Size = new System.Drawing.Size(1557, 60);
            this.tsCommand.TabIndex = 4;
            this.tsCommand.Text = "tsCommand";
            this.tsCommand.Visible = false;
            // 
            // tbtAdd
            // 
            this.tbtAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtAdd.Image = global::CLMTB.Presentation.WinForm.Properties.Resources._1460610221_bullet_add;
            this.tbtAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtAdd.Name = "tbtAdd";
            this.tbtAdd.Size = new System.Drawing.Size(36, 57);
            this.tbtAdd.Text = "tbtAdd";
            this.tbtAdd.Click += new System.EventHandler(this.tbtAdd_Click);
            // 
            // tbtEdit
            // 
            this.tbtEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtEdit.Image = global::CLMTB.Presentation.WinForm.Properties.Resources._1460610789_edit;
            this.tbtEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtEdit.Name = "tbtEdit";
            this.tbtEdit.Size = new System.Drawing.Size(36, 57);
            this.tbtEdit.Text = "tbtEdit";
            this.tbtEdit.Click += new System.EventHandler(this.tbtEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 60);
            // 
            // tbtRemove
            // 
            this.tbtRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtRemove.Image = global::CLMTB.Presentation.WinForm.Properties.Resources._1460610202_trash_full;
            this.tbtRemove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtRemove.Name = "tbtRemove";
            this.tbtRemove.Size = new System.Drawing.Size(36, 57);
            this.tbtRemove.Text = "tbRemove";
            this.tbtRemove.Click += new System.EventHandler(this.tbtRemove_Click);
            // 
            // tsbSearch
            // 
            this.tsbSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearch.Image = global::CLMTB.Presentation.WinForm.Properties.Resources._1461284429_zoom;
            this.tsbSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(36, 57);
            this.tsbSearch.Text = "toolStripButton1";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // tstSearch
            // 
            this.tstSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstSearch.Name = "tstSearch";
            this.tstSearch.Size = new System.Drawing.Size(148, 60);
            // 
            // tscSearchBy
            // 
            this.tscSearchBy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscSearchBy.Name = "tscSearchBy";
            this.tscSearchBy.Size = new System.Drawing.Size(180, 60);
            // 
            // tslSearchBy
            // 
            this.tslSearchBy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslSearchBy.Name = "tslSearchBy";
            this.tslSearchBy.Size = new System.Drawing.Size(76, 57);
            this.tslSearchBy.Text = "Procurar por:";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 765);
            this.Controls.Add(this.tsCommand);
            this.Controls.Add(this.tsOptions);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Principal";
            this.Text = "Campeonato Lageano de MTB";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tsOptions.ResumeLayout(false);
            this.tsOptions.PerformLayout();
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
        private System.Windows.Forms.ToolStrip tsOptions;
        private System.Windows.Forms.ToolStripButton btnCron;
        private System.Windows.Forms.ToolStripButton btnAthletes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip tsCommand;
        private System.Windows.Forms.ToolStripButton tbtEdit;
        private System.Windows.Forms.ToolStripButton tbtAdd;
        private System.Windows.Forms.ToolStripButton tbtRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tslSearchBy;
        private System.Windows.Forms.ToolStripComboBox tscSearchBy;
        private System.Windows.Forms.ToolStripTextBox tstSearch;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripButton btnCategory;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnStage;
    }
}

