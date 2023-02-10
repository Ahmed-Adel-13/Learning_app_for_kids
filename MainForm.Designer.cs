namespace cs_learning_app
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Englishbtn = new System.Windows.Forms.Button();
            this.Arbicbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Franchbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Englishbtn
            // 
            this.Englishbtn.Location = new System.Drawing.Point(31, 92);
            this.Englishbtn.Name = "Englishbtn";
            this.Englishbtn.Size = new System.Drawing.Size(121, 55);
            this.Englishbtn.TabIndex = 0;
            this.Englishbtn.Text = "English";
            this.Englishbtn.UseVisualStyleBackColor = true;
            this.Englishbtn.Click += new System.EventHandler(this.Englishbtn_Click);
            // 
            // Arbicbtn
            // 
            this.Arbicbtn.Location = new System.Drawing.Point(361, 92);
            this.Arbicbtn.Name = "Arbicbtn";
            this.Arbicbtn.Size = new System.Drawing.Size(121, 55);
            this.Arbicbtn.TabIndex = 1;
            this.Arbicbtn.Text = "العربية";
            this.Arbicbtn.UseVisualStyleBackColor = true;
            this.Arbicbtn.Click += new System.EventHandler(this.Arbicbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "choose your language";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "اختر اللغة المناسبة";
            // 
            // Franchbtn
            // 
            this.Franchbtn.Location = new System.Drawing.Point(197, 92);
            this.Franchbtn.Name = "Franchbtn";
            this.Franchbtn.Size = new System.Drawing.Size(121, 55);
            this.Franchbtn.TabIndex = 3;
            this.Franchbtn.Text = "français";
            this.Franchbtn.UseVisualStyleBackColor = true;
            this.Franchbtn.Click += new System.EventHandler(this.Franchbtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 228);
            this.ControlBox = false;
            this.Controls.Add(this.Franchbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Arbicbtn);
            this.Controls.Add(this.Englishbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Learning App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Englishbtn;
        private System.Windows.Forms.Button Arbicbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Franchbtn;
    }
}