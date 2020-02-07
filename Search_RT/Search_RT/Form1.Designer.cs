namespace Search_RT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fastTree1 = new FastTreeNS.FastTree();
            this.lb_info = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.sC1 = new System.Windows.Forms.SplitContainer();
            this.tb_Mask = new System.Windows.Forms.TextBox();
            this.lb_mask = new System.Windows.Forms.Label();
            this.tb_directory = new System.Windows.Forms.TextBox();
            this.lb_dir = new System.Windows.Forms.Label();
            this.tLP1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.sC1)).BeginInit();
            this.sC1.Panel1.SuspendLayout();
            this.sC1.Panel2.SuspendLayout();
            this.sC1.SuspendLayout();
            this.tLP1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fastTree1
            // 
            this.fastTree1.AutoScroll = true;
            this.fastTree1.AutoScrollMinSize = new System.Drawing.Size(0, 59);
            this.fastTree1.BackColor = System.Drawing.Color.White;
            this.fastTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastTree1.ImageCheckBoxOff = ((System.Drawing.Image)(resources.GetObject("fastTree1.ImageCheckBoxOff")));
            this.fastTree1.ImageCheckBoxOn = ((System.Drawing.Image)(resources.GetObject("fastTree1.ImageCheckBoxOn")));
            this.fastTree1.ImageCollapse = ((System.Drawing.Image)(resources.GetObject("fastTree1.ImageCollapse")));
            this.fastTree1.ImageDefaultIcon = ((System.Drawing.Image)(resources.GetObject("fastTree1.ImageDefaultIcon")));
            this.fastTree1.ImageEmptyExpand = ((System.Drawing.Image)(resources.GetObject("fastTree1.ImageEmptyExpand")));
            this.fastTree1.ImageExpand = ((System.Drawing.Image)(resources.GetObject("fastTree1.ImageExpand")));
            this.fastTree1.IsEditMode = false;
            this.fastTree1.Location = new System.Drawing.Point(3, 125);
            this.fastTree1.Name = "fastTree1";
            this.fastTree1.ShowExpandBoxes = true;
            this.fastTree1.ShowRootNode = true;
            this.fastTree1.Size = new System.Drawing.Size(881, 484);
            this.fastTree1.TabIndex = 0;
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_info.Location = new System.Drawing.Point(3, 0);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(881, 122);
            this.lb_info.TabIndex = 1;
            this.lb_info.Text = "INFO";
            this.lb_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(12, 247);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(262, 23);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "Остановить поиск";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 218);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(262, 23);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Начать поиск";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.button2_Click);
            // 
            // sC1
            // 
            this.sC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sC1.Location = new System.Drawing.Point(0, 0);
            this.sC1.Name = "sC1";
            // 
            // sC1.Panel1
            // 
            this.sC1.Panel1.Controls.Add(this.tb_Mask);
            this.sC1.Panel1.Controls.Add(this.lb_mask);
            this.sC1.Panel1.Controls.Add(this.tb_directory);
            this.sC1.Panel1.Controls.Add(this.lb_dir);
            this.sC1.Panel1.Controls.Add(this.btn_start);
            this.sC1.Panel1.Controls.Add(this.btn_stop);
            // 
            // sC1.Panel2
            // 
            this.sC1.Panel2.Controls.Add(this.tLP1);
            this.sC1.Size = new System.Drawing.Size(1173, 612);
            this.sC1.SplitterDistance = 282;
            this.sC1.TabIndex = 4;
            // 
            // tb_Mask
            // 
            this.tb_Mask.Location = new System.Drawing.Point(12, 187);
            this.tb_Mask.Multiline = true;
            this.tb_Mask.Name = "tb_Mask";
            this.tb_Mask.Size = new System.Drawing.Size(262, 25);
            this.tb_Mask.TabIndex = 7;
            this.tb_Mask.Text = "*txt";
            // 
            // lb_mask
            // 
            this.lb_mask.AutoSize = true;
            this.lb_mask.Location = new System.Drawing.Point(12, 125);
            this.lb_mask.Name = "lb_mask";
            this.lb_mask.Size = new System.Drawing.Size(74, 13);
            this.lb_mask.TabIndex = 6;
            this.lb_mask.Text = "маска файла";
            // 
            // tb_directory
            // 
            this.tb_directory.Location = new System.Drawing.Point(12, 63);
            this.tb_directory.Multiline = true;
            this.tb_directory.Name = "tb_directory";
            this.tb_directory.Size = new System.Drawing.Size(262, 59);
            this.tb_directory.TabIndex = 5;
            this.tb_directory.Text = "C:\\Program Files";
            // 
            // lb_dir
            // 
            this.lb_dir.AutoSize = true;
            this.lb_dir.Location = new System.Drawing.Point(12, 47);
            this.lb_dir.Name = "lb_dir";
            this.lb_dir.Size = new System.Drawing.Size(122, 13);
            this.lb_dir.TabIndex = 4;
            this.lb_dir.Text = "Стартовая директория";
            // 
            // tLP1
            // 
            this.tLP1.ColumnCount = 1;
            this.tLP1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP1.Controls.Add(this.fastTree1, 0, 1);
            this.tLP1.Controls.Add(this.lb_info, 0, 0);
            this.tLP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP1.Location = new System.Drawing.Point(0, 0);
            this.tLP1.Name = "tLP1";
            this.tLP1.RowCount = 2;
            this.tLP1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tLP1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tLP1.Size = new System.Drawing.Size(887, 612);
            this.tLP1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 612);
            this.Controls.Add(this.sC1);
            this.Name = "Form1";
            this.Text = "S";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.sC1.Panel1.ResumeLayout(false);
            this.sC1.Panel1.PerformLayout();
            this.sC1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sC1)).EndInit();
            this.sC1.ResumeLayout(false);
            this.tLP1.ResumeLayout(false);
            this.tLP1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FastTreeNS.FastTree fastTree1;
        private System.Windows.Forms.Label lb_info;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.SplitContainer sC1;
        private System.Windows.Forms.TableLayoutPanel tLP1;
        private System.Windows.Forms.TextBox tb_Mask;
        private System.Windows.Forms.Label lb_mask;
        private System.Windows.Forms.TextBox tb_directory;
        private System.Windows.Forms.Label lb_dir;
    }
}

