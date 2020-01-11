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
            this.vartotojoIdTextBox.Location = new System.Drawing.Point(73, 43);
            this.vartotojoIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.vartotojoIdTextBox.Name = "vartotojoIdTextBox";
            this.vartotojoIdTextBox.Size = new System.Drawing.Size(181, 20);
            this.vartotojoIdTextBox.TabIndex = 0;
            // 
            // slaptazodisTextBox
            // 
            this.slaptazodisTextBox.Location = new System.Drawing.Point(73, 93);
            this.slaptazodisTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.slaptazodisTextBox.Name = "slaptazodisTextBox";
            this.slaptazodisTextBox.Size = new System.Drawing.Size(181, 20);
            this.slaptazodisTextBox.TabIndex = 1;
            // 
            // vartotojoVardaslabel
            // 
            this.vartotojoVardaslabel.AutoSize = true;
            this.vartotojoVardaslabel.Location = new System.Drawing.Point(70, 27);
            this.vartotojoVardaslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vartotojoVardaslabel.Name = "vartotojoVardaslabel";
            this.vartotojoVardaslabel.Size = new System.Drawing.Size(97, 13);
            this.vartotojoVardaslabel.TabIndex = 2;
            this.vartotojoVardaslabel.Text = "Prisijungimo vardas";
            // 
            // slaptazodisLabel1
            // 
            this.slaptazodisLabel1.AutoSize = true;
            this.slaptazodisLabel1.Location = new System.Drawing.Point(70, 77);
            this.slaptazodisLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.slaptazodisLabel1.Name = "slaptazodisLabel1";
            this.slaptazodisLabel1.Size = new System.Drawing.Size(61, 13);
            this.slaptazodisLabel1.TabIndex = 3;
            this.slaptazodisLabel1.Text = "Slaptažodis";
            // 
            // prisijungtiBtn
            // 
            this.prisijungtiBtn.Location = new System.Drawing.Point(190, 129);
            this.prisijungtiBtn.Margin = new System.Windows.Forms.Padding(2);
            this.prisijungtiBtn.Name = "prisijungtiBtn";
            this.prisijungtiBtn.Size = new System.Drawing.Size(63, 23);
            this.prisijungtiBtn.TabIndex = 4;
            this.prisijungtiBtn.Text = "Prisijungti";
            this.prisijungtiBtn.UseVisualStyleBackColor = true;
            this.prisijungtiBtn.Click += new System.EventHandler(this.prisijungtiBtn_Click);
            // 
            // loginForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 200);
            this.Controls.Add(this.prisijungtiBtn);
            this.Controls.Add(this.slaptazodisLabel1);
            this.Controls.Add(this.vartotojoVardaslabel);
            this.Controls.Add(this.slaptazodisTextBox);
            this.Controls.Add(this.vartotojoIdTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stiklo namai";
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

