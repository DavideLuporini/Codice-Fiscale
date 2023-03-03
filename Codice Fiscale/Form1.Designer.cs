namespace Codice_Fiscale
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
            this.Sesso = new System.Windows.Forms.GroupBox();
            this.Femmina = new System.Windows.Forms.RadioButton();
            this.Maschio = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Input_Nome = new System.Windows.Forms.TextBox();
            this.Input_Cognome = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Data_di_nascita = new System.Windows.Forms.DateTimePicker();
            this.nome_label = new System.Windows.Forms.Label();
            this.Label_Cognome = new System.Windows.Forms.Label();
            this.label_comune_nascita = new System.Windows.Forms.Label();
            this.label_data_nascita = new System.Windows.Forms.Label();
            this.btn_Calcola = new System.Windows.Forms.Button();
            this.Input_comune_di_nascita = new System.Windows.Forms.ComboBox();
            this.Sesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sesso
            // 
            this.Sesso.Controls.Add(this.Femmina);
            this.Sesso.Controls.Add(this.Maschio);
            this.Sesso.Location = new System.Drawing.Point(12, 173);
            this.Sesso.Name = "Sesso";
            this.Sesso.Size = new System.Drawing.Size(200, 100);
            this.Sesso.TabIndex = 0;
            this.Sesso.TabStop = false;
            this.Sesso.Text = "Sesso";
            this.Sesso.Enter += new System.EventHandler(this.Sesso_Enter);
            // 
            // Femmina
            // 
            this.Femmina.AutoSize = true;
            this.Femmina.Location = new System.Drawing.Point(6, 55);
            this.Femmina.Name = "Femmina";
            this.Femmina.Size = new System.Drawing.Size(100, 24);
            this.Femmina.TabIndex = 2;
            this.Femmina.TabStop = true;
            this.Femmina.Text = "Femmina";
            this.Femmina.UseVisualStyleBackColor = true;
            // 
            // Maschio
            // 
            this.Maschio.AutoSize = true;
            this.Maschio.Location = new System.Drawing.Point(6, 25);
            this.Maschio.Name = "Maschio";
            this.Maschio.Size = new System.Drawing.Size(93, 24);
            this.Maschio.TabIndex = 1;
            this.Maschio.TabStop = true;
            this.Maschio.Text = "Maschio";
            this.Maschio.UseVisualStyleBackColor = true;
            this.Maschio.CheckedChanged += new System.EventHandler(this.Maschio_CheckedChanged);
            // 
            // Input_Nome
            // 
            this.Input_Nome.Location = new System.Drawing.Point(12, 37);
            this.Input_Nome.Name = "Input_Nome";
            this.Input_Nome.Size = new System.Drawing.Size(160, 26);
            this.Input_Nome.TabIndex = 1;
            this.Input_Nome.TextChanged += new System.EventHandler(this.Input_Nome_TextChanged);
            // 
            // Input_Cognome
            // 
            this.Input_Cognome.Location = new System.Drawing.Point(193, 37);
            this.Input_Cognome.Name = "Input_Cognome";
            this.Input_Cognome.Size = new System.Drawing.Size(155, 26);
            this.Input_Cognome.TabIndex = 2;
            this.Input_Cognome.TextChanged += new System.EventHandler(this.Input_Cognome_TextChanged);
            // 
            // dateTimePicker_Data_di_nascita
            // 
            this.dateTimePicker_Data_di_nascita.Location = new System.Drawing.Point(12, 115);
            this.dateTimePicker_Data_di_nascita.Name = "dateTimePicker_Data_di_nascita";
            this.dateTimePicker_Data_di_nascita.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_Data_di_nascita.TabIndex = 3;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(14, 14);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(51, 20);
            this.nome_label.TabIndex = 5;
            this.nome_label.Text = "Nome";
            // 
            // Label_Cognome
            // 
            this.Label_Cognome.AutoSize = true;
            this.Label_Cognome.Location = new System.Drawing.Point(189, 14);
            this.Label_Cognome.Name = "Label_Cognome";
            this.Label_Cognome.Size = new System.Drawing.Size(78, 20);
            this.Label_Cognome.TabIndex = 6;
            this.Label_Cognome.Text = "Cognome";
            // 
            // label_comune_nascita
            // 
            this.label_comune_nascita.AutoSize = true;
            this.label_comune_nascita.Location = new System.Drawing.Point(367, 14);
            this.label_comune_nascita.Name = "label_comune_nascita";
            this.label_comune_nascita.Size = new System.Drawing.Size(140, 20);
            this.label_comune_nascita.TabIndex = 7;
            this.label_comune_nascita.Text = "Comune di nascita";
            // 
            // label_data_nascita
            // 
            this.label_data_nascita.AutoSize = true;
            this.label_data_nascita.Location = new System.Drawing.Point(12, 92);
            this.label_data_nascita.Name = "label_data_nascita";
            this.label_data_nascita.Size = new System.Drawing.Size(115, 20);
            this.label_data_nascita.TabIndex = 8;
            this.label_data_nascita.Text = "Data di nascita";
            // 
            // btn_Calcola
            // 
            this.btn_Calcola.Location = new System.Drawing.Point(713, 332);
            this.btn_Calcola.Name = "btn_Calcola";
            this.btn_Calcola.Size = new System.Drawing.Size(75, 37);
            this.btn_Calcola.TabIndex = 9;
            this.btn_Calcola.Text = "Calcola";
            this.btn_Calcola.UseVisualStyleBackColor = true;
            this.btn_Calcola.Click += new System.EventHandler(this.btn_Calcola_Click);
            // 
            // Input_comune_di_nascita
            // 
            this.Input_comune_di_nascita.FormattingEnabled = true;
            this.Input_comune_di_nascita.Location = new System.Drawing.Point(371, 37);
            this.Input_comune_di_nascita.Name = "Input_comune_di_nascita";
            this.Input_comune_di_nascita.Size = new System.Drawing.Size(121, 28);
            this.Input_comune_di_nascita.TabIndex = 10;
            this.Input_comune_di_nascita.SelectedIndexChanged += new System.EventHandler(this.Input_comune_di_nascita_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Input_comune_di_nascita);
            this.Controls.Add(this.btn_Calcola);
            this.Controls.Add(this.label_data_nascita);
            this.Controls.Add(this.label_comune_nascita);
            this.Controls.Add(this.Label_Cognome);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.dateTimePicker_Data_di_nascita);
            this.Controls.Add(this.Input_Cognome);
            this.Controls.Add(this.Input_Nome);
            this.Controls.Add(this.Sesso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Sesso.ResumeLayout(false);
            this.Sesso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Sesso;
        private System.Windows.Forms.RadioButton Femmina;
        private System.Windows.Forms.RadioButton Maschio;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox Input_Nome;
        private System.Windows.Forms.TextBox Input_Cognome;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Data_di_nascita;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Label Label_Cognome;
        private System.Windows.Forms.Label label_comune_nascita;
        private System.Windows.Forms.Label label_data_nascita;
        private System.Windows.Forms.Button btn_Calcola;
        private System.Windows.Forms.ComboBox Input_comune_di_nascita;
    }
}

