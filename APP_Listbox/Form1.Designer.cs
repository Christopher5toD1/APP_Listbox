namespace APP_Listbox
{
    partial class TstSeries
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
            listSeries = new ListBox();
            TxSeries = new TextBox();
            Agregar = new Button();
            Salir = new Button();
            label1 = new Label();
            TxLimpiar = new Button();
            Eliminar = new Button();
            TxTindex = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listSeries
            // 
            listSeries.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listSeries.FormattingEnabled = true;
            listSeries.ItemHeight = 21;
            listSeries.Location = new Point(219, 81);
            listSeries.Name = "listSeries";
            listSeries.Size = new Size(120, 172);
            listSeries.TabIndex = 0;
            listSeries.SelectedIndexChanged += listSeries_SelectedIndexChanged;
            // 
            // TxSeries
            // 
            TxSeries.Location = new Point(376, 94);
            TxSeries.Name = "TxSeries";
            TxSeries.Size = new Size(219, 23);
            TxSeries.TabIndex = 1;
            // 
            // Agregar
            // 
            Agregar.BackColor = SystemColors.ButtonHighlight;
            Agregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Agregar.Location = new Point(386, 146);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(82, 35);
            Agregar.TabIndex = 2;
            Agregar.Text = "Agregar";
            Agregar.UseVisualStyleBackColor = false;
            Agregar.Click += Agregar_Click;
            // 
            // Salir
            // 
            Salir.BackColor = SystemColors.ButtonHighlight;
            Salir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Salir.Location = new Point(386, 202);
            Salir.Name = "Salir";
            Salir.Size = new Size(82, 35);
            Salir.TabIndex = 3;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = false;
            Salir.Click += Salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 81);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "Series";
            // 
            // TxLimpiar
            // 
            TxLimpiar.BackColor = SystemColors.ButtonHighlight;
            TxLimpiar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxLimpiar.Location = new Point(488, 147);
            TxLimpiar.Name = "TxLimpiar";
            TxLimpiar.Size = new Size(81, 35);
            TxLimpiar.TabIndex = 5;
            TxLimpiar.Text = "Limpiar";
            TxLimpiar.UseVisualStyleBackColor = false;
            TxLimpiar.Click += TxLimpiar_Click;
            // 
            // Eliminar
            // 
            Eliminar.BackColor = SystemColors.ButtonHighlight;
            Eliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Eliminar.Location = new Point(488, 203);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(81, 35);
            Eliminar.TabIndex = 6;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = false;
            Eliminar.Click += Eliminar_Click;
            // 
            // TxTindex
            // 
            TxTindex.AutoSize = true;
            TxTindex.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxTindex.Location = new Point(124, 154);
            TxTindex.Name = "TxTindex";
            TxTindex.Size = new Size(13, 20);
            TxTindex.TabIndex = 7;
            TxTindex.Text = ".";
            TxTindex.Click += TxTindex_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(421, 61);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 8;
            label2.Text = "Ingresa Serie";
            // 
            // TstSeries
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(624, 324);
            Controls.Add(label2);
            Controls.Add(TxTindex);
            Controls.Add(Eliminar);
            Controls.Add(TxLimpiar);
            Controls.Add(label1);
            Controls.Add(Salir);
            Controls.Add(Agregar);
            Controls.Add(TxSeries);
            Controls.Add(listSeries);
            Name = "TstSeries";
            Text = "Form1";
            Load += TstSeries_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listSeries;
        private TextBox TxSeries;
        private Button Agregar;
        private Button Salir;
        private Label label1;
        private Button TxLimpiar;
        private Button Eliminar;
        private Label TxTindex;
        private Label label2;
    }
}
