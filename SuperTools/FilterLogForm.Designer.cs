namespace SuperTools
{
    partial class FilterLogForm
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
            this.readFile_bw = new System.ComponentModel.BackgroundWorker();
            this.filesPath_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.isDistinct = new System.Windows.Forms.CheckBox();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hint_lb = new System.Windows.Forms.Label();
            this.filesPath_out_tb = new System.Windows.Forms.TextBox();
            this.count_dg = new System.Windows.Forms.DataGridView();
            this.isOutCorpCode = new System.Windows.Forms.CheckBox();
            this.isOnlyXpCode = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.read_corpCode_tb = new System.Windows.Forms.TextBox();
            this.selection_outPath_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.read_txt_btn = new System.Windows.Forms.Button();
            this.xpCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corpCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.out_txt_btn = new System.Windows.Forms.Button();
            this.loginfo_dg = new System.Windows.Forms.DataGridView();
            this.file_name_dg = new System.Windows.Forms.DataGridView();
            this.selection_path_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.count_dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginfo_dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.file_name_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // readFile_bw
            // 
            this.readFile_bw.WorkerReportsProgress = true;
            this.readFile_bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.readFile_bw_DoWork);
            this.readFile_bw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.readFile_bw_ProgressChanged);
            this.readFile_bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.readFile_bw_RunWorkerCompleted);
            // 
            // filesPath_tb
            // 
            this.filesPath_tb.Location = new System.Drawing.Point(64, 5);
            this.filesPath_tb.Name = "filesPath_tb";
            this.filesPath_tb.Size = new System.Drawing.Size(334, 21);
            this.filesPath_tb.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "读取路径：";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(3, 614);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(962, 14);
            this.progressBar.TabIndex = 42;
            // 
            // isDistinct
            // 
            this.isDistinct.AutoSize = true;
            this.isDistinct.Checked = true;
            this.isDistinct.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isDistinct.Location = new System.Drawing.Point(658, 7);
            this.isDistinct.Name = "isDistinct";
            this.isDistinct.Size = new System.Drawing.Size(72, 16);
            this.isDistinct.TabIndex = 41;
            this.isDistinct.Text = "过滤重复";
            this.isDistinct.UseVisualStyleBackColor = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "emptyCount";
            this.Column3.HeaderText = "无芯片号";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "count";
            this.Column2.HeaderText = "有芯片号";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "corpCode";
            this.Column1.HeaderText = "企业号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // hint_lb
            // 
            this.hint_lb.AutoSize = true;
            this.hint_lb.Location = new System.Drawing.Point(7, 615);
            this.hint_lb.Name = "hint_lb";
            this.hint_lb.Size = new System.Drawing.Size(0, 12);
            this.hint_lb.TabIndex = 43;
            // 
            // filesPath_out_tb
            // 
            this.filesPath_out_tb.Location = new System.Drawing.Point(64, 40);
            this.filesPath_out_tb.Name = "filesPath_out_tb";
            this.filesPath_out_tb.Size = new System.Drawing.Size(334, 21);
            this.filesPath_out_tb.TabIndex = 33;
            // 
            // count_dg
            // 
            this.count_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.count_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.count_dg.Location = new System.Drawing.Point(616, 68);
            this.count_dg.Name = "count_dg";
            this.count_dg.RowHeadersVisible = false;
            this.count_dg.RowTemplate.Height = 23;
            this.count_dg.Size = new System.Drawing.Size(350, 541);
            this.count_dg.TabIndex = 40;
            // 
            // isOutCorpCode
            // 
            this.isOutCorpCode.AutoSize = true;
            this.isOutCorpCode.Location = new System.Drawing.Point(487, 42);
            this.isOutCorpCode.Name = "isOutCorpCode";
            this.isOutCorpCode.Size = new System.Drawing.Size(84, 16);
            this.isOutCorpCode.TabIndex = 39;
            this.isOutCorpCode.Text = "按企业导出";
            this.isOutCorpCode.UseVisualStyleBackColor = true;
            // 
            // isOnlyXpCode
            // 
            this.isOnlyXpCode.AutoSize = true;
            this.isOnlyXpCode.Location = new System.Drawing.Point(577, 42);
            this.isOnlyXpCode.Name = "isOnlyXpCode";
            this.isOnlyXpCode.Size = new System.Drawing.Size(96, 16);
            this.isOnlyXpCode.TabIndex = 38;
            this.isOnlyXpCode.Text = "只导出芯片号";
            this.isOnlyXpCode.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 37;
            this.label3.Text = "读取企业：";
            // 
            // read_corpCode_tb
            // 
            this.read_corpCode_tb.Location = new System.Drawing.Point(552, 5);
            this.read_corpCode_tb.Name = "read_corpCode_tb";
            this.read_corpCode_tb.Size = new System.Drawing.Size(100, 21);
            this.read_corpCode_tb.TabIndex = 36;
            // 
            // selection_outPath_btn
            // 
            this.selection_outPath_btn.Location = new System.Drawing.Point(404, 38);
            this.selection_outPath_btn.Name = "selection_outPath_btn";
            this.selection_outPath_btn.Size = new System.Drawing.Size(75, 25);
            this.selection_outPath_btn.TabIndex = 35;
            this.selection_outPath_btn.Text = "选择文件夹";
            this.selection_outPath_btn.UseVisualStyleBackColor = true;
            this.selection_outPath_btn.Click += new System.EventHandler(this.selection_outPath_btn_Click);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 32;
            this.label2.Text = "导出路径：";
            // 
            // read_txt_btn
            // 
            this.read_txt_btn.Location = new System.Drawing.Point(891, 3);
            this.read_txt_btn.Name = "read_txt_btn";
            this.read_txt_btn.Size = new System.Drawing.Size(75, 25);
            this.read_txt_btn.TabIndex = 31;
            this.read_txt_btn.Text = "读取文件";
            this.read_txt_btn.UseVisualStyleBackColor = true;
            this.read_txt_btn.Click += new System.EventHandler(this.read_txt_btn_Click);
            // 
            // xpCode
            // 
            this.xpCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xpCode.DataPropertyName = "xpCode";
            this.xpCode.HeaderText = "芯片号";
            this.xpCode.Name = "xpCode";
            // 
            // corpCode
            // 
            this.corpCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.corpCode.DataPropertyName = "corpCode";
            this.corpCode.HeaderText = "企业号";
            this.corpCode.Name = "corpCode";
            // 
            // fileName
            // 
            this.fileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fileName.HeaderText = "文件名称";
            this.fileName.Name = "fileName";
            // 
            // out_txt_btn
            // 
            this.out_txt_btn.Location = new System.Drawing.Point(891, 38);
            this.out_txt_btn.Name = "out_txt_btn";
            this.out_txt_btn.Size = new System.Drawing.Size(75, 25);
            this.out_txt_btn.TabIndex = 34;
            this.out_txt_btn.Text = "导出";
            this.out_txt_btn.UseVisualStyleBackColor = true;
            this.out_txt_btn.Click += new System.EventHandler(this.out_txt_btn_Click);
            // 
            // loginfo_dg
            // 
            this.loginfo_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loginfo_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.corpCode,
            this.xpCode});
            this.loginfo_dg.Location = new System.Drawing.Point(260, 68);
            this.loginfo_dg.Name = "loginfo_dg";
            this.loginfo_dg.RowHeadersVisible = false;
            this.loginfo_dg.RowTemplate.Height = 23;
            this.loginfo_dg.Size = new System.Drawing.Size(350, 541);
            this.loginfo_dg.TabIndex = 30;
            // 
            // file_name_dg
            // 
            this.file_name_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.file_name_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileName});
            this.file_name_dg.Location = new System.Drawing.Point(4, 68);
            this.file_name_dg.Name = "file_name_dg";
            this.file_name_dg.RowHeadersVisible = false;
            this.file_name_dg.RowTemplate.Height = 23;
            this.file_name_dg.Size = new System.Drawing.Size(250, 541);
            this.file_name_dg.TabIndex = 29;
            // 
            // selection_path_btn
            // 
            this.selection_path_btn.Location = new System.Drawing.Point(404, 3);
            this.selection_path_btn.Name = "selection_path_btn";
            this.selection_path_btn.Size = new System.Drawing.Size(75, 25);
            this.selection_path_btn.TabIndex = 28;
            this.selection_path_btn.Text = "选择文件夹";
            this.selection_path_btn.UseVisualStyleBackColor = true;
            this.selection_path_btn.Click += new System.EventHandler(this.selection_path_btn_Click);
            // 
            // FilterLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 630);
            this.Controls.Add(this.filesPath_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.isDistinct);
            this.Controls.Add(this.hint_lb);
            this.Controls.Add(this.filesPath_out_tb);
            this.Controls.Add(this.count_dg);
            this.Controls.Add(this.isOutCorpCode);
            this.Controls.Add(this.isOnlyXpCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.read_corpCode_tb);
            this.Controls.Add(this.selection_outPath_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.read_txt_btn);
            this.Controls.Add(this.out_txt_btn);
            this.Controls.Add(this.loginfo_dg);
            this.Controls.Add(this.file_name_dg);
            this.Controls.Add(this.selection_path_btn);
            this.Name = "FilterLogForm";
            this.Text = "FilterLogForm";
            ((System.ComponentModel.ISupportInitialize)(this.count_dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginfo_dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.file_name_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker readFile_bw;
        private System.Windows.Forms.TextBox filesPath_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox isDistinct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label hint_lb;
        private System.Windows.Forms.TextBox filesPath_out_tb;
        private System.Windows.Forms.DataGridView count_dg;
        private System.Windows.Forms.CheckBox isOutCorpCode;
        private System.Windows.Forms.CheckBox isOnlyXpCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox read_corpCode_tb;
        private System.Windows.Forms.Button selection_outPath_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button read_txt_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn corpCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private System.Windows.Forms.Button out_txt_btn;
        private System.Windows.Forms.DataGridView loginfo_dg;
        private System.Windows.Forms.DataGridView file_name_dg;
        private System.Windows.Forms.Button selection_path_btn;
    }
}