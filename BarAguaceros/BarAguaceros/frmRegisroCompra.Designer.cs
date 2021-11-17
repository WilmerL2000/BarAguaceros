
namespace BarAguaceros
{
    partial class frmRegisroCompra
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fdfs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 17);
            this.lblNombre.TabIndex = 85;
            this.lblNombre.Text = "Producto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.fdfs});
            this.dataGridView1.Location = new System.Drawing.Point(16, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(748, 358);
            this.dataGridView1.TabIndex = 78;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 28;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(32, 565);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(158, 39);
            this.iconButton1.TabIndex = 75;
            this.iconButton1.Text = "Registrar compra";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 22);
            this.txtNombre.TabIndex = 74;
            // 
            // iconButton6
            // 
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton6.IconColor = System.Drawing.Color.Black;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 20;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton6.Location = new System.Drawing.Point(479, 55);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(163, 29);
            this.iconButton6.TabIndex = 86;
            this.iconButton6.Text = "Agregar Producto";
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 88;
            this.label1.Text = "Unidades";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 90;
            this.label2.Text = "Proveedor";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 502);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 92;
            this.label3.Text = "Pedido de compra";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Código";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Unidades";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // fdfs
            // 
            this.fdfs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fdfs.HeaderText = "Monto";
            this.fdfs.MinimumWidth = 6;
            this.fdfs.Name = "fdfs";
            // 
            // frmRegisroCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 632);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.iconButton6);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmRegisroCompra";
            this.Text = "RegisroCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txtNombre;
        private FontAwesome.Sharp.IconButton iconButton6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fdfs;
    }
}