﻿
namespace VideoClubManagement.UI.Cast
{
    partial class castForm
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
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.castDataGridView = new System.Windows.Forms.DataGridView();
            this.insertPanel = new System.Windows.Forms.Panel();
            this.languageLabel = new System.Windows.Forms.Label();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.searchPanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.castDataGridView)).BeginInit();
            this.insertPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Location = new System.Drawing.Point(388, 12);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(372, 66);
            this.searchPanel.TabIndex = 11;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(5, 28);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(236, 20);
            this.searchTextBox.TabIndex = 19;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(247, 26);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Buscar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.backButton);
            this.actionPanel.Controls.Add(this.deleteButton);
            this.actionPanel.Controls.Add(this.updateButton);
            this.actionPanel.Controls.Add(this.addButton);
            this.actionPanel.Location = new System.Drawing.Point(9, 169);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(366, 66);
            this.actionPanel.TabIndex = 10;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(226, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(145, 0);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Actualizar";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Location = new System.Drawing.Point(64, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Agregar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.castDataGridView);
            this.dataPanel.Location = new System.Drawing.Point(388, 84);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(372, 155);
            this.dataPanel.TabIndex = 9;
            // 
            // castDataGridView
            // 
            this.castDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.castDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.castDataGridView.ColumnHeadersVisible = false;
            this.castDataGridView.Location = new System.Drawing.Point(5, 3);
            this.castDataGridView.Name = "castDataGridView";
            this.castDataGridView.Size = new System.Drawing.Size(360, 149);
            this.castDataGridView.TabIndex = 0;
            this.castDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.castDataGridView_CellContentClick);
            this.castDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.castDataGridView_CellMouseClick);
            // 
            // insertPanel
            // 
            this.insertPanel.Controls.Add(this.languageLabel);
            this.insertPanel.Controls.Add(this.lastnameTextBox);
            this.insertPanel.Controls.Add(this.lastnameLabel);
            this.insertPanel.Controls.Add(this.nameTextBox);
            this.insertPanel.Controls.Add(this.nameLabel);
            this.insertPanel.Location = new System.Drawing.Point(9, 25);
            this.insertPanel.Name = "insertPanel";
            this.insertPanel.Size = new System.Drawing.Size(366, 138);
            this.insertPanel.TabIndex = 8;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(118, 14);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(93, 13);
            this.languageLabel.TabIndex = 18;
            this.languageLabel.Text = "Gestión de elenco";
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(99, 90);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(236, 20);
            this.lastnameTextBox.TabIndex = 7;
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(43, 93);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lastnameLabel.Size = new System.Drawing.Size(50, 13);
            this.lastnameLabel.TabIndex = 6;
            this.lastnameLabel.Text = "Apellido: ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(99, 55);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(236, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(43, 58);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Nombre: ";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(9, -1);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(35, 20);
            this.idTextBox.TabIndex = 19;
            this.idTextBox.Visible = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Location = new System.Drawing.Point(145, 29);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Regresar";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // castForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 256);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.insertPanel);
            this.Name = "castForm";
            this.Text = "Gestión de elenco";
            this.Load += new System.EventHandler(this.castForm_Load);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.castDataGridView)).EndInit();
            this.insertPanel.ResumeLayout(false);
            this.insertPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.DataGridView castDataGridView;
        private System.Windows.Forms.Panel insertPanel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button backButton;
    }
}