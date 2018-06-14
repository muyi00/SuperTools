namespace SuperTools
{
    partial class CreateRecordForm
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
            this.filePath_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selection_file_btn = new System.Windows.Forms.Button();
            this.xp_gp_dg = new System.Windows.Forms.DataGridView();
            this.xp_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gp_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xp_gp_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // filePath_tb
            // 
            this.filePath_tb.Location = new System.Drawing.Point(76, 13);
            this.filePath_tb.Name = "filePath_tb";
            this.filePath_tb.Size = new System.Drawing.Size(334, 21);
            this.filePath_tb.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 29;
            this.label1.Text = "读取文件：";
            // 
            // selection_file_btn
            // 
            this.selection_file_btn.Location = new System.Drawing.Point(416, 11);
            this.selection_file_btn.Name = "selection_file_btn";
            this.selection_file_btn.Size = new System.Drawing.Size(75, 25);
            this.selection_file_btn.TabIndex = 31;
            this.selection_file_btn.Text = "选择文件";
            this.selection_file_btn.UseVisualStyleBackColor = true;
            this.selection_file_btn.Click += new System.EventHandler(this.selection_file_btn_Click);
            // 
            // xp_gp_dg
            // 
            this.xp_gp_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xp_gp_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xp_code,
            this.gp_code});
            this.xp_gp_dg.Location = new System.Drawing.Point(7, 110);
            this.xp_gp_dg.Name = "xp_gp_dg";
            this.xp_gp_dg.ReadOnly = true;
            this.xp_gp_dg.RowHeadersVisible = false;
            this.xp_gp_dg.RowTemplate.Height = 23;
            this.xp_gp_dg.Size = new System.Drawing.Size(250, 508);
            this.xp_gp_dg.TabIndex = 32;
            // 
            // xp_code
            // 
            this.xp_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xp_code.DataPropertyName = "xp_code";
            this.xp_code.HeaderText = "芯片号";
            this.xp_code.Name = "xp_code";
            // 
            // gp_code
            // 
            this.gp_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gp_code.DataPropertyName = "gp_code";
            this.gp_code.HeaderText = "钢瓶号";
            this.gp_code.Name = "gp_code";
            // 
            // CreateRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 630);
            this.Controls.Add(this.xp_gp_dg);
            this.Controls.Add(this.filePath_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selection_file_btn);
            this.Name = "CreateRecordForm";
            this.Text = "CreateRecordForm";
            ((System.ComponentModel.ISupportInitialize)(this.xp_gp_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePath_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selection_file_btn;
        private System.Windows.Forms.DataGridView xp_gp_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn xp_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn gp_code;
    }
}