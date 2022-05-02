namespace Klausur_Anw_44106
{
    partial class frm_Bestellform
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Bestellform = new System.Windows.Forms.DataGridView();
            this.lbl_Tagnummer = new System.Windows.Forms.Label();
            this.lbl_Anzahl = new System.Windows.Forms.Label();
            this.lbl_Warenname = new System.Windows.Forms.Label();
            this.tbx_Tagnummer = new System.Windows.Forms.TextBox();
            this.tbx_Anzahl = new System.Windows.Forms.TextBox();
            this.tbx_Warenname = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.mst_Main = new System.Windows.Forms.MenuStrip();
            this.appToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verlaufToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlp_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bestellform)).BeginInit();
            this.mst_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.ColumnCount = 3;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 508F));
            this.tlp_Main.Controls.Add(this.dgv_Bestellform, 2, 0);
            this.tlp_Main.Controls.Add(this.lbl_Tagnummer, 0, 0);
            this.tlp_Main.Controls.Add(this.lbl_Anzahl, 0, 1);
            this.tlp_Main.Controls.Add(this.lbl_Warenname, 0, 2);
            this.tlp_Main.Controls.Add(this.tbx_Tagnummer, 1, 0);
            this.tlp_Main.Controls.Add(this.tbx_Anzahl, 1, 1);
            this.tlp_Main.Controls.Add(this.tbx_Warenname, 1, 2);
            this.tlp_Main.Controls.Add(this.btn_add, 0, 3);
            this.tlp_Main.Controls.Add(this.btn_delete, 2, 3);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 28);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 4;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.33333F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.66667F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Main.Size = new System.Drawing.Size(800, 422);
            this.tlp_Main.TabIndex = 0;
            // 
            // dgv_Bestellform
            // 
            this.dgv_Bestellform.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bestellform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Bestellform.Location = new System.Drawing.Point(295, 3);
            this.dgv_Bestellform.Name = "dgv_Bestellform";
            this.dgv_Bestellform.RowHeadersWidth = 51;
            this.tlp_Main.SetRowSpan(this.dgv_Bestellform, 3);
            this.dgv_Bestellform.RowTemplate.Height = 24;
            this.dgv_Bestellform.Size = new System.Drawing.Size(502, 125);
            this.dgv_Bestellform.TabIndex = 0;
            this.dgv_Bestellform.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Bestellform_CellContentClick);
            // 
            // lbl_Tagnummer
            // 
            this.lbl_Tagnummer.AutoSize = true;
            this.lbl_Tagnummer.Location = new System.Drawing.Point(3, 0);
            this.lbl_Tagnummer.Name = "lbl_Tagnummer";
            this.lbl_Tagnummer.Size = new System.Drawing.Size(117, 17);
            this.lbl_Tagnummer.TabIndex = 1;
            this.lbl_Tagnummer.Text = "Tagnummer 1 - 2";
            // 
            // lbl_Anzahl
            // 
            this.lbl_Anzahl.AutoSize = true;
            this.lbl_Anzahl.Location = new System.Drawing.Point(3, 43);
            this.lbl_Anzahl.Name = "lbl_Anzahl";
            this.lbl_Anzahl.Size = new System.Drawing.Size(92, 17);
            this.lbl_Anzahl.TabIndex = 2;
            this.lbl_Anzahl.Text = "Anzahl 1 - 10";
            // 
            // lbl_Warenname
            // 
            this.lbl_Warenname.AutoSize = true;
            this.lbl_Warenname.Location = new System.Drawing.Point(3, 88);
            this.lbl_Warenname.Name = "lbl_Warenname";
            this.lbl_Warenname.Size = new System.Drawing.Size(85, 17);
            this.lbl_Warenname.TabIndex = 3;
            this.lbl_Warenname.Text = "Warenname";
            // 
            // tbx_Tagnummer
            // 
            this.tbx_Tagnummer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_Tagnummer.Location = new System.Drawing.Point(149, 3);
            this.tbx_Tagnummer.Name = "tbx_Tagnummer";
            this.tbx_Tagnummer.Size = new System.Drawing.Size(140, 22);
            this.tbx_Tagnummer.TabIndex = 4;
            this.tbx_Tagnummer.TextChanged += new System.EventHandler(this.tbx_Tagnummer_TextChanged);
            // 
            // tbx_Anzahl
            // 
            this.tbx_Anzahl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_Anzahl.Location = new System.Drawing.Point(149, 46);
            this.tbx_Anzahl.Name = "tbx_Anzahl";
            this.tbx_Anzahl.Size = new System.Drawing.Size(140, 22);
            this.tbx_Anzahl.TabIndex = 5;
            this.tbx_Anzahl.TextChanged += new System.EventHandler(this.tbx_Anzahl_TextChanged);
            // 
            // tbx_Warenname
            // 
            this.tbx_Warenname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_Warenname.Location = new System.Drawing.Point(149, 91);
            this.tbx_Warenname.Name = "tbx_Warenname";
            this.tbx_Warenname.Size = new System.Drawing.Size(140, 22);
            this.tbx_Warenname.TabIndex = 6;
            this.tbx_Warenname.TextChanged += new System.EventHandler(this.tbx_Warenname_TextChanged);
            // 
            // btn_add
            // 
            this.tlp_Main.SetColumnSpan(this.btn_add, 2);
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add.Location = new System.Drawing.Point(3, 134);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(286, 285);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_delete.Location = new System.Drawing.Point(295, 134);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(502, 285);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // mst_Main
            // 
            this.mst_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mst_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appToolStripMenuItem,
            this.verlaufToolStripMenuItem,
            this.speichernToolStripMenuItem});
            this.mst_Main.Location = new System.Drawing.Point(0, 0);
            this.mst_Main.Name = "mst_Main";
            this.mst_Main.Size = new System.Drawing.Size(800, 28);
            this.mst_Main.TabIndex = 1;
            this.mst_Main.Text = "menuStrip1";
            // 
            // appToolStripMenuItem
            // 
            this.appToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.appToolStripMenuItem.Name = "appToolStripMenuItem";
            this.appToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.appToolStripMenuItem.Text = "App";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // verlaufToolStripMenuItem
            // 
            this.verlaufToolStripMenuItem.Name = "verlaufToolStripMenuItem";
            this.verlaufToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.verlaufToolStripMenuItem.Text = "Verlaufsform";
            this.verlaufToolStripMenuItem.Click += new System.EventHandler(this.verlaufToolStripMenuItem_Click);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // frm_Bestellform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlp_Main);
            this.Controls.Add(this.mst_Main);
            this.MainMenuStrip = this.mst_Main;
            this.Name = "frm_Bestellform";
            this.Text = "Bestellware mit Verlauf";
            this.Load += new System.EventHandler(this.frm_Bestellform_Load);
            this.tlp_Main.ResumeLayout(false);
            this.tlp_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bestellform)).EndInit();
            this.mst_Main.ResumeLayout(false);
            this.mst_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.MenuStrip mst_Main;
        private System.Windows.Forms.ToolStripMenuItem appToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verlaufToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_Bestellform;
        private System.Windows.Forms.Label lbl_Tagnummer;
        private System.Windows.Forms.Label lbl_Anzahl;
        private System.Windows.Forms.Label lbl_Warenname;
        private System.Windows.Forms.TextBox tbx_Tagnummer;
        private System.Windows.Forms.TextBox tbx_Anzahl;
        private System.Windows.Forms.TextBox tbx_Warenname;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
    }
}

