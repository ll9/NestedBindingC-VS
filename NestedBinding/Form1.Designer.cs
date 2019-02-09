namespace NestedBinding
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label alterLabel;
            System.Windows.Forms.Label nameLabel;
            this.alterTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressesDataGridView = new System.Windows.Forms.DataGridView();
            this.pLZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.straßeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            alterLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // alterLabel
            // 
            alterLabel.AutoSize = true;
            alterLabel.Location = new System.Drawing.Point(56, 35);
            alterLabel.Name = "alterLabel";
            alterLabel.Size = new System.Drawing.Size(31, 13);
            alterLabel.TabIndex = 0;
            alterLabel.Text = "Alter:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(56, 61);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // alterTextBox
            // 
            this.alterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Alter", true));
            this.alterTextBox.Location = new System.Drawing.Point(100, 32);
            this.alterTextBox.Name = "alterTextBox";
            this.alterTextBox.Size = new System.Drawing.Size(100, 20);
            this.alterTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(100, 58);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(NestedBinding.Models.Person);
            // 
            // addressesBindingSource
            // 
            this.addressesBindingSource.DataSource = typeof(NestedBinding.Models.Address);
            // 
            // addressesDataGridView
            // 
            this.addressesDataGridView.AutoGenerateColumns = false;
            this.addressesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addressesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pLZDataGridViewTextBoxColumn,
            this.ortDataGridViewTextBoxColumn,
            this.straßeDataGridViewTextBoxColumn});
            this.addressesDataGridView.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.personBindingSource, "Addresses", true));
            this.addressesDataGridView.DataSource = this.addressesBindingSource;
            this.addressesDataGridView.Location = new System.Drawing.Point(59, 98);
            this.addressesDataGridView.Name = "addressesDataGridView";
            this.addressesDataGridView.Size = new System.Drawing.Size(346, 220);
            this.addressesDataGridView.TabIndex = 4;
            // 
            // pLZDataGridViewTextBoxColumn
            // 
            this.pLZDataGridViewTextBoxColumn.DataPropertyName = "PLZ";
            this.pLZDataGridViewTextBoxColumn.HeaderText = "PLZ";
            this.pLZDataGridViewTextBoxColumn.Name = "pLZDataGridViewTextBoxColumn";
            // 
            // ortDataGridViewTextBoxColumn
            // 
            this.ortDataGridViewTextBoxColumn.DataPropertyName = "Ort";
            this.ortDataGridViewTextBoxColumn.HeaderText = "Ort";
            this.ortDataGridViewTextBoxColumn.Name = "ortDataGridViewTextBoxColumn";
            // 
            // straßeDataGridViewTextBoxColumn
            // 
            this.straßeDataGridViewTextBoxColumn.DataPropertyName = "Straße";
            this.straßeDataGridViewTextBoxColumn.HeaderText = "Straße";
            this.straßeDataGridViewTextBoxColumn.Name = "straßeDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.addressesDataGridView);
            this.Controls.Add(alterLabel);
            this.Controls.Add(this.alterTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.TextBox alterTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingSource addressesBindingSource;
        private System.Windows.Forms.DataGridView addressesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn straßeDataGridViewTextBoxColumn;
    }
}

