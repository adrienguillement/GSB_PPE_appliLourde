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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recruitmentdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.visitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.filterFullName = new System.Windows.Forms.TextBox();
            this.validFicheFraisComboBox = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.visitorComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbhorsclassifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montanthorsclassifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitorBuildBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseReportBindingSource)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1105, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Size = new System.Drawing.Size(1097, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visiteurs";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
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
            this.recruitment_date.Location = new System.Drawing.Point(110, 198);
            this.recruitment_date.Name = "recruitment_date";
            this.recruitment_date.Size = new System.Drawing.Size(100, 20);
            this.recruitment_date.TabIndex = 7;
            this.recruitment_date.TextChanged += new System.EventHandler(this.recruitment_date_TextChanged);
            // 
            // recruitment
            // 
            this.recruitment.AutoSize = true;
            this.recruitment.Location = new System.Drawing.Point(3, 201);
            this.recruitment.Name = "recruitment";
            this.recruitment.Size = new System.Drawing.Size(110, 13);
            this.recruitment.TabIndex = 6;
            this.recruitment.Text = "Date de recrutement :";
            // 
            // first_name_visitor
            // 
            this.first_name_visitor.Location = new System.Drawing.Point(110, 149);
            this.first_name_visitor.Name = "first_name_visitor";
            this.first_name_visitor.Size = new System.Drawing.Size(100, 20);
            this.first_name_visitor.TabIndex = 5;
            this.first_name_visitor.TextChanged += new System.EventHandler(this.first_name_visitor_TextChanged);
            // 
            // first_name
            // 
            this.first_name.AutoSize = true;
            this.first_name.Location = new System.Drawing.Point(3, 152);
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
            this.last_name.Location = new System.Drawing.Point(3, 98);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(35, 13);
            this.last_name.TabIndex = 2;
            this.last_name.Text = "Nom :";
            // 
            // last_name_visitor
            // 
            this.last_name_visitor.Location = new System.Drawing.Point(110, 91);
            this.last_name_visitor.Name = "last_name_visitor";
            this.last_name_visitor.Size = new System.Drawing.Size(100, 20);
            this.last_name_visitor.TabIndex = 1;
            this.last_name_visitor.TextChanged += new System.EventHandler(this.last_name_visitor_TextChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.recruitmentdateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.Modifier,
            this.Supprimer});
            this.dataGridView1.DataSource = this.visitorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(216, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(850, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Addresse";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recruitmentdateDataGridViewTextBoxColumn
            // 
            this.recruitmentdateDataGridViewTextBoxColumn.DataPropertyName = "recruitment_date";
            this.recruitmentdateDataGridViewTextBoxColumn.HeaderText = "Date de recrutement";
            this.recruitmentdateDataGridViewTextBoxColumn.Name = "recruitmentdateDataGridViewTextBoxColumn";
            this.recruitmentdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Département";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Modifier
            // 
            this.Modifier.DataPropertyName = "id";
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Name = "Modifier";
            this.Modifier.ReadOnly = true;
            this.Modifier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modifier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseColumnTextForButtonValue = true;
            // 
            // Supprimer
            // 
            this.Supprimer.DataPropertyName = "id";
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.ReadOnly = true;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // visitorBindingSource
            // 
            this.visitorBindingSource.DataSource = typeof(Models.src.metiers.Visitor);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.filterFullName);
            this.tabPage2.Controls.Add(this.validFicheFraisComboBox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.visitorComboBox);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1097, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.Location = new System.Drawing.Point(308, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // filterFullName
            // 
            this.filterFullName.Location = new System.Drawing.Point(45, 333);
            this.filterFullName.Name = "filterFullName";
            this.filterFullName.Size = new System.Drawing.Size(100, 20);
            this.filterFullName.TabIndex = 6;
            this.filterFullName.TextChanged += new System.EventHandler(this.filterFullName_TextChanged);
            // 
            // validFicheFraisComboBox
            // 
            this.validFicheFraisComboBox.Location = new System.Drawing.Point(104, 115);
            this.validFicheFraisComboBox.Name = "validFicheFraisComboBox";
            this.validFicheFraisComboBox.Size = new System.Drawing.Size(75, 23);
            this.validFicheFraisComboBox.TabIndex = 5;
            this.validFicheFraisComboBox.Text = "Valider";
            this.validFicheFraisComboBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mois :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Visiteur :";
            // 
            // visitorComboBox
            // 
            this.visitorComboBox.FormattingEnabled = true;
            this.visitorComboBox.Location = new System.Drawing.Point(104, 25);
            this.visitorComboBox.Name = "visitorComboBox";
            this.visitorComboBox.Size = new System.Drawing.Size(121, 21);
            this.visitorComboBox.TabIndex = 1;
            this.visitorComboBox.SelectedIndexChanged += new System.EventHandler(this.visitorComboBox_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.monthyearDataGridViewTextBoxColumn,
            this.visitoridDataGridViewTextBoxColumn,
            this.nbhorsclassifDataGridViewTextBoxColumn,
            this.montanthorsclassifDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.expenseReportBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(201, 228);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(551, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // monthyearDataGridViewTextBoxColumn
            // 
            this.monthyearDataGridViewTextBoxColumn.DataPropertyName = "month_year";
            this.monthyearDataGridViewTextBoxColumn.HeaderText = "month_year";
            this.monthyearDataGridViewTextBoxColumn.Name = "monthyearDataGridViewTextBoxColumn";
            // 
            // visitoridDataGridViewTextBoxColumn
            // 
            this.visitoridDataGridViewTextBoxColumn.DataPropertyName = "visitor_id";
            this.visitoridDataGridViewTextBoxColumn.HeaderText = "visitor_id";
            this.visitoridDataGridViewTextBoxColumn.Name = "visitoridDataGridViewTextBoxColumn";
            // 
            // nbhorsclassifDataGridViewTextBoxColumn
            // 
            this.nbhorsclassifDataGridViewTextBoxColumn.DataPropertyName = "nb_hors_classif";
            this.nbhorsclassifDataGridViewTextBoxColumn.HeaderText = "nb_hors_classif";
            this.nbhorsclassifDataGridViewTextBoxColumn.Name = "nbhorsclassifDataGridViewTextBoxColumn";
            // 
            // montanthorsclassifDataGridViewTextBoxColumn
            // 
            this.montanthorsclassifDataGridViewTextBoxColumn.DataPropertyName = "montant_hors_classif";
            this.montanthorsclassifDataGridViewTextBoxColumn.HeaderText = "montant_hors_classif";
            this.montanthorsclassifDataGridViewTextBoxColumn.Name = "montanthorsclassifDataGridViewTextBoxColumn";
            // 
            // expenseReportBindingSource
            // 
            this.expenseReportBindingSource.DataSource = typeof(Models.src.metiers.ExpenseReport);
            // 
            // visitorBuildBindingSource
            // 
            this.visitorBuildBindingSource.DataSource = typeof(Models.src.build.VisitorBuild);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 581);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "GSB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBuildBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbhorsclassifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montanthorsclassifDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource expenseReportBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox visitorComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button validFicheFraisComboBox;
        private System.Windows.Forms.TextBox filterFullName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

