namespace Phone_book
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
            this.btnabstract = new System.Windows.Forms.Button();
            this.btnsealed = new System.Windows.Forms.Button();
            this.btnpartial = new System.Windows.Forms.Button();
            this.btnpoly = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnabstract
            // 
            this.btnabstract.Location = new System.Drawing.Point(484, 30);
            this.btnabstract.Name = "btnabstract";
            this.btnabstract.Size = new System.Drawing.Size(304, 84);
            this.btnabstract.TabIndex = 0;
            this.btnabstract.Text = "Abstract Class";
            this.btnabstract.UseVisualStyleBackColor = true;
            this.btnabstract.Click += new System.EventHandler(this.btnabstract_Click);
            // 
            // btnsealed
            // 
            this.btnsealed.Location = new System.Drawing.Point(484, 134);
            this.btnsealed.Name = "btnsealed";
            this.btnsealed.Size = new System.Drawing.Size(304, 88);
            this.btnsealed.TabIndex = 1;
            this.btnsealed.Text = "Sealed Class";
            this.btnsealed.UseVisualStyleBackColor = true;
            this.btnsealed.Click += new System.EventHandler(this.btnsealed_Click);
            // 
            // btnpartial
            // 
            this.btnpartial.Location = new System.Drawing.Point(484, 239);
            this.btnpartial.Name = "btnpartial";
            this.btnpartial.Size = new System.Drawing.Size(304, 94);
            this.btnpartial.TabIndex = 2;
            this.btnpartial.Text = "Partial Class";
            this.btnpartial.UseVisualStyleBackColor = true;
            this.btnpartial.Click += new System.EventHandler(this.btnpartial_Click);
            // 
            // btnpoly
            // 
            this.btnpoly.Location = new System.Drawing.Point(484, 348);
            this.btnpoly.Name = "btnpoly";
            this.btnpoly.Size = new System.Drawing.Size(304, 90);
            this.btnpoly.TabIndex = 3;
            this.btnpoly.Text = "Polymorphism";
            this.btnpoly.UseVisualStyleBackColor = true;
            this.btnpoly.Click += new System.EventHandler(this.btnpoly_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 84);
            this.button1.TabIndex = 4;
            this.button1.Text = "Recomendaions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(304, 84);
            this.button2.TabIndex = 5;
            this.button2.Text = "Overriding";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(49, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(304, 84);
            this.button3.TabIndex = 6;
            this.button3.Text = "Array";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(49, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(304, 84);
            this.button4.TabIndex = 7;
            this.button4.Text = "Class";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnpoly);
            this.Controls.Add(this.btnpartial);
            this.Controls.Add(this.btnsealed);
            this.Controls.Add(this.btnabstract);
            this.Name = "Form1";
            this.Text = "List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnabstract;
        private System.Windows.Forms.Button btnsealed;
        private System.Windows.Forms.Button btnpartial;
        private System.Windows.Forms.Button btnpoly;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

