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
            Btn_name_person = new Button();
            Txt_name = new TextBox();
            label2 = new Label();
            Txt_Gewicht_person = new TextBox();
            label3 = new Label();
            txt_ausgabe_namen = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btneinsteigen
            // 
            btneinsteigen.Location = new Point(13, 197);
            btneinsteigen.Name = "btneinsteigen";
            btneinsteigen.Size = new Size(75, 23);
            btneinsteigen.TabIndex = 0;
            btneinsteigen.Text = "Einsteigen";
            btneinsteigen.UseVisualStyleBackColor = true;
            btneinsteigen.Click += btneinsteigen_Click;
            // 
            // btnaussteigen
            // 
            btnaussteigen.Location = new Point(13, 236);
            btnaussteigen.Name = "btnaussteigen";
            btnaussteigen.Size = new Size(75, 23);
            btnaussteigen.TabIndex = 1;
            btnaussteigen.Text = "Aussteigen";
            btnaussteigen.UseVisualStyleBackColor = true;
            btnaussteigen.Click += btnaussteigen_Click;
            // 
            // txtgewichtausgabe
            // 
            txtgewichtausgabe.Location = new Point(94, 197);
            txtgewichtausgabe.Multiline = true;
            txtgewichtausgabe.Name = "txtgewichtausgabe";
            txtgewichtausgabe.Size = new Size(114, 62);
            txtgewichtausgabe.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // Btn_name_person
            // 
            Btn_name_person.Location = new Point(172, 86);
            Btn_name_person.Name = "Btn_name_person";
            Btn_name_person.Size = new Size(75, 23);
            Btn_name_person.TabIndex = 4;
            Btn_name_person.Text = "Speichern";
            Btn_name_person.UseVisualStyleBackColor = true;
            Btn_name_person.Click += Btn_name_person_Click;
            // 
            // Txt_name
            // 
            Txt_name.Location = new Point(16, 42);
            Txt_name.Multiline = true;
            Txt_name.Name = "Txt_name";
            Txt_name.Size = new Size(192, 28);
            Txt_name.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 180);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 6;
            label2.Text = "Gewicht Auto";
            // 
            // Txt_Gewicht_person
            // 
            Txt_Gewicht_person.Location = new Point(214, 42);
            Txt_Gewicht_person.Multiline = true;
            Txt_Gewicht_person.Name = "Txt_Gewicht_person";
            Txt_Gewicht_person.Size = new Size(192, 28);
            Txt_Gewicht_person.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 24);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 8;
            label3.Text = "Gewicht Person";
            // 
            // txt_ausgabe_namen
            // 
            txt_ausgabe_namen.Location = new Point(214, 198);
            txt_ausgabe_namen.Multiline = true;
            txt_ausgabe_namen.Name = "txt_ausgabe_namen";
            txt_ausgabe_namen.Size = new Size(114, 62);
            txt_ausgabe_namen.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(214, 180);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 10;
            label4.Text = "Personen im Auto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 323);
            Controls.Add(label4);
            Controls.Add(txt_ausgabe_namen);
            Controls.Add(label3);
            Controls.Add(Txt_Gewicht_person);
            Controls.Add(label2);
            Controls.Add(Txt_name);
            Controls.Add(Btn_name_person);
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
        private Button Btn_name_person;
        private TextBox Txt_name;
        private Label label2;
        private TextBox Txt_Gewicht_person;
        private Label label3;
        private TextBox txt_ausgabe_namen;
        private Label label4;
    }
}
