
namespace GetPixelColor
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAuto = new System.Windows.Forms.Button();
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.textR = new System.Windows.Forms.TextBox();
            this.textG = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.txtBoxPause = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(433, 213);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 210);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 325);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 95);
            this.button1.TabIndex = 1;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX.Location = new System.Drawing.Point(16, 15);
            this.textBoxX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxX.Size = new System.Drawing.Size(152, 68);
            this.textBoxX.TabIndex = 2;
            this.textBoxX.Text = "131";
            this.textBoxX.TextChanged += new System.EventHandler(this.textBoxX_TextChanged);
            // 
            // textBoxY
            // 
            this.textBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxY.Location = new System.Drawing.Point(16, 91);
            this.textBoxY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxY.Size = new System.Drawing.Size(152, 68);
            this.textBoxY.TabIndex = 3;
            this.textBoxY.Text = "39";
            this.textBoxY.TextChanged += new System.EventHandler(this.textBoxY_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(196, 28);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar1.Maximum = 1920;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(628, 56);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 131;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(196, 91);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar2.Maximum = 1080;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(628, 56);
            this.trackBar2.TabIndex = 5;
            this.trackBar2.Value = 39;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAuto
            // 
            this.btnAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.Location = new System.Drawing.Point(16, 213);
            this.btnAuto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(225, 95);
            this.btnAuto.TabIndex = 6;
            this.btnAuto.Text = "AUTO";
            this.btnAuto.UseVisualStyleBackColor = false;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInterval.Location = new System.Drawing.Point(249, 213);
            this.textBoxInterval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxInterval.Size = new System.Drawing.Size(175, 98);
            this.textBoxInterval.TabIndex = 7;
            this.textBoxInterval.Text = "1";
            this.textBoxInterval.TextChanged += new System.EventHandler(this.textBoxInterval_TextChanged);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(196, 150);
            this.trackBar3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar3.Maximum = 250;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(628, 56);
            this.trackBar3.TabIndex = 8;
            this.trackBar3.Value = 1;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // textR
            // 
            this.textR.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textR.Location = new System.Drawing.Point(16, 442);
            this.textR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textR.Name = "textR";
            this.textR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textR.Size = new System.Drawing.Size(235, 128);
            this.textR.TabIndex = 9;
            this.textR.Text = "0";
            // 
            // textG
            // 
            this.textG.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textG.Location = new System.Drawing.Point(297, 442);
            this.textG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textG.Name = "textG";
            this.textG.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textG.Size = new System.Drawing.Size(235, 128);
            this.textG.TabIndex = 10;
            this.textG.Text = "0";
            // 
            // textB
            // 
            this.textB.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB.Location = new System.Drawing.Point(588, 442);
            this.textB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textB.Name = "textB";
            this.textB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textB.Size = new System.Drawing.Size(235, 128);
            this.textB.TabIndex = 11;
            this.textB.Text = "0";
            // 
            // txtBoxPause
            // 
            this.txtBoxPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPause.Location = new System.Drawing.Point(249, 325);
            this.txtBoxPause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxPause.Name = "txtBoxPause";
            this.txtBoxPause.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBoxPause.Size = new System.Drawing.Size(175, 83);
            this.txtBoxPause.TabIndex = 12;
            this.txtBoxPause.Text = "4100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 587);
            this.Controls.Add(this.txtBoxPause);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.textG);
            this.Controls.Add(this.textR);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.textBoxInterval);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.TextBox textBoxInterval;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TextBox textR;
        private System.Windows.Forms.TextBox textG;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.TextBox txtBoxPause;
    }
}

