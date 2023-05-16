namespace JogoTermo.WinFormsApp.Controles
{
    partial class LinhaTermoUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridColunas = new TableLayoutPanel();
            lbl5 = new Label();
            lbl4 = new Label();
            lbl3 = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            gridColunas.SuspendLayout();
            SuspendLayout();
            // 
            // gridColunas
            // 
            gridColunas.ColumnCount = 5;
            gridColunas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            gridColunas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            gridColunas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            gridColunas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            gridColunas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            gridColunas.Controls.Add(lbl5, 4, 0);
            gridColunas.Controls.Add(lbl4, 3, 0);
            gridColunas.Controls.Add(lbl3, 2, 0);
            gridColunas.Controls.Add(lbl2, 1, 0);
            gridColunas.Controls.Add(lbl1, 0, 0);
            gridColunas.Dock = DockStyle.Fill;
            gridColunas.Location = new Point(0, 0);
            gridColunas.Name = "gridColunas";
            gridColunas.RowCount = 1;
            gridColunas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            gridColunas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            gridColunas.Size = new Size(361, 68);
            gridColunas.TabIndex = 0;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.BackColor = SystemColors.ButtonShadow;
            lbl5.Dock = DockStyle.Fill;
            lbl5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl5.ForeColor = SystemColors.Control;
            lbl5.Location = new Point(291, 3);
            lbl5.Margin = new Padding(3);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(67, 62);
            lbl5.TabIndex = 4;
            lbl5.TextAlign = ContentAlignment.MiddleCenter;
            lbl5.Click += lbl5_Click;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.BackColor = SystemColors.ButtonShadow;
            lbl4.Dock = DockStyle.Fill;
            lbl4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl4.ForeColor = SystemColors.Control;
            lbl4.Location = new Point(219, 3);
            lbl4.Margin = new Padding(3);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(66, 62);
            lbl4.TabIndex = 3;
            lbl4.TextAlign = ContentAlignment.MiddleCenter;
            lbl4.Click += lbl4_Click;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = SystemColors.ButtonShadow;
            lbl3.Dock = DockStyle.Fill;
            lbl3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl3.ForeColor = SystemColors.Control;
            lbl3.Location = new Point(147, 3);
            lbl3.Margin = new Padding(3);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(66, 62);
            lbl3.TabIndex = 2;
            lbl3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = SystemColors.ButtonShadow;
            lbl2.Dock = DockStyle.Fill;
            lbl2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.ForeColor = SystemColors.Control;
            lbl2.Location = new Point(75, 3);
            lbl2.Margin = new Padding(3);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(66, 62);
            lbl2.TabIndex = 1;
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            lbl2.Click += lbl2_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = SystemColors.ButtonShadow;
            lbl1.Dock = DockStyle.Fill;
            lbl1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.ForeColor = SystemColors.Control;
            lbl1.Location = new Point(3, 3);
            lbl1.Margin = new Padding(3);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(66, 62);
            lbl1.TabIndex = 0;
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            lbl1.Click += lbl1_Click;
            // 
            // LinhaTermoUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridColunas);
            Name = "LinhaTermoUserControl";
            Size = new Size(361, 68);
            gridColunas.ResumeLayout(false);
            gridColunas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel gridColunas;
        private Label lbl1;
        private Label lbl5;
        private Label lbl4;
        private Label lbl3;
        private Label lbl2;
    }
}
