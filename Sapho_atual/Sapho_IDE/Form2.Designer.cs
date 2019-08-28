namespace Sapho_IDE
{
    partial class Form_AddProc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddProc));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_nbitsexp = new System.Windows.Forms.TextBox();
            this.tb_nbitsmant = new System.Windows.Forms.TextBox();
            this.tb_nubits = new System.Windows.Forms.TextBox();
            this.lb_nbitexp = new System.Windows.Forms.Label();
            this.lb_nbitmant = new System.Windows.Forms.Label();
            this.lb_nbitfix = new System.Windows.Forms.Label();
            this.rb_float = new System.Windows.Forms.RadioButton();
            this.rb_fix = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_nioout = new System.Windows.Forms.TextBox();
            this.tb_nioin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_generate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_instrstack = new System.Windows.Forms.TextBox();
            this.tb_datastack = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_procname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_nbitsexp);
            this.groupBox2.Controls.Add(this.tb_nbitsmant);
            this.groupBox2.Controls.Add(this.tb_nubits);
            this.groupBox2.Controls.Add(this.lb_nbitexp);
            this.groupBox2.Controls.Add(this.lb_nbitmant);
            this.groupBox2.Controls.Add(this.lb_nbitfix);
            this.groupBox2.Controls.Add(this.rb_float);
            this.groupBox2.Controls.Add(this.rb_fix);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ULA Settings:";
            // 
            // tb_nbitsexp
            // 
            this.tb_nbitsexp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nbitsexp.Location = new System.Drawing.Point(362, 58);
            this.tb_nbitsexp.Name = "tb_nbitsexp";
            this.tb_nbitsexp.Size = new System.Drawing.Size(44, 20);
            this.tb_nbitsexp.TabIndex = 6;
            // 
            // tb_nbitsmant
            // 
            this.tb_nbitsmant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nbitsmant.Location = new System.Drawing.Point(215, 58);
            this.tb_nbitsmant.Name = "tb_nbitsmant";
            this.tb_nbitsmant.Size = new System.Drawing.Size(44, 20);
            this.tb_nbitsmant.TabIndex = 5;
            // 
            // tb_nubits
            // 
            this.tb_nubits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nubits.Location = new System.Drawing.Point(58, 58);
            this.tb_nubits.Name = "tb_nubits";
            this.tb_nubits.Size = new System.Drawing.Size(44, 20);
            this.tb_nubits.TabIndex = 4;
            // 
            // lb_nbitexp
            // 
            this.lb_nbitexp.AutoSize = true;
            this.lb_nbitexp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nbitexp.Location = new System.Drawing.Point(268, 61);
            this.lb_nbitexp.Name = "lb_nbitexp";
            this.lb_nbitexp.Size = new System.Drawing.Size(88, 16);
            this.lb_nbitexp.TabIndex = 15;
            this.lb_nbitexp.Text = "Nb Exponent:";
            // 
            // lb_nbitmant
            // 
            this.lb_nbitmant.AutoSize = true;
            this.lb_nbitmant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nbitmant.Location = new System.Drawing.Point(123, 61);
            this.lb_nbitmant.Name = "lb_nbitmant";
            this.lb_nbitmant.Size = new System.Drawing.Size(86, 16);
            this.lb_nbitmant.TabIndex = 13;
            this.lb_nbitmant.Text = "Nb Mantissa:";
            // 
            // lb_nbitfix
            // 
            this.lb_nbitfix.AutoSize = true;
            this.lb_nbitfix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nbitfix.Location = new System.Drawing.Point(6, 61);
            this.lb_nbitfix.Name = "lb_nbitfix";
            this.lb_nbitfix.Size = new System.Drawing.Size(45, 16);
            this.lb_nbitfix.TabIndex = 11;
            this.lb_nbitfix.Text = "N bits:";
            this.lb_nbitfix.Click += new System.EventHandler(this.lb_nbitfix_Click);
            // 
            // rb_float
            // 
            this.rb_float.AutoSize = true;
            this.rb_float.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_float.Location = new System.Drawing.Point(249, 26);
            this.rb_float.Name = "rb_float";
            this.rb_float.Size = new System.Drawing.Size(107, 20);
            this.rb_float.TabIndex = 3;
            this.rb_float.TabStop = true;
            this.rb_float.Text = "Floating Point";
            this.rb_float.UseVisualStyleBackColor = true;
            this.rb_float.CheckedChanged += new System.EventHandler(this.rb_float_CheckedChanged);
            // 
            // rb_fix
            // 
            this.rb_fix.AutoSize = true;
            this.rb_fix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_fix.Location = new System.Drawing.Point(131, 26);
            this.rb_fix.Name = "rb_fix";
            this.rb_fix.Size = new System.Drawing.Size(92, 20);
            this.rb_fix.TabIndex = 2;
            this.rb_fix.TabStop = true;
            this.rb_fix.Text = "Fixed Point";
            this.rb_fix.UseVisualStyleBackColor = true;
            this.rb_fix.CheckedChanged += new System.EventHandler(this.rb_fix_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Processor Type:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_nioout);
            this.groupBox4.Controls.Add(this.tb_nioin);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 257);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(435, 64);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "I/O Settings:";
            // 
            // tb_nioout
            // 
            this.tb_nioout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nioout.Location = new System.Drawing.Point(362, 27);
            this.tb_nioout.Name = "tb_nioout";
            this.tb_nioout.Size = new System.Drawing.Size(44, 20);
            this.tb_nioout.TabIndex = 10;
            // 
            // tb_nioin
            // 
            this.tb_nioin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nioin.Location = new System.Drawing.Point(149, 27);
            this.tb_nioin.Name = "tb_nioin";
            this.tb_nioin.Size = new System.Drawing.Size(44, 20);
            this.tb_nioin.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Number of Output Ports:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Number of Input Ports:";
            // 
            // bt_generate
            // 
            this.bt_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_generate.Location = new System.Drawing.Point(161, 332);
            this.bt_generate.Name = "bt_generate";
            this.bt_generate.Size = new System.Drawing.Size(136, 23);
            this.bt_generate.TabIndex = 11;
            this.bt_generate.Text = "Generate";
            this.bt_generate.UseVisualStyleBackColor = true;
            this.bt_generate.Click += new System.EventHandler(this.bt_generate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_instrstack);
            this.groupBox3.Controls.Add(this.tb_datastack);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 64);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Memory Stack Settings:";
            // 
            // tb_instrstack
            // 
            this.tb_instrstack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_instrstack.Location = new System.Drawing.Point(336, 27);
            this.tb_instrstack.Name = "tb_instrstack";
            this.tb_instrstack.Size = new System.Drawing.Size(44, 20);
            this.tb_instrstack.TabIndex = 8;
            // 
            // tb_datastack
            // 
            this.tb_datastack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_datastack.Location = new System.Drawing.Point(121, 27);
            this.tb_datastack.Name = "tb_datastack";
            this.tb_datastack.Size = new System.Drawing.Size(44, 20);
            this.tb_datastack.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Instruction Stack Size:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data Stack Size:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_procname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 64);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Settings:";
            // 
            // tb_procname
            // 
            this.tb_procname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_procname.Location = new System.Drawing.Point(130, 28);
            this.tb_procname.Name = "tb_procname";
            this.tb_procname.Size = new System.Drawing.Size(297, 20);
            this.tb_procname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Processor Name:";
            // 
            // Form_AddProc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bt_generate);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_AddProc";
            this.Text = "Configuration Wizzard";
            this.Load += new System.EventHandler(this.Form_AddProc_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lb_nbitexp;
        public System.Windows.Forms.Label lb_nbitmant;
        public System.Windows.Forms.Label lb_nbitfix;
        private System.Windows.Forms.RadioButton rb_float;
        private System.Windows.Forms.RadioButton rb_fix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button bt_generate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_procname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nbitsexp;
        private System.Windows.Forms.TextBox tb_nbitsmant;
        private System.Windows.Forms.TextBox tb_nubits;
        private System.Windows.Forms.TextBox tb_nioout;
        private System.Windows.Forms.TextBox tb_nioin;
        private System.Windows.Forms.TextBox tb_instrstack;
        private System.Windows.Forms.TextBox tb_datastack;
    }
}