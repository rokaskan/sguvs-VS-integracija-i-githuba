namespace sguvs
{
    partial class loginForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm1));
            this.vartotojoIdTextBox = new System.Windows.Forms.TextBox();
            this.slaptazodisTextBox = new System.Windows.Forms.TextBox();
            this.vartotojoVardaslabel = new System.Windows.Forms.Label();
            this.slaptazodisLabel1 = new System.Windows.Forms.Label();
            this.prisijungtiBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vartotojoIdTextBox
            // 
            this.vartotojoIdTextBox.Location = new System.Drawing.Point(97, 53);
            this.vartotojoIdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vartotojoIdTextBox.Name = "vartotojoIdTextBox";
            this.vartotojoIdTextBox.Size = new System.Drawing.Size(240, 22);
            this.vartotojoIdTextBox.TabIndex = 0;
            // 
            // slaptazodisTextBox
            // 
            this.slaptazodisTextBox.Location = new System.Drawing.Point(97, 114);
            this.slaptazodisTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slaptazodisTextBox.Name = "slaptazodisTextBox";
            this.slaptazodisTextBox.Size = new System.Drawing.Size(240, 22);
            this.slaptazodisTextBox.TabIndex = 1;
            this.slaptazodisTextBox.UseSystemPasswordChar = true;
            // 
            // vartotojoVardaslabel
            // 
            this.vartotojoVardaslabel.AutoSize = true;
            this.vartotojoVardaslabel.Location = new System.Drawing.Point(93, 33);
            this.vartotojoVardaslabel.Name = "vartotojoVardaslabel";
            this.vartotojoVardaslabel.Size = new System.Drawing.Size(131, 17);
            this.vartotojoVardaslabel.TabIndex = 2;
            this.vartotojoVardaslabel.Text = "Prisijungimo vardas";
            // 
            // slaptazodisLabel1
            // 
            this.slaptazodisLabel1.AutoSize = true;
            this.slaptazodisLabel1.Location = new System.Drawing.Point(93, 95);
            this.slaptazodisLabel1.Name = "slaptazodisLabel1";
            this.slaptazodisLabel1.Size = new System.Drawing.Size(81, 17);
            this.slaptazodisLabel1.TabIndex = 3;
            this.slaptazodisLabel1.Text = "Slaptažodis";
            // 
            // prisijungtiBtn
            // 
            this.prisijungtiBtn.Location = new System.Drawing.Point(253, 159);
            this.prisijungtiBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prisijungtiBtn.Name = "prisijungtiBtn";
            this.prisijungtiBtn.Size = new System.Drawing.Size(84, 28);
            this.prisijungtiBtn.TabIndex = 4;
            this.prisijungtiBtn.Text = "Prisijungti";
            this.prisijungtiBtn.UseVisualStyleBackColor = true;
            this.prisijungtiBtn.Click += new System.EventHandler(this.prisijungtiBtn_Click);
            // 
            // loginForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 246);
            this.Controls.Add(this.prisijungtiBtn);
            this.Controls.Add(this.slaptazodisLabel1);
            this.Controls.Add(this.vartotojoVardaslabel);
            this.Controls.Add(this.slaptazodisTextBox);
            this.Controls.Add(this.vartotojoIdTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stiklo namai";
            this.Load += new System.EventHandler(this.loginForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vartotojoIdTextBox;
        private System.Windows.Forms.TextBox slaptazodisTextBox;
        private System.Windows.Forms.Label vartotojoVardaslabel;
        private System.Windows.Forms.Label slaptazodisLabel1;
        private System.Windows.Forms.Button prisijungtiBtn;
    }
}

