namespace PC_App
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
            this.label1 = new System.Windows.Forms.Label();
            this.wrntyNumber_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.start_button = new System.Windows.Forms.Button();
            this.path_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.path_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Warranty Report Number";
            // 
            // wrntyNumber_maskedTextBox
            // 
            this.wrntyNumber_maskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrntyNumber_maskedTextBox.Location = new System.Drawing.Point(464, 9);
            this.wrntyNumber_maskedTextBox.Mask = "0000-00";
            this.wrntyNumber_maskedTextBox.Name = "wrntyNumber_maskedTextBox";
            this.wrntyNumber_maskedTextBox.Size = new System.Drawing.Size(130, 41);
            this.wrntyNumber_maskedTextBox.TabIndex = 1;
            this.wrntyNumber_maskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.wrntyNumber_maskedTextBox.Click += new System.EventHandler(this.wrntyNumber_maskedTextBox_Click);
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.Location = new System.Drawing.Point(600, 12);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(153, 41);
            this.start_button.TabIndex = 2;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // path_button
            // 
            this.path_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path_button.Location = new System.Drawing.Point(600, 58);
            this.path_button.Name = "path_button";
            this.path_button.Size = new System.Drawing.Size(153, 49);
            this.path_button.TabIndex = 5;
            this.path_button.Text = "Change";
            this.path_button.UseVisualStyleBackColor = true;
            this.path_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.path_button_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Save Path";
            // 
            // path_textBox
            // 
            this.path_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path_textBox.Location = new System.Drawing.Point(157, 61);
            this.path_textBox.Name = "path_textBox";
            this.path_textBox.Size = new System.Drawing.Size(437, 41);
            this.path_textBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 128);
            this.Controls.Add(this.path_textBox);
            this.Controls.Add(this.path_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.wrntyNumber_maskedTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Visual App Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox wrntyNumber_maskedTextBox;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button path_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox path_textBox;
    }
}

