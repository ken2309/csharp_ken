namespace NguyenQuangKhai
{
    partial class fAdmin
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
            this.asd = new System.Windows.Forms.TabControl();
            this.tpAccList = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_search_account = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgv_account = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_view_account = new System.Windows.Forms.Button();
            this.btn_edit_account = new System.Windows.Forms.Button();
            this.btn_delete_account = new System.Windows.Forms.Button();
            this.btn_add_account = new System.Windows.Forms.Button();
            this.tpAcc = new System.Windows.Forms.TabPage();
            this.asd.SuspendLayout();
            this.tpAccList.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_account)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // asd
            // 
            this.asd.Controls.Add(this.tpAccList);
            this.asd.Controls.Add(this.tpAcc);
            this.asd.Location = new System.Drawing.Point(13, 13);
            this.asd.Name = "asd";
            this.asd.SelectedIndex = 0;
            this.asd.Size = new System.Drawing.Size(714, 425);
            this.asd.TabIndex = 0;
            this.asd.Tag = "";
            // 
            // tpAccList
            // 
            this.tpAccList.Controls.Add(this.panel4);
            this.tpAccList.Controls.Add(this.panel3);
            this.tpAccList.Controls.Add(this.panel2);
            this.tpAccList.Controls.Add(this.panel1);
            this.tpAccList.Location = new System.Drawing.Point(4, 22);
            this.tpAccList.Name = "tpAccList";
            this.tpAccList.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccList.Size = new System.Drawing.Size(706, 399);
            this.tpAccList.TabIndex = 0;
            this.tpAccList.Text = "Danh sách tài khoản";
            this.tpAccList.UseVisualStyleBackColor = true;
            this.tpAccList.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.btn_search_account);
            this.panel4.Location = new System.Drawing.Point(364, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 30);
            this.panel4.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 20);
            this.textBox1.TabIndex = 6;
            // 
            // btn_search_account
            // 
            this.btn_search_account.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_search_account.Location = new System.Drawing.Point(249, 3);
            this.btn_search_account.Name = "btn_search_account";
            this.btn_search_account.Size = new System.Drawing.Size(81, 20);
            this.btn_search_account.TabIndex = 5;
            this.btn_search_account.Text = "Tìm";
            this.btn_search_account.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(364, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 348);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 44);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(40, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(287, 20);
            this.textBox2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgv_account);
            this.panel2.Location = new System.Drawing.Point(6, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 310);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dtgv_account
            // 
            this.dtgv_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_account.Location = new System.Drawing.Point(3, 3);
            this.dtgv_account.Name = "dtgv_account";
            this.dtgv_account.Size = new System.Drawing.Size(342, 304);
            this.dtgv_account.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_view_account);
            this.panel1.Controls.Add(this.btn_edit_account);
            this.panel1.Controls.Add(this.btn_delete_account);
            this.panel1.Controls.Add(this.btn_add_account);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 71);
            this.panel1.TabIndex = 0;
            // 
            // btn_view_account
            // 
            this.btn_view_account.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_view_account.Location = new System.Drawing.Point(264, 3);
            this.btn_view_account.Name = "btn_view_account";
            this.btn_view_account.Size = new System.Drawing.Size(81, 65);
            this.btn_view_account.TabIndex = 4;
            this.btn_view_account.Text = "Xem";
            this.btn_view_account.UseVisualStyleBackColor = false;
            // 
            // btn_edit_account
            // 
            this.btn_edit_account.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_edit_account.Location = new System.Drawing.Point(177, 3);
            this.btn_edit_account.Name = "btn_edit_account";
            this.btn_edit_account.Size = new System.Drawing.Size(81, 65);
            this.btn_edit_account.TabIndex = 3;
            this.btn_edit_account.Text = "Sửa";
            this.btn_edit_account.UseVisualStyleBackColor = false;
            // 
            // btn_delete_account
            // 
            this.btn_delete_account.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_delete_account.Location = new System.Drawing.Point(90, 3);
            this.btn_delete_account.Name = "btn_delete_account";
            this.btn_delete_account.Size = new System.Drawing.Size(81, 65);
            this.btn_delete_account.TabIndex = 2;
            this.btn_delete_account.Text = "Xóa";
            this.btn_delete_account.UseVisualStyleBackColor = false;
            // 
            // btn_add_account
            // 
            this.btn_add_account.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_add_account.Location = new System.Drawing.Point(3, 3);
            this.btn_add_account.Name = "btn_add_account";
            this.btn_add_account.Size = new System.Drawing.Size(81, 65);
            this.btn_add_account.TabIndex = 1;
            this.btn_add_account.Text = "Thêm";
            this.btn_add_account.UseVisualStyleBackColor = false;
            this.btn_add_account.Click += new System.EventHandler(this.button1_Click);
            // 
            // tpAcc
            // 
            this.tpAcc.Location = new System.Drawing.Point(4, 22);
            this.tpAcc.Name = "tpAcc";
            this.tpAcc.Padding = new System.Windows.Forms.Padding(3);
            this.tpAcc.Size = new System.Drawing.Size(706, 399);
            this.tpAcc.TabIndex = 1;
            this.tpAcc.Text = "Thông tin cá nhân";
            this.tpAcc.UseVisualStyleBackColor = true;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.asd);
            this.Name = "fAdmin";
            this.Text = "fAdmin";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            this.asd.ResumeLayout(false);
            this.tpAccList.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_account)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl asd;
        private System.Windows.Forms.TabPage tpAccList;
        private System.Windows.Forms.TabPage tpAcc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add_account;
        private System.Windows.Forms.Button btn_view_account;
        private System.Windows.Forms.Button btn_edit_account;
        private System.Windows.Forms.Button btn_delete_account;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgv_account;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_search_account;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}