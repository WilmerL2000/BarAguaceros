
namespace BarAguaceros
{
    partial class frmProveedor
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.iconButton10 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 439);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 73;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // iconButton9
            // 
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton9.IconColor = System.Drawing.Color.Black;
            this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton9.IconSize = 25;
            this.iconButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton9.Location = new System.Drawing.Point(441, 65);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Size = new System.Drawing.Size(91, 31);
            this.iconButton9.TabIndex = 70;
            this.iconButton9.Text = "Buscar";
            this.iconButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton9.UseVisualStyleBackColor = true;
            this.iconButton9.Click += new System.EventHandler(this.iconButton9_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(25, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(410, 22);
            this.textBox3.TabIndex = 69;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // iconButton8
            // 
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.UserSlash;
            this.iconButton8.IconColor = System.Drawing.Color.Black;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 28;
            this.iconButton8.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton8.Location = new System.Drawing.Point(684, 12);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(106, 39);
            this.iconButton8.TabIndex = 68;
            this.iconButton8.Text = "Inactivos";
            this.iconButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton8.UseVisualStyleBackColor = true;
            // 
            // iconButton7
            // 
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconButton7.IconColor = System.Drawing.Color.Black;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 28;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton7.Location = new System.Drawing.Point(557, 12);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(93, 39);
            this.iconButton7.TabIndex = 67;
            this.iconButton7.Text = "Activos";
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton7.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 28;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton4.Location = new System.Drawing.Point(25, 12);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(148, 39);
            this.iconButton4.TabIndex = 66;
            this.iconButton4.Text = "Listado general";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(19, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(771, 301);
            this.dataGridView1.TabIndex = 64;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(111, 435);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 52;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // iconButton10
            // 
            this.iconButton10.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButton10.IconColor = System.Drawing.Color.Black;
            this.iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton10.IconSize = 35;
            this.iconButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton10.Location = new System.Drawing.Point(651, 489);
            this.iconButton10.Name = "iconButton10";
            this.iconButton10.Size = new System.Drawing.Size(120, 39);
            this.iconButton10.TabIndex = 77;
            this.iconButton10.Text = "Activar";
            this.iconButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton10.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 35;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(441, 489);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(120, 39);
            this.iconButton3.TabIndex = 76;
            this.iconButton3.Text = "Eliminar";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(235, 489);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(120, 39);
            this.iconButton2.TabIndex = 75;
            this.iconButton2.Text = "Modificar";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(29, 489);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(120, 39);
            this.iconButton1.TabIndex = 74;
            this.iconButton1.Text = "Agregar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 557);
            this.Controls.Add(this.iconButton10);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.iconButton9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.iconButton8);
            this.Controls.Add(this.iconButton7);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmProveedor";
            this.Text = "frmProveedor";
            this.Load += new System.EventHandler(this.frmProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private FontAwesome.Sharp.IconButton iconButton9;
        private System.Windows.Forms.TextBox textBox3;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombre;
        private FontAwesome.Sharp.IconButton iconButton10;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}