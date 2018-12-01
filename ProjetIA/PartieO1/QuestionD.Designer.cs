namespace PartieO1
{
    partial class QuestionD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionD));
            this.lbl_cons = new System.Windows.Forms.Label();
            this.lbl_verif_suivant = new System.Windows.Forms.Label();
            this.lbl_verif_arbre = new System.Windows.Forms.Label();
            this.btn_verif_arbre = new System.Windows.Forms.Button();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.listBoxF = new System.Windows.Forms.ListBox();
            this.listBoxO = new System.Windows.Forms.ListBox();
            this.checkedListBoxF = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxO = new System.Windows.Forms.CheckedListBox();
            this.Fermes = new System.Windows.Forms.Label();
            this.Ouverts = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_validation = new System.Windows.Forms.Button();
            this.arbreJuste = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cons
            // 
            this.lbl_cons.Location = new System.Drawing.Point(28, 22);
            this.lbl_cons.Name = "lbl_cons";
            this.lbl_cons.Size = new System.Drawing.Size(352, 100);
            this.lbl_cons.TabIndex = 37;
            this.lbl_cons.Text = resources.GetString("lbl_cons.Text");
            // 
            // lbl_verif_suivant
            // 
            this.lbl_verif_suivant.AutoSize = true;
            this.lbl_verif_suivant.Location = new System.Drawing.Point(540, 468);
            this.lbl_verif_suivant.Name = "lbl_verif_suivant";
            this.lbl_verif_suivant.Size = new System.Drawing.Size(0, 13);
            this.lbl_verif_suivant.TabIndex = 36;
            // 
            // lbl_verif_arbre
            // 
            this.lbl_verif_arbre.AutoSize = true;
            this.lbl_verif_arbre.Location = new System.Drawing.Point(540, 109);
            this.lbl_verif_arbre.Name = "lbl_verif_arbre";
            this.lbl_verif_arbre.Size = new System.Drawing.Size(0, 13);
            this.lbl_verif_arbre.TabIndex = 34;
            // 
            // btn_verif_arbre
            // 
            this.btn_verif_arbre.Location = new System.Drawing.Point(525, 57);
            this.btn_verif_arbre.Name = "btn_verif_arbre";
            this.btn_verif_arbre.Size = new System.Drawing.Size(75, 23);
            this.btn_verif_arbre.TabIndex = 33;
            this.btn_verif_arbre.Text = "Vérifier";
            this.btn_verif_arbre.UseVisualStyleBackColor = true;
            this.btn_verif_arbre.Click += new System.EventHandler(this.btn_verif_arbre_Click);
            // 
            // btn_suivant
            // 
            this.btn_suivant.Location = new System.Drawing.Point(525, 408);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(75, 23);
            this.btn_suivant.TabIndex = 32;
            this.btn_suivant.Text = "Suivant";
            this.btn_suivant.UseVisualStyleBackColor = true;
            this.btn_suivant.Click += new System.EventHandler(this.btn_suivant_Click);
            // 
            // listBoxF
            // 
            this.listBoxF.FormattingEnabled = true;
            this.listBoxF.Location = new System.Drawing.Point(613, 444);
            this.listBoxF.Name = "listBoxF";
            this.listBoxF.Size = new System.Drawing.Size(106, 147);
            this.listBoxF.TabIndex = 31;
            // 
            // listBoxO
            // 
            this.listBoxO.FormattingEnabled = true;
            this.listBoxO.Location = new System.Drawing.Point(419, 444);
            this.listBoxO.Name = "listBoxO";
            this.listBoxO.Size = new System.Drawing.Size(102, 147);
            this.listBoxO.TabIndex = 30;
            // 
            // checkedListBoxF
            // 
            this.checkedListBoxF.FormattingEnabled = true;
            this.checkedListBoxF.Location = new System.Drawing.Point(613, 236);
            this.checkedListBoxF.Name = "checkedListBoxF";
            this.checkedListBoxF.Size = new System.Drawing.Size(116, 154);
            this.checkedListBoxF.TabIndex = 29;
            // 
            // checkedListBoxO
            // 
            this.checkedListBoxO.FormattingEnabled = true;
            this.checkedListBoxO.Location = new System.Drawing.Point(409, 236);
            this.checkedListBoxO.Name = "checkedListBoxO";
            this.checkedListBoxO.Size = new System.Drawing.Size(113, 154);
            this.checkedListBoxO.TabIndex = 28;
            // 
            // Fermes
            // 
            this.Fermes.AutoSize = true;
            this.Fermes.Location = new System.Drawing.Point(610, 210);
            this.Fermes.Name = "Fermes";
            this.Fermes.Size = new System.Drawing.Size(41, 13);
            this.Fermes.TabIndex = 27;
            this.Fermes.Text = "Fermés";
            // 
            // Ouverts
            // 
            this.Ouverts.AutoSize = true;
            this.Ouverts.Location = new System.Drawing.Point(406, 210);
            this.Ouverts.Name = "Ouverts";
            this.Ouverts.Size = new System.Drawing.Size(44, 13);
            this.Ouverts.TabIndex = 26;
            this.Ouverts.Text = "Ouverts";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "../../images/graphe1.JPG";
            this.pictureBox1.Location = new System.Drawing.Point(52, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 498);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(419, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(88, 179);
            this.treeView1.TabIndex = 24;
            // 
            // btn_validation
            // 
            this.btn_validation.Location = new System.Drawing.Point(513, 627);
            this.btn_validation.Name = "btn_validation";
            this.btn_validation.Size = new System.Drawing.Size(117, 23);
            this.btn_validation.TabIndex = 38;
            this.btn_validation.Text = "Finir la question";
            this.btn_validation.UseVisualStyleBackColor = true;
            this.btn_validation.Click += new System.EventHandler(this.btn_validation_Click);
            // 
            // arbreJuste
            // 
            this.arbreJuste.Enabled = false;
            this.arbreJuste.LabelEdit = true;
            this.arbreJuste.Location = new System.Drawing.Point(613, 22);
            this.arbreJuste.Name = "arbreJuste";
            this.arbreJuste.Size = new System.Drawing.Size(88, 169);
            this.arbreJuste.TabIndex = 35;
            this.arbreJuste.Visible = false;
            // 
            // QuestionD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 674);
            this.Controls.Add(this.btn_validation);
            this.Controls.Add(this.lbl_cons);
            this.Controls.Add(this.lbl_verif_suivant);
            this.Controls.Add(this.arbreJuste);
            this.Controls.Add(this.lbl_verif_arbre);
            this.Controls.Add(this.btn_verif_arbre);
            this.Controls.Add(this.btn_suivant);
            this.Controls.Add(this.listBoxF);
            this.Controls.Add(this.listBoxO);
            this.Controls.Add(this.checkedListBoxF);
            this.Controls.Add(this.checkedListBoxO);
            this.Controls.Add(this.Fermes);
            this.Controls.Add(this.Ouverts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "QuestionD";
            this.Text = "QuestionD";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_cons;
        private System.Windows.Forms.Label lbl_verif_suivant;
        private System.Windows.Forms.Label lbl_verif_arbre;
        private System.Windows.Forms.Button btn_verif_arbre;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.ListBox listBoxF;
        private System.Windows.Forms.ListBox listBoxO;
        private System.Windows.Forms.CheckedListBox checkedListBoxF;
        private System.Windows.Forms.CheckedListBox checkedListBoxO;
        private System.Windows.Forms.Label Fermes;
        private System.Windows.Forms.Label Ouverts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_validation;
        private System.Windows.Forms.TreeView arbreJuste;
    }
}