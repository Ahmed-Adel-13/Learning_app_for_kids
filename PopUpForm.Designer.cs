namespace cs_learning_app
{
    partial class PopUpForm
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
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.Location = new System.Drawing.Point(12, 156);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(421, 31);
            this.InstructionsLabel.TabIndex = 3;
            this.InstructionsLabel.Text = "press the letter from your keyboard";
            // 
            // ShowBtn
            // 
            this.ShowBtn.BackColor = System.Drawing.Color.Aqua;
            this.ShowBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowBtn.FlatAppearance.BorderSize = 0;
            this.ShowBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBtn.Location = new System.Drawing.Point(128, 62);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(172, 223);
            this.ShowBtn.TabIndex = 4;
            this.ShowBtn.Text = "A";
            this.ShowBtn.UseVisualStyleBackColor = false;
            // 
            // PopUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 344);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.InstructionsLabel);
            this.Name = "PopUpForm";
            this.Text = "PopUpForm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PopUpForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.Button ShowBtn;
    }
}