namespace ThuctapQLK.Gui
{
    partial class UC_NCC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_tenNCC = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_maNCC = new System.Windows.Forms.TextBox();
            this.txttenNCC = new System.Windows.Forms.Label();
            this.txtmaHH = new System.Windows.Forms.Label();
            this.txtdonGia = new System.Windows.Forms.Label();
            this.txtngayLap = new System.Windows.Forms.Label();
            this.txtmaNCC = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnluu.Location = new System.Drawing.Point(526, 220);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(70, 33);
            this.btnluu.TabIndex = 54;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxoa.Location = new System.Drawing.Point(450, 220);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(70, 33);
            this.btnxoa.TabIndex = 55;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsua.Location = new System.Drawing.Point(374, 220);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(70, 33);
            this.btnsua.TabIndex = 56;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthem.Location = new System.Drawing.Point(288, 223);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(70, 33);
            this.btnthem.TabIndex = 57;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgvNCC
            // 
            this.dgvNCC.AllowUserToAddRows = false;
            this.dgvNCC.AllowUserToDeleteRows = false;
            this.dgvNCC.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNCC.Location = new System.Drawing.Point(0, 298);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.Size = new System.Drawing.Size(601, 126);
            this.dgvNCC.TabIndex = 53;
            this.dgvNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhaCC_CellContentClick);
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(364, 168);
            this.txt_SDT.Multiline = true;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(163, 25);
            this.txt_SDT.TabIndex = 52;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(96, 223);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(161, 26);
            this.txt_email.TabIndex = 50;
            // 
            // txt_tenNCC
            // 
            this.txt_tenNCC.Location = new System.Drawing.Point(96, 168);
            this.txt_tenNCC.Multiline = true;
            this.txt_tenNCC.Name = "txt_tenNCC";
            this.txt_tenNCC.Size = new System.Drawing.Size(161, 25);
            this.txt_tenNCC.TabIndex = 51;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Location = new System.Drawing.Point(364, 121);
            this.txt_diaChi.Multiline = true;
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(163, 26);
            this.txt_diaChi.TabIndex = 49;
            // 
            // txt_maNCC
            // 
            this.txt_maNCC.Location = new System.Drawing.Point(96, 121);
            this.txt_maNCC.Multiline = true;
            this.txt_maNCC.Name = "txt_maNCC";
            this.txt_maNCC.Size = new System.Drawing.Size(161, 26);
            this.txt_maNCC.TabIndex = 48;
            // 
            // txttenNCC
            // 
            this.txttenNCC.AutoSize = true;
            this.txttenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenNCC.Location = new System.Drawing.Point(20, 177);
            this.txttenNCC.Name = "txttenNCC";
            this.txttenNCC.Size = new System.Drawing.Size(70, 16);
            this.txttenNCC.TabIndex = 47;
            this.txttenNCC.Text = "Tên NCC";
            // 
            // txtmaHH
            // 
            this.txtmaHH.AutoSize = true;
            this.txtmaHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaHH.Location = new System.Drawing.Point(301, 131);
            this.txtmaHH.Name = "txtmaHH";
            this.txtmaHH.Size = new System.Drawing.Size(57, 16);
            this.txtmaHH.TabIndex = 43;
            this.txtmaHH.Text = "Địa Chỉ";
            // 
            // txtdonGia
            // 
            this.txtdonGia.AutoSize = true;
            this.txtdonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdonGia.Location = new System.Drawing.Point(301, 177);
            this.txtdonGia.Name = "txtdonGia";
            this.txtdonGia.Size = new System.Drawing.Size(51, 16);
            this.txtdonGia.TabIndex = 44;
            this.txtdonGia.Text = "Số ĐT";
            // 
            // txtngayLap
            // 
            this.txtngayLap.AutoSize = true;
            this.txtngayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngayLap.Location = new System.Drawing.Point(26, 223);
            this.txtngayLap.Name = "txtngayLap";
            this.txtngayLap.Size = new System.Drawing.Size(47, 16);
            this.txtngayLap.TabIndex = 45;
            this.txtngayLap.Text = "Email";
            // 
            // txtmaNCC
            // 
            this.txtmaNCC.AutoSize = true;
            this.txtmaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaNCC.Location = new System.Drawing.Point(26, 131);
            this.txtmaNCC.Name = "txtmaNCC";
            this.txtmaNCC.Size = new System.Drawing.Size(64, 16);
            this.txtmaNCC.TabIndex = 46;
            this.txtmaNCC.Text = "Mã NCC";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 93);
            this.panel1.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(183, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÀ CUNG CẤP";
            // 
            // UC_NCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvNCC);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_tenNCC);
            this.Controls.Add(this.txt_diaChi);
            this.Controls.Add(this.txt_maNCC);
            this.Controls.Add(this.txttenNCC);
            this.Controls.Add(this.txtmaHH);
            this.Controls.Add(this.txtdonGia);
            this.Controls.Add(this.txtngayLap);
            this.Controls.Add(this.txtmaNCC);
            this.Name = "UC_NCC";
            this.Size = new System.Drawing.Size(601, 424);
            this.Load += new System.EventHandler(this.NCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_tenNCC;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.TextBox txt_maNCC;
        private System.Windows.Forms.Label txttenNCC;
        private System.Windows.Forms.Label txtmaHH;
        private System.Windows.Forms.Label txtdonGia;
        private System.Windows.Forms.Label txtngayLap;
        private System.Windows.Forms.Label txtmaNCC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
