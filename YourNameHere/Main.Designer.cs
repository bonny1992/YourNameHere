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
            this.lettersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPadDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsDone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lettereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ynhSave = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.ynhLoad = new System.ComponentModel.BackgroundWorker();
            this.notifyIconMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ynhDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lettereBindingSource)).BeginInit();
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
            // lettereBindingSource
            // 
            this.lettereBindingSource.DataSource = typeof(YourNameHere.Definitions.Lettere);
            // 
            // ynhSave
            // 
            this.ynhSave.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ynhSave_DoWork);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(940, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ynhLoad
            // 
            this.ynhLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ynhLoad_DoWork);
            this.ynhLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ynhLoad_RunWorkerCompleted);
            // 
            // YourNameHere_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ynhDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "YourNameHere_Form";
            this.Text = "YourNameHere";
            this.notifyIconMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ynhDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lettereBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon ynhNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyIconMenu;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView ynhDataGridView;
        private System.Windows.Forms.BindingSource lettereBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn lettersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn numPadDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDone;
        private System.ComponentModel.BackgroundWorker ynhSave;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker ynhLoad;
    }
}

