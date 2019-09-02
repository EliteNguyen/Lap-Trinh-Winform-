namespace Week3
{
    partial class BT1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BT1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCam = new System.Windows.Forms.Button();
            this.btnCafe = new System.Windows.Forms.Button();
            this.btnLipton = new System.Windows.Forms.Button();
            this.btn7up = new System.Windows.Forms.Button();
            this.btnCoca = new System.Windows.Forms.Button();
            this.btnPepsi = new System.Windows.Forms.Button();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnKhoaiTayChien = new System.Windows.Forms.Button();
            this.btnComGa = new System.Windows.Forms.Button();
            this.btnGaVien = new System.Windows.Forms.Button();
            this.btnTomVien = new System.Windows.Forms.Button();
            this.grvDSMonAn = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGaRan = new System.Windows.Forms.Button();
            this.bntPMC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPMG = new System.Windows.Forms.Button();
            this.btnPMT = new System.Windows.Forms.Button();
            this.btnPMB = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvDSMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "clear.png");
            this.imageList1.Images.SetKeyName(1, "del1.png");
            this.imageList1.Images.SetKeyName(2, "ok.png");
            // 
            // btnCam
            // 
            this.btnCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCam.ForeColor = System.Drawing.Color.Red;
            this.btnCam.Location = new System.Drawing.Point(376, 80);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(71, 23);
            this.btnCam.TabIndex = 14;
            this.btnCam.Text = "Cam";
            this.btnCam.UseVisualStyleBackColor = true;
            this.btnCam.Click += new System.EventHandler(this.btnPMB_Click);
            // 
            // btnCafe
            // 
            this.btnCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCafe.ForeColor = System.Drawing.Color.Red;
            this.btnCafe.Location = new System.Drawing.Point(302, 80);
            this.btnCafe.Name = "btnCafe";
            this.btnCafe.Size = new System.Drawing.Size(68, 23);
            this.btnCafe.TabIndex = 13;
            this.btnCafe.Text = "Cà phê";
            this.btnCafe.UseVisualStyleBackColor = true;
            this.btnCafe.Click += new System.EventHandler(this.btnPMB_Click);
            // 
            // btnLipton
            // 
            this.btnLipton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLipton.ForeColor = System.Drawing.Color.Red;
            this.btnLipton.Location = new System.Drawing.Point(376, 51);
            this.btnLipton.Name = "btnLipton";
            this.btnLipton.Size = new System.Drawing.Size(71, 23);
            this.btnLipton.TabIndex = 12;
            this.btnLipton.Text = "Lipton";
            this.btnLipton.UseVisualStyleBackColor = true;
            this.btnLipton.Click += new System.EventHandler(this.btnPMB_Click);
            // 
            // btn7up
            // 
            this.btn7up.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7up.ForeColor = System.Drawing.Color.Red;
            this.btn7up.Location = new System.Drawing.Point(302, 51);
            this.btn7up.Name = "btn7up";
            this.btn7up.Size = new System.Drawing.Size(68, 23);
            this.btn7up.TabIndex = 11;
            this.btn7up.Text = "7up";
            this.btn7up.UseVisualStyleBackColor = true;
            this.btn7up.Click += new System.EventHandler(this.btnPMB_Click);
            // 
            // btnCoca
            // 
            this.btnCoca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoca.ForeColor = System.Drawing.Color.Red;
            this.btnCoca.Location = new System.Drawing.Point(376, 22);
            this.btnCoca.Name = "btnCoca";
            this.btnCoca.Size = new System.Drawing.Size(71, 23);
            this.btnCoca.TabIndex = 10;
            this.btnCoca.Text = "Coca";
            this.btnCoca.UseVisualStyleBackColor = true;
            this.btnCoca.Click += new System.EventHandler(this.btnPMB_Click);
            // 
            // btnPepsi
            // 
            this.btnPepsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPepsi.ForeColor = System.Drawing.Color.Red;
            this.btnPepsi.Location = new System.Drawing.Point(302, 22);
            this.btnPepsi.Name = "btnPepsi";
            this.btnPepsi.Size = new System.Drawing.Size(68, 23);
            this.btnPepsi.TabIndex = 9;
            this.btnPepsi.Text = "Pepsi";
            this.btnPepsi.UseVisualStyleBackColor = true;
            this.btnPepsi.Click += new System.EventHandler(this.btnPMB_Click);
            // 
            // cbTable
            // 
            this.cbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTable.FormattingEnabled = true;
            this.cbTable.ItemHeight = 20;
            this.cbTable.Location = new System.Drawing.Point(207, 259);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(173, 28);
            this.cbTable.TabIndex = 27;
            // 
            // btnOrder
            // 
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.ImageList = this.imageList1;
            this.btnOrder.Location = new System.Drawing.Point(435, 258);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(67, 29);
            this.btnOrder.TabIndex = 26;
            this.btnOrder.Tag = "";
            this.btnOrder.Text = "Order";
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnKhoaiTayChien
            // 
            this.btnKhoaiTayChien.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnKhoaiTayChien.Location = new System.Drawing.Point(302, 109);
            this.btnKhoaiTayChien.Name = "btnKhoaiTayChien";
            this.btnKhoaiTayChien.Size = new System.Drawing.Size(145, 23);
            this.btnKhoaiTayChien.TabIndex = 8;
            this.btnKhoaiTayChien.Tag = "";
            this.btnKhoaiTayChien.Text = "Khoai tây chiên";
            this.btnKhoaiTayChien.UseVisualStyleBackColor = true;
            this.btnKhoaiTayChien.Click += new System.EventHandler(this.btnPMB_Click);
            // 
            // btnComGa
            // 
            this.btnComGa.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnComGa.Location = new System.Drawing.Point(162, 109);
            this.btnComGa.Name = "btnComGa";
            this.btnComGa.Size = new System.Drawing.Size(121, 23);
            this.btnComGa.TabIndex = 7;
            this.btnComGa.Tag = "";
            this.btnComGa.Text = "Cơm gà Tender";
            this.btnComGa.UseVisualStyleBackColor = true;
            this.btnComGa.Click += new System.EventHandler(this.btnPMB_Click);
            // 
            // btnGaVien
            // 
            this.btnGaVien.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGaVien.Location = new System.Drawing.Point(162, 51);
            this.btnGaVien.Name = "btnGaVien";
            this.btnGaVien.Size = new System.Drawing.Size(121, 23);
            this.btnGaVien.TabIndex = 5;
            this.btnGaVien.Text = "Gà viên Cola";
            this.btnGaVien.UseVisualStyleBackColor = true;
            this.btnGaVien.Click += new System.EventHandler(this.btnPMB_Click);
            // 
            // btnTomVien
            // 
            this.btnTomVien.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTomVien.Location = new System.Drawing.Point(162, 22);
            this.btnTomVien.Name = "btnTomVien";
            this.btnTomVien.Size = new System.Drawing.Size(121, 23);
            this.btnTomVien.TabIndex = 4;
            this.btnTomVien.Text = "Tôm viên Cola";
            this.btnTomVien.UseVisualStyleBackColor = true;
            this.btnTomVien.Click += new System.EventHandler(this.btnPMB_Click);
            // 
            // grvDSMonAn
            // 
            this.grvDSMonAn.AllowUserToAddRows = false;
            this.grvDSMonAn.AllowUserToDeleteRows = false;
            this.grvDSMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDSMonAn.Location = new System.Drawing.Point(28, 296);
            this.grvDSMonAn.Name = "grvDSMonAn";
            this.grvDSMonAn.ReadOnly = true;
            this.grvDSMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvDSMonAn.Size = new System.Drawing.Size(473, 176);
            this.grvDSMonAn.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Week3.Properties.Resources.order;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(98, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 64);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnGaRan
            // 
            this.btnGaRan.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGaRan.Location = new System.Drawing.Point(162, 80);
            this.btnGaRan.Name = "btnGaRan";
            this.btnGaRan.Size = new System.Drawing.Size(121, 23);
            this.btnGaRan.TabIndex = 6;
            this.btnGaRan.Text = "Gà rán phần";
            this.btnGaRan.UseVisualStyleBackColor = true;
            this.btnGaRan.Click += new System.EventHandler(this.btnPMB_Click);
            // 
            // bntPMC
            // 
            this.bntPMC.ForeColor = System.Drawing.Color.Red;
            this.bntPMC.Location = new System.Drawing.Point(22, 109);
            this.bntPMC.Name = "bntPMC";
            this.bntPMC.Size = new System.Drawing.Size(121, 23);
            this.bntPMC.TabIndex = 3;
            this.bntPMC.Tag = "";
            this.bntPMC.Text = "Bunger Phô mai Cá";
            this.bntPMC.UseVisualStyleBackColor = true;
            this.bntPMC.Click += new System.EventHandler(this.btnPMB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên bàn:";
            // 
            // btnPMG
            // 
            this.btnPMG.ForeColor = System.Drawing.Color.Red;
            this.btnPMG.Location = new System.Drawing.Point(22, 80);
            this.btnPMG.Name = "btnPMG";
            this.btnPMG.Size = new System.Drawing.Size(121, 23);
            this.btnPMG.TabIndex = 2;
            this.btnPMG.Text = "Bunger Phô mai Gà";
            this.btnPMG.UseVisualStyleBackColor = true;
            this.btnPMG.Click += new System.EventHandler(this.btnPMB_Click);
            // 
            // btnPMT
            // 
            this.btnPMT.ForeColor = System.Drawing.Color.Red;
            this.btnPMT.Location = new System.Drawing.Point(22, 51);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(121, 23);
            this.btnPMT.TabIndex = 1;
            this.btnPMT.Text = "Bunger Phô mai Tôm";
            this.btnPMT.UseVisualStyleBackColor = true;
            this.btnPMT.Click += new System.EventHandler(this.btnPMB_Click);
            // 
            // btnPMB
            // 
            this.btnPMB.ForeColor = System.Drawing.Color.Red;
            this.btnPMB.Location = new System.Drawing.Point(22, 22);
            this.btnPMB.Name = "btnPMB";
            this.btnPMB.Size = new System.Drawing.Size(121, 23);
            this.btnPMB.TabIndex = 0;
            this.btnPMB.Text = "Bunger Phô mai Bò";
            this.btnPMB.UseVisualStyleBackColor = true;
            this.btnPMB.Click += new System.EventHandler(this.btnPMB_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.ImageList = this.imageList1;
            this.btnClear.Location = new System.Drawing.Point(28, 258);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 29);
            this.btnClear.TabIndex = 24;
            this.btnClear.Tag = "";
            this.btnClear.Text = "Xóa";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCam);
            this.groupBox1.Controls.Add(this.btnCafe);
            this.groupBox1.Controls.Add(this.btnLipton);
            this.groupBox1.Controls.Add(this.btn7up);
            this.groupBox1.Controls.Add(this.btnCoca);
            this.groupBox1.Controls.Add(this.btnPepsi);
            this.groupBox1.Controls.Add(this.btnKhoaiTayChien);
            this.groupBox1.Controls.Add(this.btnComGa);
            this.groupBox1.Controls.Add(this.btnGaRan);
            this.groupBox1.Controls.Add(this.btnGaVien);
            this.groupBox1.Controls.Add(this.btnTomVien);
            this.groupBox1.Controls.Add(this.bntPMC);
            this.groupBox1.Controls.Add(this.btnPMG);
            this.groupBox1.Controls.Add(this.btnPMT);
            this.groupBox1.Controls.Add(this.btnPMB);
            this.groupBox1.Location = new System.Drawing.Point(27, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 144);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách món ăn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(183, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fast Food Order";
            // 
            // BT1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 511);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grvDSMonAn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "BT1";
            this.Text = "Fastfood Order";
            this.Load += new System.EventHandler(this.BT1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvDSMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.Button btnCafe;
        private System.Windows.Forms.Button btnLipton;
        private System.Windows.Forms.Button btn7up;
        private System.Windows.Forms.Button btnCoca;
        private System.Windows.Forms.Button btnPepsi;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnKhoaiTayChien;
        private System.Windows.Forms.Button btnComGa;
        private System.Windows.Forms.Button btnGaVien;
        private System.Windows.Forms.Button btnTomVien;
        private System.Windows.Forms.DataGridView grvDSMonAn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGaRan;
        private System.Windows.Forms.Button bntPMC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPMG;
        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.Button btnPMB;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

