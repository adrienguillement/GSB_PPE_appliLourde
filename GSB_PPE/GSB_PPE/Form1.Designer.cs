namespace GSB_PPE
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.newVisitorButton = new System.Windows.Forms.Button();
            this.recruitment_date = new System.Windows.Forms.TextBox();
            this.recruitment = new System.Windows.Forms.Label();
            this.first_name_visitor = new System.Windows.Forms.TextBox();
            this.first_name = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.Label();
            this.last_name_visitor = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIdDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notorietyCoefDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recruitmentdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitorBuildBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBuildBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(972, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.newVisitorButton);
            this.tabPage1.Controls.Add(this.recruitment_date);
            this.tabPage1.Controls.Add(this.recruitment);
            this.tabPage1.Controls.Add(this.first_name_visitor);
            this.tabPage1.Controls.Add(this.first_name);
            this.tabPage1.Controls.Add(this.title);
            this.tabPage1.Controls.Add(this.last_name);
            this.tabPage1.Controls.Add(this.last_name_visitor);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(964, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visiteurs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // newVisitorButton
            // 
            this.newVisitorButton.Location = new System.Drawing.Point(6, 6);
            this.newVisitorButton.Name = "newVisitorButton";
            this.newVisitorButton.Size = new System.Drawing.Size(128, 23);
            this.newVisitorButton.TabIndex = 8;
            this.newVisitorButton.Text = "Nouveau Visiteur";
            this.newVisitorButton.UseVisualStyleBackColor = true;
            this.newVisitorButton.Click += new System.EventHandler(this.newVisitorButton_Click);
            // 
            // recruitment_date
            // 
            this.recruitment_date.Location = new System.Drawing.Point(125, 198);
            this.recruitment_date.Name = "recruitment_date";
            this.recruitment_date.Size = new System.Drawing.Size(100, 20);
            this.recruitment_date.TabIndex = 7;
            this.recruitment_date.TextChanged += new System.EventHandler(this.recruitment_date_TextChanged);
            // 
            // recruitment
            // 
            this.recruitment.AutoSize = true;
            this.recruitment.Location = new System.Drawing.Point(9, 201);
            this.recruitment.Name = "recruitment";
            this.recruitment.Size = new System.Drawing.Size(110, 13);
            this.recruitment.TabIndex = 6;
            this.recruitment.Text = "Date de recrutement :";
            // 
            // first_name_visitor
            // 
            this.first_name_visitor.Location = new System.Drawing.Point(125, 149);
            this.first_name_visitor.Name = "first_name_visitor";
            this.first_name_visitor.Size = new System.Drawing.Size(100, 20);
            this.first_name_visitor.TabIndex = 5;
            this.first_name_visitor.TextChanged += new System.EventHandler(this.first_name_visitor_TextChanged);
            // 
            // first_name
            // 
            this.first_name.AutoSize = true;
            this.first_name.Location = new System.Drawing.Point(69, 152);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(49, 13);
            this.first_name.TabIndex = 4;
            this.first_name.Text = "Prénom :";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(36, 59);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(66, 22);
            this.title.TabIndex = 3;
            this.title.Text = "Filtrer :";
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.Location = new System.Drawing.Point(83, 101);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(35, 13);
            this.last_name.TabIndex = 2;
            this.last_name.Text = "Nom :";
            // 
            // last_name_visitor
            // 
            this.last_name_visitor.Location = new System.Drawing.Point(125, 98);
            this.last_name_visitor.Name = "last_name_visitor";
            this.last_name_visitor.Size = new System.Drawing.Size(100, 20);
            this.last_name_visitor.TabIndex = 1;
            this.last_name_visitor.TextChanged += new System.EventHandler(this.last_name_visitor_TextChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.recruitmentdateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.Supprimer});
            this.dataGridView1.DataSource = this.visitorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(231, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(727, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(964, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Docteurs";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDoctor,
            this.typeIdDoctor,
            this.lastNameDoctor,
            this.firstNameDoctor,
            this.addressDoctor,
            this.notorietyCoefDoctor});
            this.dataGridView2.Location = new System.Drawing.Point(51, 99);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(646, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // idDoctor
            // 
            this.idDoctor.Frozen = true;
            this.idDoctor.HeaderText = "Numéro";
            this.idDoctor.Name = "idDoctor";
            this.idDoctor.ReadOnly = true;
            // 
            // typeIdDoctor
            // 
            this.typeIdDoctor.HeaderText = "Numéro type";
            this.typeIdDoctor.Name = "typeIdDoctor";
            // 
            // lastNameDoctor
            // 
            this.lastNameDoctor.HeaderText = "Nom";
            this.lastNameDoctor.Name = "lastNameDoctor";
            // 
            // firstNameDoctor
            // 
            this.firstNameDoctor.HeaderText = "Prénom";
            this.firstNameDoctor.Name = "firstNameDoctor";
            // 
            // addressDoctor
            // 
            this.addressDoctor.HeaderText = "Adresse";
            this.addressDoctor.Name = "addressDoctor";
            // 
            // notorietyCoefDoctor
            // 
            this.notorietyCoefDoctor.HeaderText = "Coefficient de notoriété";
            this.notorietyCoefDoctor.Name = "notorietyCoefDoctor";
            // 
            // Supprimer
            // 
            this.Supprimer.DataPropertyName = "id";
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Addresse";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // recruitmentdateDataGridViewTextBoxColumn
            // 
            this.recruitmentdateDataGridViewTextBoxColumn.DataPropertyName = "recruitment_date";
            this.recruitmentdateDataGridViewTextBoxColumn.HeaderText = "Date de recrutement";
            this.recruitmentdateDataGridViewTextBoxColumn.Name = "recruitmentdateDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Département";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // visitorBindingSource
            // 
            this.visitorBindingSource.DataSource = typeof(Models.src.metiers.Visitor);
            // 
            // visitorBuildBindingSource
            // 
            this.visitorBuildBindingSource.DataSource = typeof(Models.src.build.VisitorBuild);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "GSB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBuildBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIdDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn notorietyCoefDoctor;
        private System.Windows.Forms.BindingSource visitorBindingSource;
        private System.Windows.Forms.TextBox last_name_visitor;
        private System.Windows.Forms.Label last_name;
        private System.Windows.Forms.TextBox first_name_visitor;
        private System.Windows.Forms.Label first_name;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox recruitment_date;
        private System.Windows.Forms.Label recruitment;
        private System.Windows.Forms.Button newVisitorButton;
        private System.Windows.Forms.BindingSource visitorBuildBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recruitmentdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.Button button1;
    }
}

