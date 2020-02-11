namespace snake
{
    partial class frm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblKeys = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(518, 12);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(41, 13);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(598, 64);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Restart";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(518, 38);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(42, 13);
            this.lblLevel.TabIndex = 3;
            this.lblLevel.Text = "Level : ";
            // 
            // lblKeys
            // 
            this.lblKeys.AutoSize = true;
            this.lblKeys.Location = new System.Drawing.Point(538, 460);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(135, 52);
            this.lblKeys.TabIndex = 4;
            this.lblKeys.Text = "Yön tuþlarý ile hareket edilir.\r\nDurdurma : Boþluk tuþu.\r\nHile aç : H.\r\nHile Kapa" +
    "t : J.\r\n";
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(685, 533);
            this.Controls.Add(this.lblKeys);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm1";
            this.Text = "SnakeGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BackColorChanged += new System.EventHandler(this.frm1_BackColorChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblKeys;
    }
}

