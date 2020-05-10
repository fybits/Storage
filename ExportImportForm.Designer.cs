namespace Storage {
    partial class ExportImportForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pbStatus = new System.Windows.Forms.ProgressBar();
            this.btnClearItems = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(11, 21);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(145, 43);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Импорт";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(11, 70);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(145, 43);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Экспорт";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "csv";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // pbStatus
            // 
            this.pbStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbStatus.Location = new System.Drawing.Point(8, 419);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(784, 23);
            this.pbStatus.TabIndex = 2;
            // 
            // btnClearItems
            // 
            this.btnClearItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(64)))), ((int)(((byte)(53)))));
            this.btnClearItems.FlatAppearance.BorderSize = 0;
            this.btnClearItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClearItems.ForeColor = System.Drawing.Color.White;
            this.btnClearItems.Location = new System.Drawing.Point(629, 21);
            this.btnClearItems.Name = "btnClearItems";
            this.btnClearItems.Size = new System.Drawing.Size(160, 43);
            this.btnClearItems.TabIndex = 3;
            this.btnClearItems.Text = "Очистить каталог";
            this.btnClearItems.UseVisualStyleBackColor = false;
            this.btnClearItems.Click += new System.EventHandler(this.btnClearItems_Click);
            // 
            // info
            // 
            this.info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.info.Location = new System.Drawing.Point(8, 399);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(784, 20);
            this.info.TabIndex = 4;
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExportImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.info);
            this.Controls.Add(this.btnClearItems);
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExportImportForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "ExportImportForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar pbStatus;
        private System.Windows.Forms.Button btnClearItems;
        private System.Windows.Forms.Label info;
    }
}