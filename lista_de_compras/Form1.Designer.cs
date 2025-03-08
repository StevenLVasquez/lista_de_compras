namespace lista_de_compras
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
            dgvListas = new DataGridView();
            dgvProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvListas
            // 
            dgvListas.AllowUserToAddRows = false;
            dgvListas.AllowUserToDeleteRows = false;
            dgvListas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListas.Location = new Point(12, 268);
            dgvListas.Name = "dgvListas";
            dgvListas.Size = new Size(582, 150);
            dgvListas.TabIndex = 0;
            dgvListas.CellContentClick += dgvListas_CellContentClick;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 103);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(752, 150);
            dgvProductos.TabIndex = 1;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProductos);
            Controls.Add(dgvListas);
            Name = "Form1";
            Text = "SpaceX";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListas;
        private DataGridView dgvProductos;
    }
}
