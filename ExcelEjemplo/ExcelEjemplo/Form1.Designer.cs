namespace ExcelEjemplo
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
            this.txtBoton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoton1
            // 
            this.txtBoton1.Location = new System.Drawing.Point(100, 176);
            this.txtBoton1.Name = "txtBoton1";
            this.txtBoton1.Size = new System.Drawing.Size(75, 23);
            this.txtBoton1.TabIndex = 0;
            this.txtBoton1.Text = "Excel";
            this.txtBoton1.UseVisualStyleBackColor = true;
            this.txtBoton1.Click += new System.EventHandler(this.txtBoton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtBoton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtBoton1;
    }
}

