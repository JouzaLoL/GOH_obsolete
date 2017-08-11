using System.Drawing;
using System.Windows.Forms;

namespace GOH.Zastupovani
{
    partial class Main
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
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Hodina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Předmět = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Učebna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chybějící = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zastupující = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poznámka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debug = new MaterialSkin.Controls.MaterialLabel();
            this.Date = new System.Windows.Forms.ComboBox();
            this.Datum = new MaterialSkin.Controls.MaterialLabel();
            this.Info = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Location = new System.Drawing.Point(61, 76);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClassComboBox.TabIndex = 1;
            this.ClassComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassComboBox_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 76);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(43, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Třída";
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AllowUserToOrderColumns = true;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hodina,
            this.Předmět,
            this.Učebna,
            this.Chybějící,
            this.Zastupující,
            this.Poznámka});
            this.DataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DataGrid.GridColor = System.Drawing.Color.White;
            this.DataGrid.Location = new System.Drawing.Point(12, 108);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.Size = new System.Drawing.Size(356, 192);
            this.DataGrid.TabIndex = 3;
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
            // 
            // Hodina
            // 
            this.Hodina.Name = "Hodina";
            this.Hodina.ReadOnly = true;
            // 
            // Předmět
            // 
            this.Předmět.Name = "Předmět";
            this.Předmět.ReadOnly = true;
            // 
            // Učebna
            // 
            this.Učebna.Name = "Učebna";
            this.Učebna.ReadOnly = true;
            // 
            // Chybějící
            // 
            this.Chybějící.Name = "Chybějící";
            this.Chybějící.ReadOnly = true;
            // 
            // Zastupující
            // 
            this.Zastupující.Name = "Zastupující";
            this.Zastupující.ReadOnly = true;
            // 
            // Poznámka
            // 
            this.Poznámka.Name = "Poznámka";
            this.Poznámka.ReadOnly = true;
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Depth = 0;
            this.debug.Font = new System.Drawing.Font("Roboto", 11F);
            this.debug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.debug.Location = new System.Drawing.Point(258, 34);
            this.debug.MouseState = MaterialSkin.MouseState.HOVER;
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(0, 19);
            this.debug.TabIndex = 5;
            // 
            // Date
            // 
            this.Date.FormattingEnabled = true;
            this.Date.Location = new System.Drawing.Point(247, 75);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(121, 21);
            this.Date.TabIndex = 6;
            this.Date.SelectedIndexChanged += new System.EventHandler(this.Date_SelectedIndexChanged);
            // 
            // Datum
            // 
            this.Datum.AutoSize = true;
            this.Datum.BackColor = System.Drawing.Color.White;
            this.Datum.Depth = 0;
            this.Datum.Font = new System.Drawing.Font("Roboto", 11F);
            this.Datum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Datum.Location = new System.Drawing.Point(188, 76);
            this.Datum.MouseState = MaterialSkin.MouseState.HOVER;
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(53, 19);
            this.Datum.TabIndex = 7;
            this.Datum.Text = "Datum";
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Info.Depth = 0;
            this.Info.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Info.FlatAppearance.BorderSize = 5;
            this.Info.Location = new System.Drawing.Point(276, 33);
            this.Info.MouseState = MaterialSkin.MouseState.HOVER;
            this.Info.Name = "Info";
            this.Info.Primary = true;
            this.Info.Size = new System.Drawing.Size(92, 23);
            this.Info.TabIndex = 8;
            this.Info.Text = "Informace";
            this.Info.UseVisualStyleBackColor = false;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 314);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ClassComboBox);
            this.Name = "Main";
            this.Text = "GOH Zastupování";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ClassComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView DataGrid;
        private DataGridViewTextBoxColumn Chybějící;
        private DataGridViewTextBoxColumn Hodina;
        private DataGridViewTextBoxColumn Zastupující;
        private DataGridViewTextBoxColumn Předmět;
        private DataGridViewTextBoxColumn Učebna;
        private DataGridViewTextBoxColumn Poznámka;
        private MaterialSkin.Controls.MaterialLabel debug;
        private ComboBox Date;
        private MaterialSkin.Controls.MaterialLabel Datum;
        private MaterialSkin.Controls.MaterialRaisedButton Info;
    }
}

