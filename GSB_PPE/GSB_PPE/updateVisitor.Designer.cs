namespace GSB_PPE
{
    partial class updateVisitor
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
            this.button1 = new System.Windows.Forms.Button();
            this.lastNameUpdate = new System.Windows.Forms.TextBox();
            this.fisrtNameUpdate = new System.Windows.Forms.TextBox();
            this.adressUpdate = new System.Windows.Forms.TextBox();
            this.recrutementDateUpdate = new System.Windows.Forms.TextBox();
            this.saveUpdateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.visitorIdUpdate = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lastNameUpdate
            // 
            this.lastNameUpdate.Location = new System.Drawing.Point(454, 114);
            this.lastNameUpdate.Name = "lastNameUpdate";
            this.lastNameUpdate.Size = new System.Drawing.Size(138, 20);
            this.lastNameUpdate.TabIndex = 1;
            this.lastNameUpdate.TextChanged += new System.EventHandler(this.lastNameUpdate_TextChanged);
            // 
            // fisrtNameUpdate
            // 
            this.fisrtNameUpdate.Location = new System.Drawing.Point(454, 154);
            this.fisrtNameUpdate.Name = "fisrtNameUpdate";
            this.fisrtNameUpdate.Size = new System.Drawing.Size(138, 20);
            this.fisrtNameUpdate.TabIndex = 2;
            // 
            // adressUpdate
            // 
            this.adressUpdate.Location = new System.Drawing.Point(454, 196);
            this.adressUpdate.Name = "adressUpdate";
            this.adressUpdate.Size = new System.Drawing.Size(138, 20);
            this.adressUpdate.TabIndex = 3;
            // 
            // recrutementDateUpdate
            // 
            this.recrutementDateUpdate.Location = new System.Drawing.Point(454, 240);
            this.recrutementDateUpdate.Name = "recrutementDateUpdate";
            this.recrutementDateUpdate.Size = new System.Drawing.Size(138, 20);
            this.recrutementDateUpdate.TabIndex = 4;
            // 
            // saveUpdateButton
            // 
            this.saveUpdateButton.Location = new System.Drawing.Point(480, 360);
            this.saveUpdateButton.Name = "saveUpdateButton";
            this.saveUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.saveUpdateButton.TabIndex = 5;
            this.saveUpdateButton.Text = "Enregistrer";
            this.saveUpdateButton.UseVisualStyleBackColor = true;
            this.saveUpdateButton.Click += new System.EventHandler(this.saveUpdateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Addresse :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date de recrutement :";
            // 
            // visitorIdUpdate
            // 
            this.visitorIdUpdate.Location = new System.Drawing.Point(480, 72);
            this.visitorIdUpdate.Name = "visitorIdUpdate";
            this.visitorIdUpdate.Size = new System.Drawing.Size(100, 20);
            this.visitorIdUpdate.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(454, 280);
            this.comboBox1.MaxDropDownItems = 64;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Departements :";
            // 
            // updateVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 474);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.visitorIdUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveUpdateButton);
            this.Controls.Add(this.recrutementDateUpdate);
            this.Controls.Add(this.adressUpdate);
            this.Controls.Add(this.fisrtNameUpdate);
            this.Controls.Add(this.lastNameUpdate);
            this.Controls.Add(this.button1);
            this.Name = "updateVisitor";
            this.Text = "updateVisitor";
            this.Load += new System.EventHandler(this.updateVisitor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lastNameUpdate;
        private System.Windows.Forms.TextBox fisrtNameUpdate;
        private System.Windows.Forms.TextBox adressUpdate;
        private System.Windows.Forms.TextBox recrutementDateUpdate;
        private System.Windows.Forms.Button saveUpdateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox visitorIdUpdate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}