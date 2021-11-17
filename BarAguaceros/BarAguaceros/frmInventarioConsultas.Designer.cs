
namespace BarAguaceros
{
    partial class frmInventarioConsultas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButton9
            // 
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton9.IconColor = System.Drawing.Color.Black;
            this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton9.IconSize = 25;
            this.iconButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton9.Location = new System.Drawing.Point(511, 95);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Size = new System.Drawing.Size(91, 31);
            this.iconButton9.TabIndex = 99;
            this.iconButton9.Text = "Buscar";
            this.iconButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton9.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(476, 22);
            this.textBox3.TabIndex = 98;
            // 
            // iconButton4
            // 
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 28;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton4.Location = new System.Drawing.Point(12, 22);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(148, 39);
            this.iconButton4.TabIndex = 100;
            this.iconButton4.Text = "Listado general";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 28;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton1.Location = new System.Drawing.Point(193, 22);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(148, 39);
            this.iconButton1.TabIndex = 101;
            this.iconButton1.Text = "Listado por mes";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 28;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton2.Location = new System.Drawing.Point(379, 22);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(223, 39);
            this.iconButton2.TabIndex = 102;
            this.iconButton2.Text = "Listado por mes y categoría";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Unidades});
            this.dataGridView1.Location = new System.Drawing.Point(12, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1036, 324);
            this.dataGridView1.TabIndex = 111;
            // 
            // Código
            // 
            this.Código.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Código.HeaderText = "Código";
            this.Código.MinimumWidth = 6;
            this.Código.Name = "Código";
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Unidades
            // 
            this.Unidades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Unidades.HeaderText = "Unidades";
            this.Unidades.MinimumWidth = 6;
            this.Unidades.Name = "Unidades";
            // 
            // frmInventarioConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 535);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.iconButton9);
            this.Controls.Add(this.textBox3);
            this.Name = "frmInventarioConsultas";
            this.Text = "frmInventarioConsultas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton9;
        private System.Windows.Forms.TextBox textBox3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
    }
}