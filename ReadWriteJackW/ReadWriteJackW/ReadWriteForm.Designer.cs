namespace ReadWriteJackW
{
    partial class frmReadWrite
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
            this.lblStatement = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatement
            // 
            this.lblStatement.AutoSize = true;
            this.lblStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblStatement.Location = new System.Drawing.Point(56, 20);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(364, 66);
            this.lblStatement.TabIndex = 0;
            this.lblStatement.Text = "Compare strings on each line of input.txt. file\r\n\r\n(Case doesn\'t matter)";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(182, 155);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblOutput.Location = new System.Drawing.Point(56, 279);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(316, 22);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "Output has been generated to text file.";
            // 
            // frmReadWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 355);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblStatement);
            this.Name = "frmReadWrite";
            this.Text = "Read & Write by Jack W";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatement;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblOutput;
    }
}

