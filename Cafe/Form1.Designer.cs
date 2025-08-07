namespace Cafe
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
            tabControlCafe = new TabControl();
            tabDrinks = new TabPage();
            tabDesserts = new TabPage();
            tabFoods = new TabPage();
            dgvItems = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            tabControlCafe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // tabControlCafe
            // 
            tabControlCafe.Controls.Add(tabDrinks);
            tabControlCafe.Controls.Add(tabDesserts);
            tabControlCafe.Controls.Add(tabFoods);
            tabControlCafe.Location = new Point(0, 0);
            tabControlCafe.Name = "tabControlCafe";
            tabControlCafe.SelectedIndex = 0;
            tabControlCafe.Size = new Size(491, 45);
            tabControlCafe.TabIndex = 0;
            tabControlCafe.Tag = "";
            tabControlCafe.SelectedIndexChanged += tabControlCafe_SelectedIndexChanged;
            // 
            // tabDrinks
            // 
            tabDrinks.Location = new Point(4, 29);
            tabDrinks.Name = "tabDrinks";
            tabDrinks.Padding = new Padding(3);
            tabDrinks.Size = new Size(483, 12);
            tabDrinks.TabIndex = 0;
            tabDrinks.Text = "Drinks";
            tabDrinks.UseVisualStyleBackColor = true;
            // 
            // tabDesserts
            // 
            tabDesserts.Location = new Point(4, 29);
            tabDesserts.Name = "tabDesserts";
            tabDesserts.Padding = new Padding(3);
            tabDesserts.Size = new Size(483, 12);
            tabDesserts.TabIndex = 1;
            tabDesserts.Text = "Desserts";
            tabDesserts.UseVisualStyleBackColor = true;
            // 
            // tabFoods
            // 
            tabFoods.Location = new Point(4, 29);
            tabFoods.Name = "tabFoods";
            tabFoods.Padding = new Padding(3);
            tabFoods.Size = new Size(483, 12);
            tabFoods.TabIndex = 2;
            tabFoods.Text = "Foods";
            tabFoods.UseVisualStyleBackColor = true;
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(4, 47);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 51;
            dgvItems.Size = new Size(487, 188);
            dgvItems.TabIndex = 0;
            dgvItems.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 259);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(140, 259);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(268, 259);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(383, 259);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 321);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvItems);
            Controls.Add(tabControlCafe);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControlCafe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlCafe;
        private TabPage tabDrinks;
        private TabPage tabDesserts;
        private TabPage tabFoods;
        private DataGridView dgvItems;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
    }
}
