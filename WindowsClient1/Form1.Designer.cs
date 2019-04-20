namespace WindowsClient1
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
            this.btnWelcome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWelcome
            // 
            this.btnWelcome.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWelcome.ForeColor = System.Drawing.Color.Red;
            this.btnWelcome.Image = ((System.Drawing.Image)(resources.GetObject("btnWelcome.Image")));
            this.btnWelcome.Location = new System.Drawing.Point(-7, -27);
            this.btnWelcome.Name = "btnWelcome";
            this.btnWelcome.Size = new System.Drawing.Size(800, 600);
            this.btnWelcome.TabIndex = 0;
            this.btnWelcome.Text = "Welcome to my Cafe";
            this.btnWelcome.UseVisualStyleBackColor = true;
            this.btnWelcome.Click += new System.EventHandler(this.btnWelcome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnWelcome);
            this.Name = "Form1";
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWelcome;
    }
}

