namespace DESAFIO02_dsktp
{
    partial class Form1
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
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_mostrarFavoritos = new System.Windows.Forms.Button();
            this.btn_favoritar = new System.Windows.Forms.Button();
            this.btn_Filtrar = new System.Windows.Forms.Button();
            this.txt_Min = new System.Windows.Forms.TextBox();
            this.txt_Max = new System.Windows.Forms.TextBox();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.lb_max = new System.Windows.Forms.Label();
            this.lb_min = new System.Windows.Forms.Label();
            this.lb_categoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.Location = new System.Drawing.Point(73, 188);
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.Size = new System.Drawing.Size(616, 215);
            this.dgv_produtos.TabIndex = 0;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(494, 55);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_mostrarFavoritos
            // 
            this.btn_mostrarFavoritos.Location = new System.Drawing.Point(73, 129);
            this.btn_mostrarFavoritos.Name = "btn_mostrarFavoritos";
            this.btn_mostrarFavoritos.Size = new System.Drawing.Size(75, 48);
            this.btn_mostrarFavoritos.TabIndex = 2;
            this.btn_mostrarFavoritos.Text = "Mostrar Itens Favoritos";
            this.btn_mostrarFavoritos.UseVisualStyleBackColor = true;
            this.btn_mostrarFavoritos.Click += new System.EventHandler(this.btn_mostrarFavoritos_Click);
            // 
            // btn_favoritar
            // 
            this.btn_favoritar.Location = new System.Drawing.Point(73, 100);
            this.btn_favoritar.Name = "btn_favoritar";
            this.btn_favoritar.Size = new System.Drawing.Size(75, 23);
            this.btn_favoritar.TabIndex = 3;
            this.btn_favoritar.Text = "Favoritos";
            this.btn_favoritar.UseVisualStyleBackColor = true;
            this.btn_favoritar.Click += new System.EventHandler(this.btn_favoritar_Click);
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.Location = new System.Drawing.Point(575, 55);
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Filtrar.TabIndex = 4;
            this.btn_Filtrar.Text = "Filtrar";
            this.btn_Filtrar.UseVisualStyleBackColor = true;
            this.btn_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            // 
            // txt_Min
            // 
            this.txt_Min.Location = new System.Drawing.Point(73, 58);
            this.txt_Min.Name = "txt_Min";
            this.txt_Min.Size = new System.Drawing.Size(100, 20);
            this.txt_Min.TabIndex = 6;
            // 
            // txt_Max
            // 
            this.txt_Max.Location = new System.Drawing.Point(205, 58);
            this.txt_Max.Name = "txt_Max";
            this.txt_Max.Size = new System.Drawing.Size(100, 20);
            this.txt_Max.TabIndex = 7;
            // 
            // cb_categoria
            // 
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(342, 57);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(121, 21);
            this.cb_categoria.TabIndex = 8;
            // 
            // lb_max
            // 
            this.lb_max.AutoSize = true;
            this.lb_max.Location = new System.Drawing.Point(202, 29);
            this.lb_max.Name = "lb_max";
            this.lb_max.Size = new System.Drawing.Size(46, 13);
            this.lb_max.TabIndex = 9;
            this.lb_max.Text = "Máximo:";
            // 
            // lb_min
            // 
            this.lb_min.AutoSize = true;
            this.lb_min.Location = new System.Drawing.Point(70, 29);
            this.lb_min.Name = "lb_min";
            this.lb_min.Size = new System.Drawing.Size(45, 13);
            this.lb_min.TabIndex = 10;
            this.lb_min.Text = "Mínimo:";
            // 
            // lb_categoria
            // 
            this.lb_categoria.AutoSize = true;
            this.lb_categoria.Location = new System.Drawing.Point(339, 29);
            this.lb_categoria.Name = "lb_categoria";
            this.lb_categoria.Size = new System.Drawing.Size(55, 13);
            this.lb_categoria.TabIndex = 11;
            this.lb_categoria.Text = "Categoria:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_categoria);
            this.Controls.Add(this.lb_min);
            this.Controls.Add(this.lb_max);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.txt_Max);
            this.Controls.Add(this.txt_Min);
            this.Controls.Add(this.btn_Filtrar);
            this.Controls.Add(this.btn_favoritar);
            this.Controls.Add(this.btn_mostrarFavoritos);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.dgv_produtos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_mostrarFavoritos;
        private System.Windows.Forms.Button btn_favoritar;
        private System.Windows.Forms.Button btn_Filtrar;
        private System.Windows.Forms.TextBox txt_Min;
        private System.Windows.Forms.TextBox txt_Max;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.Label lb_max;
        private System.Windows.Forms.Label lb_min;
        private System.Windows.Forms.Label lb_categoria;
    }
}

