using System.Windows.Forms;

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
            this.IsDone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ynhSave = new System.ComponentModel.BackgroundWorker();
            this.ynhLoad = new System.ComponentModel.BackgroundWorker();
            this.ynhPictureBotMain = new System.Windows.Forms.PictureBox();
            this.ynhBtnSave = new System.Windows.Forms.Button();
            this.btnSaveTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ynhBtnLoad = new System.Windows.Forms.Button();
            this.ynhBtnSetKeys = new System.Windows.Forms.Button();
            this.ynhSetKeys = new System.ComponentModel.BackgroundWorker();
            this.lettersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPadDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lettereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ynhMinimizeToTray = new System.Windows.Forms.Button();
            this.notifyIconMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ynhDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ynhPictureBotMain)).BeginInit();
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
            this.ynhDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ynhDataGridView.AutoGenerateColumns = false;
            this.ynhDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ynhDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lettersDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.numPadDataGridViewCheckBoxColumn,
            this.IsDone});
            this.ynhDataGridView.DataSource = this.lettereBindingSource;
            this.ynhDataGridView.Location = new System.Drawing.Point(12, 131);
            this.ynhDataGridView.Name = "ynhDataGridView";
            this.ynhDataGridView.Size = new System.Drawing.Size(437, 315);
            this.ynhDataGridView.TabIndex = 1;
            // 
            // IsDone
            // 
            this.IsDone.HeaderText = "Is done?";
            this.IsDone.Name = "IsDone";
            this.IsDone.ReadOnly = true;
            // 
            // ynhSave
            // 
            this.ynhSave.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ynhSave_DoWork);
            // 
            // ynhLoad
            // 
            this.ynhLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ynhLoad_DoWork);
            this.ynhLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ynhLoad_RunWorkerCompleted);
            // 
            // ynhPictureBotMain
            // 
            this.ynhPictureBotMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ynhPictureBotMain.BackgroundImage = global::YourNameHere.Properties.Resources.ynh_logo;
            this.ynhPictureBotMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ynhPictureBotMain.InitialImage = null;
            this.ynhPictureBotMain.Location = new System.Drawing.Point(12, 12);
            this.ynhPictureBotMain.Name = "ynhPictureBotMain";
            this.ynhPictureBotMain.Size = new System.Drawing.Size(604, 113);
            this.ynhPictureBotMain.TabIndex = 2;
            this.ynhPictureBotMain.TabStop = false;
            // 
            // ynhBtnSave
            // 
            this.ynhBtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ynhBtnSave.Location = new System.Drawing.Point(456, 132);
            this.ynhBtnSave.Name = "ynhBtnSave";
            this.ynhBtnSave.Size = new System.Drawing.Size(160, 44);
            this.ynhBtnSave.TabIndex = 3;
            this.ynhBtnSave.Text = "Save";
            this.btnSaveTooltip.SetToolTip(this.ynhBtnSave, "Save your current letters and options");
            this.ynhBtnSave.UseVisualStyleBackColor = true;
            this.ynhBtnSave.Click += new System.EventHandler(this.ynhBtnSave_Click);
            // 
            // ynhBtnLoad
            // 
            this.ynhBtnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ynhBtnLoad.Location = new System.Drawing.Point(456, 182);
            this.ynhBtnLoad.Name = "ynhBtnLoad";
            this.ynhBtnLoad.Size = new System.Drawing.Size(160, 44);
            this.ynhBtnLoad.TabIndex = 4;
            this.ynhBtnLoad.Text = "Load";
            this.btnSaveTooltip.SetToolTip(this.ynhBtnLoad, "Load a previously saved config.json located in %APPDATA%/YourNameHere/config.json" +
        "");
            this.ynhBtnLoad.UseVisualStyleBackColor = true;
            this.ynhBtnLoad.Click += new System.EventHandler(this.ynhBtnLoad_Click);
            // 
            // ynhBtnSetKeys
            // 
            this.ynhBtnSetKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ynhBtnSetKeys.Location = new System.Drawing.Point(456, 232);
            this.ynhBtnSetKeys.Name = "ynhBtnSetKeys";
            this.ynhBtnSetKeys.Size = new System.Drawing.Size(160, 44);
            this.ynhBtnSetKeys.TabIndex = 5;
            this.ynhBtnSetKeys.Text = "Set keys";
            this.btnSaveTooltip.SetToolTip(this.ynhBtnSetKeys, "Set the current keys to the colors assigned");
            this.ynhBtnSetKeys.UseVisualStyleBackColor = true;
            this.ynhBtnSetKeys.Click += new System.EventHandler(this.ynhBtnSetKeys_Click);
            // 
            // ynhSetKeys
            // 
            this.ynhSetKeys.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ynhSetKeys_DoWork);
            this.ynhSetKeys.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ynhSetKeys_RunWorkerCompleted);
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
            // lettereBindingSource
            // 
            this.lettereBindingSource.DataSource = typeof(YourNameHere.Definitions.Lettere);
            // 
            // ynhMinimizeToTray
            // 
            this.ynhMinimizeToTray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ynhMinimizeToTray.Location = new System.Drawing.Point(455, 402);
            this.ynhMinimizeToTray.Name = "ynhMinimizeToTray";
            this.ynhMinimizeToTray.Size = new System.Drawing.Size(160, 44);
            this.ynhMinimizeToTray.TabIndex = 6;
            this.ynhMinimizeToTray.Text = "Minimize";
            this.btnSaveTooltip.SetToolTip(this.ynhMinimizeToTray, "Minimize the program to the Windows System Tray");
            this.ynhMinimizeToTray.UseVisualStyleBackColor = true;
            this.ynhMinimizeToTray.Click += new System.EventHandler(this.ynhMinimizeToTray_Click);
            // 
            // YourNameHere_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 458);
            this.Controls.Add(this.ynhMinimizeToTray);
            this.Controls.Add(this.ynhBtnSetKeys);
            this.Controls.Add(this.ynhBtnLoad);
            this.Controls.Add(this.ynhBtnSave);
            this.Controls.Add(this.ynhPictureBotMain);
            this.Controls.Add(this.ynhDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YourNameHere_Form";
            this.Text = "YourNameHere";
            this.notifyIconMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ynhDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ynhPictureBotMain)).EndInit();
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
        private System.ComponentModel.BackgroundWorker ynhLoad;
        private System.Windows.Forms.PictureBox ynhPictureBotMain;
        private System.Windows.Forms.Button ynhBtnSave;
        private ToolTip btnSaveTooltip;
        private Button ynhBtnLoad;
        private Button ynhBtnSetKeys;
        private System.ComponentModel.BackgroundWorker ynhSetKeys;
        private Button ynhMinimizeToTray;
    }
}

