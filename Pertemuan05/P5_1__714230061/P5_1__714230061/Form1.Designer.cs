namespace P5_1__714230061
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
            this.Output_label = new System.Windows.Forms.Label();
            this.HelloButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Output_label
            // 
            this.Output_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Output_label.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output_label.Location = new System.Drawing.Point(5, 20);
            this.Output_label.Name = "Output_label";
            this.Output_label.Size = new System.Drawing.Size(264, 23);
            this.Output_label.TabIndex = 0;
            this.Output_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Output_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // HelloButton
            // 
            this.HelloButton.Location = new System.Drawing.Point(57, 87);
            this.HelloButton.Name = "HelloButton";
            this.HelloButton.Size = new System.Drawing.Size(75, 25);
            this.HelloButton.TabIndex = 1;
            this.HelloButton.Text = "&SayHello";
            this.HelloButton.UseVisualStyleBackColor = true;
            this.HelloButton.Click += new System.EventHandler(this.HelloButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(161, 87);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 25);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "e";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(284, 136);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HelloButton);
            this.Controls.Add(this.Output_label);
            this.Name = "Form1";
            this.Text = "Form Hello";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Output_label;
        private System.Windows.Forms.Button HelloButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button button1;
    }
}

