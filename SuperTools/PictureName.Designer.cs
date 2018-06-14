namespace SuperTools
{
    partial class PictureName
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
            this.filesDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.scan_btn = new System.Windows.Forms.Button();
            this.selection_path_btn = new System.Windows.Forms.Button();
            this.filesPath_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newFilesPath_tb = new System.Windows.Forms.TextBox();
            this.save_newpath_btn = new System.Windows.Forms.Button();
            this.newpath_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.regexFileName_tb = new System.Windows.Forms.TextBox();
            this.androidPictureName_cb = new System.Windows.Forms.CheckBox();
            this.hintFileSize_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fileNameToLower_cb = new System.Windows.Forms.CheckBox();
            this.replaceName_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.filesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // filesDataGrid
            // 
            this.filesDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.filesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileName,
            this.fileSize,
            this.newFileName,
            this.newFileSize});
            this.filesDataGrid.Location = new System.Drawing.Point(5, 111);
            this.filesDataGrid.Name = "filesDataGrid";
            this.filesDataGrid.ReadOnly = true;
            this.filesDataGrid.RowHeadersVisible = false;
            this.filesDataGrid.RowTemplate.Height = 23;
            this.filesDataGrid.Size = new System.Drawing.Size(963, 515);
            this.filesDataGrid.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "原路径：";
            // 
            // scan_btn
            // 
            this.scan_btn.Location = new System.Drawing.Point(679, 5);
            this.scan_btn.Name = "scan_btn";
            this.scan_btn.Size = new System.Drawing.Size(91, 23);
            this.scan_btn.TabIndex = 10;
            this.scan_btn.Text = "扫描图片";
            this.scan_btn.UseVisualStyleBackColor = true;
            this.scan_btn.Click += new System.EventHandler(this.scan_btn_Click);
            // 
            // selection_path_btn
            // 
            this.selection_path_btn.Location = new System.Drawing.Point(582, 5);
            this.selection_path_btn.Name = "selection_path_btn";
            this.selection_path_btn.Size = new System.Drawing.Size(91, 23);
            this.selection_path_btn.TabIndex = 9;
            this.selection_path_btn.Text = "选择路径";
            this.selection_path_btn.UseVisualStyleBackColor = true;
            this.selection_path_btn.Click += new System.EventHandler(this.selection_path_btn_Click);
            // 
            // filesPath_tb
            // 
            this.filesPath_tb.Location = new System.Drawing.Point(71, 6);
            this.filesPath_tb.Name = "filesPath_tb";
            this.filesPath_tb.Size = new System.Drawing.Size(496, 21);
            this.filesPath_tb.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "新路径：";
            // 
            // newFilesPath_tb
            // 
            this.newFilesPath_tb.Location = new System.Drawing.Point(71, 58);
            this.newFilesPath_tb.Name = "newFilesPath_tb";
            this.newFilesPath_tb.Size = new System.Drawing.Size(496, 21);
            this.newFilesPath_tb.TabIndex = 13;
            // 
            // save_newpath_btn
            // 
            this.save_newpath_btn.Location = new System.Drawing.Point(679, 57);
            this.save_newpath_btn.Name = "save_newpath_btn";
            this.save_newpath_btn.Size = new System.Drawing.Size(91, 23);
            this.save_newpath_btn.TabIndex = 14;
            this.save_newpath_btn.Text = "另存";
            this.save_newpath_btn.UseVisualStyleBackColor = true;
            this.save_newpath_btn.Click += new System.EventHandler(this.save_newpath_btn_Click);
            // 
            // newpath_btn
            // 
            this.newpath_btn.Location = new System.Drawing.Point(582, 57);
            this.newpath_btn.Name = "newpath_btn";
            this.newpath_btn.Size = new System.Drawing.Size(91, 23);
            this.newpath_btn.TabIndex = 15;
            this.newpath_btn.Text = "新路径";
            this.newpath_btn.UseVisualStyleBackColor = true;
            this.newpath_btn.Click += new System.EventHandler(this.newpath_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "文件名正则校验表达式";
            // 
            // regexFileName_tb
            // 
            this.regexFileName_tb.Location = new System.Drawing.Point(143, 32);
            this.regexFileName_tb.Name = "regexFileName_tb";
            this.regexFileName_tb.Size = new System.Drawing.Size(268, 21);
            this.regexFileName_tb.TabIndex = 20;
            // 
            // androidPictureName_cb
            // 
            this.androidPictureName_cb.AutoSize = true;
            this.androidPictureName_cb.Location = new System.Drawing.Point(429, 34);
            this.androidPictureName_cb.Name = "androidPictureName_cb";
            this.androidPictureName_cb.Size = new System.Drawing.Size(138, 16);
            this.androidPictureName_cb.TabIndex = 16;
            this.androidPictureName_cb.Text = "Android资源名称校验";
            this.androidPictureName_cb.UseVisualStyleBackColor = true;
            // 
            // hintFileSize_tb
            // 
            this.hintFileSize_tb.Location = new System.Drawing.Point(862, 6);
            this.hintFileSize_tb.Name = "hintFileSize_tb";
            this.hintFileSize_tb.Size = new System.Drawing.Size(35, 21);
            this.hintFileSize_tb.TabIndex = 19;
            this.hintFileSize_tb.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(903, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "KB 提示";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(803, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "图片大于";
            // 
            // fileNameToLower_cb
            // 
            this.fileNameToLower_cb.AutoSize = true;
            this.fileNameToLower_cb.Location = new System.Drawing.Point(447, 86);
            this.fileNameToLower_cb.Name = "fileNameToLower_cb";
            this.fileNameToLower_cb.Size = new System.Drawing.Size(120, 16);
            this.fileNameToLower_cb.TabIndex = 24;
            this.fileNameToLower_cb.Text = "文件名字母转小写";
            this.fileNameToLower_cb.UseVisualStyleBackColor = true;
            // 
            // replaceName_tb
            // 
            this.replaceName_tb.Location = new System.Drawing.Point(143, 84);
            this.replaceName_tb.Name = "replaceName_tb";
            this.replaceName_tb.Size = new System.Drawing.Size(268, 21);
            this.replaceName_tb.TabIndex = 22;
            this.replaceName_tb.Text = "-,_;—,_; ,; ,;－,_";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "文件名字符替换";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(96, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "(d,c;)";
            // 
            // fileName
            // 
            this.fileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fileName.HeaderText = "原文件名称";
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            // 
            // fileSize
            // 
            this.fileSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fileSize.HeaderText = "原文件大小";
            this.fileSize.Name = "fileSize";
            this.fileSize.ReadOnly = true;
            // 
            // newFileName
            // 
            this.newFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.newFileName.HeaderText = "新文件名称";
            this.newFileName.Name = "newFileName";
            this.newFileName.ReadOnly = true;
            // 
            // newFileSize
            // 
            this.newFileSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.newFileSize.HeaderText = "新文件大小";
            this.newFileSize.Name = "newFileSize";
            this.newFileSize.ReadOnly = true;
            // 
            // PictureName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 630);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fileNameToLower_cb);
            this.Controls.Add(this.replaceName_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.regexFileName_tb);
            this.Controls.Add(this.androidPictureName_cb);
            this.Controls.Add(this.hintFileSize_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newFilesPath_tb);
            this.Controls.Add(this.save_newpath_btn);
            this.Controls.Add(this.newpath_btn);
            this.Controls.Add(this.filesPath_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scan_btn);
            this.Controls.Add(this.selection_path_btn);
            this.Controls.Add(this.filesDataGrid);
            this.Name = "PictureName";
            this.Text = "PictureName";
            ((System.ComponentModel.ISupportInitialize)(this.filesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView filesDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button scan_btn;
        private System.Windows.Forms.Button selection_path_btn;
        private System.Windows.Forms.TextBox filesPath_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newFilesPath_tb;
        private System.Windows.Forms.Button save_newpath_btn;
        private System.Windows.Forms.Button newpath_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox regexFileName_tb;
        private System.Windows.Forms.CheckBox androidPictureName_cb;
        private System.Windows.Forms.TextBox hintFileSize_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox fileNameToLower_cb;
        private System.Windows.Forms.TextBox replaceName_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn newFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn newFileSize;
    }
}