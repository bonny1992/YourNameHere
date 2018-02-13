namespace YourNameHere
{
    partial class YourNameHere_Form
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YourNameHere_Form));
            this.ynhNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ynhDataGridView = new System.Windows.Forms.DataGridView();
            this.lettereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allLettersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.allLettersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.allLettersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.allLettersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.definitionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lettersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPadDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsDone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.notifyIconMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ynhDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lettereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allLettersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allLettersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allLettersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allLettersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.definitionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ynhNotifyIcon
            // 
            this.ynhNotifyIcon.BalloonTipText = "for Razer Keyboards";
            this.ynhNotifyIcon.BalloonTipTitle = "YourNameHere";
            this.ynhNotifyIcon.ContextMenuStrip = this.notifyIconMenu;
            this.ynhNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ynhNotifyIcon.Icon")));
            this.ynhNotifyIcon.Text = "YourNameHere";
            this.ynhNotifyIcon.Visible = true;
            this.ynhNotifyIcon.DoubleClick += new System.EventHandler(this.ynhNotifyIcon_DoubleClick);
            this.ynhNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ynhNotifyIcon_MouseDoubleClick);
            // 
            // notifyIconMenu
            // 
            this.notifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.notifyIconMenu.Name = "notifyIconMenu";
            this.notifyIconMenu.Size = new System.Drawing.Size(124, 48);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ynhDataGridView
            // 
            this.ynhDataGridView.AutoGenerateColumns = false;
            this.ynhDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ynhDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lettersDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.numPadDataGridViewCheckBoxColumn,
            this.IsDone});
            this.ynhDataGridView.DataSource = this.lettereBindingSource;
            this.ynhDataGridView.Location = new System.Drawing.Point(12, 65);
            this.ynhDataGridView.Name = "ynhDataGridView";
            this.ynhDataGridView.Size = new System.Drawing.Size(855, 427);
            this.ynhDataGridView.TabIndex = 1;
            // 
            // lettereBindingSource
            // 
            this.lettereBindingSource.DataSource = typeof(YourNameHere.Definitions.Lettere);
            // 
            // lettersDataGridViewTextBoxColumn
            // 
            this.lettersDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lettersDataGridViewTextBoxColumn.DataPropertyName = "Letters";
            this.lettersDataGridViewTextBoxColumn.HeaderText = "Letters";
            this.lettersDataGridViewTextBoxColumn.Name = "lettersDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // numPadDataGridViewCheckBoxColumn
            // 
            this.numPadDataGridViewCheckBoxColumn.DataPropertyName = "NumPad";
            this.numPadDataGridViewCheckBoxColumn.HeaderText = "NumPad";
            this.numPadDataGridViewCheckBoxColumn.Name = "numPadDataGridViewCheckBoxColumn";
            this.numPadDataGridViewCheckBoxColumn.ToolTipText = "Are the numbers in the letters in the numpad?";
            // 
            // IsDone
            // 
            this.IsDone.HeaderText = "Is done?";
            this.IsDone.Name = "IsDone";
            this.IsDone.ReadOnly = true;
            // 
            // YourNameHere_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 504);
            this.Controls.Add(this.ynhDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "YourNameHere_Form";
            this.Text = "YourNameHere";
            this.notifyIconMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ynhDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lettereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allLettersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allLettersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allLettersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allLettersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.definitionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorTypesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon ynhNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyIconMenu;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView ynhDataGridView;
        private System.Windows.Forms.BindingSource definitionsBindingSource;
        private System.Windows.Forms.BindingSource allLettersBindingSource;
        private System.Windows.Forms.BindingSource allLettersBindingSource1;
        private System.Windows.Forms.BindingSource allLettersBindingSource2;
        private System.Windows.Forms.BindingSource allLettersBindingSource3;
        private System.Windows.Forms.BindingSource lettereBindingSource;
        private System.Windows.Forms.BindingSource colorTypesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn lettersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn numPadDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDone;
    }
}

