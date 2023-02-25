namespace SP_HM_MODUL4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_number = new System.Windows.Forms.Label();
            this.listBoxNumber = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_number
            // 
            this.lb_number.AutoSize = true;
            this.lb_number.Location = new System.Drawing.Point(354, 25);
            this.lb_number.Name = "lb_number";
            this.lb_number.Size = new System.Drawing.Size(94, 15);
            this.lb_number.TabIndex = 0;
            this.lb_number.Text = "Потоки и числа";
            // 
            // listBoxNumber
            // 
            this.listBoxNumber.FormattingEnabled = true;
            this.listBoxNumber.ItemHeight = 15;
            this.listBoxNumber.Location = new System.Drawing.Point(325, 55);
            this.listBoxNumber.Name = "listBoxNumber";
            this.listBoxNumber.ScrollAlwaysVisible = true;
            this.listBoxNumber.Size = new System.Drawing.Size(174, 319);
            this.listBoxNumber.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(88, 145);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(133, 68);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 386);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.listBoxNumber);
            this.Controls.Add(this.lb_number);
            this.Name = "Form1";
            this.Text = "Мьютексты.Семафоры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_number;
        private ListBox listBoxNumber;
        private Button buttonStart;
    }
}