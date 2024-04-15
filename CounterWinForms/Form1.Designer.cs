namespace CounterWinForms
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
            label1 = new Label();
            buttonIncr = new Button();
            buttonReset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 44);
            label1.Name = "label1";
            label1.Size = new Size(172, 72);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonIncr
            // 
            buttonIncr.Location = new Point(12, 12);
            buttonIncr.Name = "buttonIncr";
            buttonIncr.Size = new Size(94, 29);
            buttonIncr.TabIndex = 1;
            buttonIncr.Text = "Increment";
            buttonIncr.UseVisualStyleBackColor = true;
            buttonIncr.Click += buttonIncr_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(112, 12);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 2;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 136);
            Controls.Add(buttonReset);
            Controls.Add(buttonIncr);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Counter Demo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonIncr;
        private Button buttonReset;
    }
}