namespace Automatas_de_pila
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
            this.rbL1 = new System.Windows.Forms.RadioButton();
            this.rbL2 = new System.Windows.Forms.RadioButton();
            this.rbL3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.txtP3 = new System.Windows.Forms.TextBox();
            this.txtP4 = new System.Windows.Forms.TextBox();
            this.txtP5 = new System.Windows.Forms.TextBox();
            this.txtP6 = new System.Windows.Forms.TextBox();
            this.btnCom = new System.Windows.Forms.Button();
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblP6 = new System.Windows.Forms.Label();
            this.lblP5 = new System.Windows.Forms.Label();
            this.lblP4 = new System.Windows.Forms.Label();
            this.lblP3 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.pbL3 = new System.Windows.Forms.PictureBox();
            this.pbL2 = new System.Windows.Forms.PictureBox();
            this.pbL1 = new System.Windows.Forms.PictureBox();
            this.lblAutomata = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbL3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbL1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbL1
            // 
            this.rbL1.AutoSize = true;
            this.rbL1.Location = new System.Drawing.Point(15, 69);
            this.rbL1.Name = "rbL1";
            this.rbL1.Size = new System.Drawing.Size(116, 17);
            this.rbL1.TabIndex = 0;
            this.rbL1.TabStop = true;
            this.rbL1.Text = "L = {a^n b^n | n>0}";
            this.rbL1.UseVisualStyleBackColor = true;
            this.rbL1.CheckedChanged += new System.EventHandler(this.rbL1_CheckedChanged);
            // 
            // rbL2
            // 
            this.rbL2.AutoSize = true;
            this.rbL2.Location = new System.Drawing.Point(15, 110);
            this.rbL2.Name = "rbL2";
            this.rbL2.Size = new System.Drawing.Size(122, 17);
            this.rbL2.TabIndex = 1;
            this.rbL2.TabStop = true;
            this.rbL2.Text = "L = {a^n b^n | n>=0}";
            this.rbL2.UseVisualStyleBackColor = true;
            this.rbL2.CheckedChanged += new System.EventHandler(this.rbL1_CheckedChanged);
            // 
            // rbL3
            // 
            this.rbL3.AutoSize = true;
            this.rbL3.Location = new System.Drawing.Point(15, 149);
            this.rbL3.Name = "rbL3";
            this.rbL3.Size = new System.Drawing.Size(122, 17);
            this.rbL3.TabIndex = 2;
            this.rbL3.TabStop = true;
            this.rbL3.Text = "L = {a^n b^2n | n>0}";
            this.rbL3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escoge un lenguaje:";
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(529, 50);
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(100, 20);
            this.txtP1.TabIndex = 5;
            // 
            // txtP2
            // 
            this.txtP2.Location = new System.Drawing.Point(529, 78);
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(100, 20);
            this.txtP2.TabIndex = 6;
            // 
            // txtP3
            // 
            this.txtP3.Location = new System.Drawing.Point(529, 104);
            this.txtP3.Name = "txtP3";
            this.txtP3.Size = new System.Drawing.Size(100, 20);
            this.txtP3.TabIndex = 7;
            // 
            // txtP4
            // 
            this.txtP4.Location = new System.Drawing.Point(529, 130);
            this.txtP4.Name = "txtP4";
            this.txtP4.Size = new System.Drawing.Size(100, 20);
            this.txtP4.TabIndex = 8;
            // 
            // txtP5
            // 
            this.txtP5.Location = new System.Drawing.Point(529, 154);
            this.txtP5.Name = "txtP5";
            this.txtP5.Size = new System.Drawing.Size(100, 20);
            this.txtP5.TabIndex = 9;
            // 
            // txtP6
            // 
            this.txtP6.Location = new System.Drawing.Point(529, 180);
            this.txtP6.Name = "txtP6";
            this.txtP6.Size = new System.Drawing.Size(100, 20);
            this.txtP6.TabIndex = 10;
            // 
            // btnCom
            // 
            this.btnCom.Location = new System.Drawing.Point(542, 206);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(75, 23);
            this.btnCom.TabIndex = 11;
            this.btnCom.Text = "Comprobar";
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1.Location = new System.Drawing.Point(635, 53);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(41, 13);
            this.lblP1.TabIndex = 12;
            this.lblP1.Text = "label2";
            // 
            // lblP6
            // 
            this.lblP6.AutoSize = true;
            this.lblP6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP6.Location = new System.Drawing.Point(635, 183);
            this.lblP6.Name = "lblP6";
            this.lblP6.Size = new System.Drawing.Size(41, 13);
            this.lblP6.TabIndex = 13;
            this.lblP6.Text = "label3";
            // 
            // lblP5
            // 
            this.lblP5.AutoSize = true;
            this.lblP5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP5.Location = new System.Drawing.Point(635, 156);
            this.lblP5.Name = "lblP5";
            this.lblP5.Size = new System.Drawing.Size(41, 13);
            this.lblP5.TabIndex = 14;
            this.lblP5.Text = "label4";
            // 
            // lblP4
            // 
            this.lblP4.AutoSize = true;
            this.lblP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP4.Location = new System.Drawing.Point(635, 133);
            this.lblP4.Name = "lblP4";
            this.lblP4.Size = new System.Drawing.Size(41, 13);
            this.lblP4.TabIndex = 15;
            this.lblP4.Text = "label5";
            // 
            // lblP3
            // 
            this.lblP3.AutoSize = true;
            this.lblP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP3.Location = new System.Drawing.Point(635, 107);
            this.lblP3.Name = "lblP3";
            this.lblP3.Size = new System.Drawing.Size(41, 13);
            this.lblP3.TabIndex = 16;
            this.lblP3.Text = "label6";
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2.Location = new System.Drawing.Point(635, 81);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(41, 13);
            this.lblP2.TabIndex = 17;
            this.lblP2.Text = "label7";
            // 
            // pbL3
            // 
            this.pbL3.BackgroundImage = global::Automatas_de_pila.Properties.Resources.Automata1;
            this.pbL3.Image = global::Automatas_de_pila.Properties.Resources.Automata3_1;
            this.pbL3.Location = new System.Drawing.Point(196, 50);
            this.pbL3.Name = "pbL3";
            this.pbL3.Size = new System.Drawing.Size(274, 174);
            this.pbL3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbL3.TabIndex = 19;
            this.pbL3.TabStop = false;
            this.pbL3.Visible = false;
            // 
            // pbL2
            // 
            this.pbL2.BackgroundImage = global::Automatas_de_pila.Properties.Resources.Automata1;
            this.pbL2.Image = global::Automatas_de_pila.Properties.Resources.Automata2;
            this.pbL2.Location = new System.Drawing.Point(196, 50);
            this.pbL2.Name = "pbL2";
            this.pbL2.Size = new System.Drawing.Size(274, 174);
            this.pbL2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbL2.TabIndex = 18;
            this.pbL2.TabStop = false;
            this.pbL2.Visible = false;
            // 
            // pbL1
            // 
            this.pbL1.BackgroundImage = global::Automatas_de_pila.Properties.Resources.Automata1;
            this.pbL1.Image = global::Automatas_de_pila.Properties.Resources.Automata1;
            this.pbL1.Location = new System.Drawing.Point(196, 50);
            this.pbL1.Name = "pbL1";
            this.pbL1.Size = new System.Drawing.Size(274, 174);
            this.pbL1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbL1.TabIndex = 4;
            this.pbL1.TabStop = false;
            this.pbL1.Visible = false;
            // 
            // lblAutomata
            // 
            this.lblAutomata.AutoSize = true;
            this.lblAutomata.Location = new System.Drawing.Point(193, 34);
            this.lblAutomata.Name = "lblAutomata";
            this.lblAutomata.Size = new System.Drawing.Size(55, 13);
            this.lblAutomata.TabIndex = 20;
            this.lblAutomata.Text = "Automata:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Comprobar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 247);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAutomata);
            this.Controls.Add(this.pbL3);
            this.Controls.Add(this.pbL2);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.lblP3);
            this.Controls.Add(this.lblP4);
            this.Controls.Add(this.lblP5);
            this.Controls.Add(this.lblP6);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.btnCom);
            this.Controls.Add(this.txtP6);
            this.Controls.Add(this.txtP5);
            this.Controls.Add(this.txtP4);
            this.Controls.Add(this.txtP3);
            this.Controls.Add(this.txtP2);
            this.Controls.Add(this.txtP1);
            this.Controls.Add(this.pbL1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbL3);
            this.Controls.Add(this.rbL2);
            this.Controls.Add(this.rbL1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automatas de pila";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbL3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbL2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbL1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbL1;
        private System.Windows.Forms.RadioButton rbL2;
        private System.Windows.Forms.RadioButton rbL3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbL1;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.TextBox txtP3;
        private System.Windows.Forms.TextBox txtP4;
        private System.Windows.Forms.TextBox txtP5;
        private System.Windows.Forms.TextBox txtP6;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label lblP6;
        private System.Windows.Forms.Label lblP5;
        private System.Windows.Forms.Label lblP4;
        private System.Windows.Forms.Label lblP3;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.PictureBox pbL2;
        private System.Windows.Forms.PictureBox pbL3;
        private System.Windows.Forms.Label lblAutomata;
        private System.Windows.Forms.Label label2;
    }
}

