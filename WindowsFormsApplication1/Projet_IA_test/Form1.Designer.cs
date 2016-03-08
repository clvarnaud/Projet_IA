namespace Projet_IA_test
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.impasse_btn = new System.Windows.Forms.Button();
            this.impasse_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_depart = new System.Windows.Forms.TextBox();
            this.textBox_arrivee = new System.Windows.Forms.TextBox();
            this.button_recherche_plus_court = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listbox_affichage = new System.Windows.Forms.ListBox();
            this.textBox_chemin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_recherche_chemin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // impasse_btn
            // 
            this.impasse_btn.Location = new System.Drawing.Point(34, 36);
            this.impasse_btn.Name = "impasse_btn";
            this.impasse_btn.Size = new System.Drawing.Size(75, 23);
            this.impasse_btn.TabIndex = 0;
            this.impasse_btn.Text = "impasse";
            this.impasse_btn.UseVisualStyleBackColor = true;
            this.impasse_btn.Click += new System.EventHandler(this.impasse_btn_Click);
            // 
            // impasse_label
            // 
            this.impasse_label.AutoSize = true;
            this.impasse_label.Location = new System.Drawing.Point(154, 41);
            this.impasse_label.Name = "impasse_label";
            this.impasse_label.Size = new System.Drawing.Size(35, 13);
            this.impasse_label.TabIndex = 1;
            this.impasse_label.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Point de départ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Point d\'arrivée :";
            // 
            // textBox_depart
            // 
            this.textBox_depart.Location = new System.Drawing.Point(117, 90);
            this.textBox_depart.Name = "textBox_depart";
            this.textBox_depart.Size = new System.Drawing.Size(50, 20);
            this.textBox_depart.TabIndex = 4;
            this.textBox_depart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_arrivee
            // 
            this.textBox_arrivee.Location = new System.Drawing.Point(117, 132);
            this.textBox_arrivee.Name = "textBox_arrivee";
            this.textBox_arrivee.Size = new System.Drawing.Size(50, 20);
            this.textBox_arrivee.TabIndex = 5;
            // 
            // button_recherche_plus_court
            // 
            this.button_recherche_plus_court.Location = new System.Drawing.Point(197, 112);
            this.button_recherche_plus_court.Name = "button_recherche_plus_court";
            this.button_recherche_plus_court.Size = new System.Drawing.Size(75, 23);
            this.button_recherche_plus_court.TabIndex = 6;
            this.button_recherche_plus_court.Text = "Rechercher";
            this.button_recherche_plus_court.UseVisualStyleBackColor = true;
            this.button_recherche_plus_court.Click += new System.EventHandler(this.button_recherche_plus_court_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // listbox_affichage
            // 
            this.listbox_affichage.FormattingEnabled = true;
            this.listbox_affichage.Location = new System.Drawing.Point(34, 193);
            this.listbox_affichage.Name = "listbox_affichage";
            this.listbox_affichage.Size = new System.Drawing.Size(223, 95);
            this.listbox_affichage.TabIndex = 8;
            // 
            // textBox_chemin
            // 
            this.textBox_chemin.Location = new System.Drawing.Point(411, 114);
            this.textBox_chemin.Name = "textBox_chemin";
            this.textBox_chemin.Size = new System.Drawing.Size(100, 20);
            this.textBox_chemin.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Chemin :";
            // 
            // button_recherche_chemin
            // 
            this.button_recherche_chemin.Location = new System.Drawing.Point(546, 114);
            this.button_recherche_chemin.Name = "button_recherche_chemin";
            this.button_recherche_chemin.Size = new System.Drawing.Size(75, 23);
            this.button_recherche_chemin.TabIndex = 11;
            this.button_recherche_chemin.Text = "Rechercher";
            this.button_recherche_chemin.UseVisualStyleBackColor = true;
            this.button_recherche_chemin.Click += new System.EventHandler(this.button_recherche_chemin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 330);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_recherche_chemin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_chemin);
            this.Controls.Add(this.listbox_affichage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_recherche_plus_court);
            this.Controls.Add(this.textBox_arrivee);
            this.Controls.Add(this.textBox_depart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.impasse_label);
            this.Controls.Add(this.impasse_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button impasse_btn;
        private System.Windows.Forms.Label impasse_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_depart;
        private System.Windows.Forms.TextBox textBox_arrivee;
        private System.Windows.Forms.Button button_recherche_plus_court;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listbox_affichage;
        private System.Windows.Forms.TextBox textBox_chemin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_recherche_chemin;
        private System.Windows.Forms.Label label5;
    }
}

