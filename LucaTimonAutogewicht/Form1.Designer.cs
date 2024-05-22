namespace LucaTimonAutogewicht
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
            btneinsteigen = new Button();
            btnaussteigen = new Button();
            txtgewichtausgabe = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btneinsteigen
            // 
            btneinsteigen.Location = new Point(12, 133);
            btneinsteigen.Name = "btneinsteigen";
            btneinsteigen.Size = new Size(75, 23);
            btneinsteigen.TabIndex = 0;
            btneinsteigen.Text = "Einsteigen";
            btneinsteigen.UseVisualStyleBackColor = true;
            btneinsteigen.Click += btneinsteigen_Click;
            // 
            // btnaussteigen
            // 
            btnaussteigen.Location = new Point(12, 172);
            btnaussteigen.Name = "btnaussteigen";
            btnaussteigen.Size = new Size(75, 23);
            btnaussteigen.TabIndex = 1;
            btnaussteigen.Text = "Aussteigen";
            btnaussteigen.UseVisualStyleBackColor = true;
            btnaussteigen.Click += btnaussteigen_Click;
            // 
            // txtgewichtausgabe
            // 
            txtgewichtausgabe.Location = new Point(93, 134);
            txtgewichtausgabe.Multiline = true;
            txtgewichtausgabe.Name = "txtgewichtausgabe";
            txtgewichtausgabe.Size = new Size(192, 90);
            txtgewichtausgabe.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 116);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Gewicht";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 257);
            Controls.Add(label1);
            Controls.Add(txtgewichtausgabe);
            Controls.Add(btnaussteigen);
            Controls.Add(btneinsteigen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btneinsteigen;
        private Button btnaussteigen;
        private TextBox txtgewichtausgabe;
        private Label label1;
    }
}
