namespace PartieO1
{
    partial class qcm
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
            System.Windows.Forms.Button buttonStart;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qcm));
            this.BigTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.homeBttn = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.finLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nextBttn = new System.Windows.Forms.Button();
            this.numQuestion = new System.Windows.Forms.Label();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.questionLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            buttonStart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new System.Drawing.Point(187, 507);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new System.Drawing.Size(141, 33);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "COMMENCER ";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // BigTitle
            // 
            this.BigTitle.BackColor = System.Drawing.SystemColors.Control;
            this.BigTitle.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BigTitle.Location = new System.Drawing.Point(109, 125);
            this.BigTitle.Name = "BigTitle";
            this.BigTitle.Size = new System.Drawing.Size(362, 192);
            this.BigTitle.TabIndex = 0;
            this.BigTitle.Text = "Testez vos connaissances en Intelligence Artificielle  !";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.nextBttn);
            this.panel1.Controls.Add(this.numQuestion);
            this.panel1.Controls.Add(this.rbD);
            this.panel1.Controls.Add(this.rbC);
            this.panel1.Controls.Add(this.rbB);
            this.panel1.Controls.Add(this.rbA);
            this.panel1.Controls.Add(this.questionLabel);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 703);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.homeBttn);
            this.panel2.Controls.Add(this.scoreLabel);
            this.panel2.Controls.Add(this.finLabel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 703);
            this.panel2.TabIndex = 11;
            this.panel2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Accueil";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "0/20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fin du QCM";
            // 
            // homeBttn
            // 
            this.homeBttn.Location = new System.Drawing.Point(596, 357);
            this.homeBttn.Name = "homeBttn";
            this.homeBttn.Size = new System.Drawing.Size(75, 23);
            this.homeBttn.TabIndex = 2;
            this.homeBttn.Text = "Accueil";
            this.homeBttn.UseVisualStyleBackColor = true;
            this.homeBttn.Click += new System.EventHandler(this.homeBttn_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(626, 313);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(30, 13);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "0/20";
            // 
            // finLabel
            // 
            this.finLabel.AutoSize = true;
            this.finLabel.Location = new System.Drawing.Point(608, 251);
            this.finLabel.Name = "finLabel";
            this.finLabel.Size = new System.Drawing.Size(63, 13);
            this.finLabel.TabIndex = 0;
            this.finLabel.Text = "Fin du QCM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "H:\\IA\\Projet\\ProjetIA\\ProjetIA\\PartieO1\\images\\seeulater.jpeg";
            this.pictureBox1.Location = new System.Drawing.Point(21, 450);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 241);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // nextBttn
            // 
            this.nextBttn.Location = new System.Drawing.Point(374, 409);
            this.nextBttn.Name = "nextBttn";
            this.nextBttn.Size = new System.Drawing.Size(75, 23);
            this.nextBttn.TabIndex = 10;
            this.nextBttn.Text = "Suivant";
            this.nextBttn.UseVisualStyleBackColor = true;
            this.nextBttn.Click += new System.EventHandler(this.NextBttn_Click);
            // 
            // numQuestion
            // 
            this.numQuestion.AutoSize = true;
            this.numQuestion.Location = new System.Drawing.Point(245, 46);
            this.numQuestion.Name = "numQuestion";
            this.numQuestion.Size = new System.Drawing.Size(30, 13);
            this.numQuestion.TabIndex = 9;
            this.numQuestion.Text = "1/20";
            // 
            // rbD
            // 
            this.rbD.Location = new System.Drawing.Point(121, 357);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(200, 75);
            this.rbD.TabIndex = 8;
            this.rbD.TabStop = true;
            this.rbD.Text = "radioButton4";
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.Location = new System.Drawing.Point(121, 282);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(200, 75);
            this.rbC.TabIndex = 7;
            this.rbC.TabStop = true;
            this.rbC.Text = "radioButton3";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.Location = new System.Drawing.Point(121, 210);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(200, 75);
            this.rbB.TabIndex = 6;
            this.rbB.TabStop = true;
            this.rbB.Text = "radioButton2";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbA
            // 
            this.rbA.Location = new System.Drawing.Point(121, 143);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(200, 75);
            this.rbA.TabIndex = 5;
            this.rbA.TabStop = true;
            this.rbA.Text = "radioButton1";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // questionLabel
            // 
            this.questionLabel.Location = new System.Drawing.Point(98, 81);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(500, 70);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Mais que voilà si ce n\'est la question suivanteqfq\r\nretezte\r\nzerrtze\r\n\r\nrsdg";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(57, 195);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // qcm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(buttonStart);
            this.Controls.Add(this.BigTitle);
            this.Name = "qcm";
            this.Text = "QCM";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BigTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label numQuestion;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button nextBttn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button homeBttn;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label finLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

