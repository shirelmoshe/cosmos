namespace Cosmos.UI
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
            this.btnPriceCheaper = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnProductName = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxSupplier = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPriceCheaper
            // 
            this.btnPriceCheaper.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPriceCheaper.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPriceCheaper.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPriceCheaper.Location = new System.Drawing.Point(109, 162);
            this.btnPriceCheaper.Name = "btnPriceCheaper";
            this.btnPriceCheaper.Size = new System.Drawing.Size(338, 37);
            this.btnPriceCheaper.TabIndex = 1;
            this.btnPriceCheaper.Text = "Select Products that cheaper than -> ";
            this.btnPriceCheaper.UseVisualStyleBackColor = false;
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSupplier.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSupplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSupplier.Location = new System.Drawing.Point(109, 245);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(338, 37);
            this.btnSupplier.TabIndex = 2;
            this.btnSupplier.Text = "Select Products for SupplierID Number ->";
            this.btnSupplier.UseVisualStyleBackColor = false;
            // 
            // btnProductName
            // 
            this.btnProductName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnProductName.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProductName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductName.Location = new System.Drawing.Point(94, 328);
            this.btnProductName.Name = "btnProductName";
            this.btnProductName.Size = new System.Drawing.Size(338, 37);
            this.btnProductName.TabIndex = 3;
            this.btnProductName.Text = "Select Products that ProductName starts with ->";
            this.btnProductName.UseVisualStyleBackColor = false;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPrice.Location = new System.Drawing.Point(228, 205);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(99, 34);
            this.textBoxPrice.TabIndex = 4;
            // 
            // textBoxSupplier
            // 
            this.textBoxSupplier.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSupplier.Location = new System.Drawing.Point(239, 288);
            this.textBoxSupplier.Name = "textBoxSupplier";
            this.textBoxSupplier.Size = new System.Drawing.Size(99, 34);
            this.textBoxSupplier.TabIndex = 5;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxProductName.Location = new System.Drawing.Point(228, 378);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(99, 34);
            this.textBoxProductName.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 26;
            this.listBox1.Location = new System.Drawing.Point(494, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(458, 342);
            this.listBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(228, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Northwind Products in Cosmos DB";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnImport.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImport.Location = new System.Drawing.Point(153, 114);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(294, 40);
            this.btnImport.TabIndex = 9;
            this.btnImport.Text = "Import Products from Northwind";
            this.btnImport.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.textBoxSupplier);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.btnProductName);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnPriceCheaper);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnPriceCheaper;
        private Button btnSupplier;
        private Button btnProductName;
        private TextBox textBoxPrice;
        private TextBox textBoxSupplier;
        private TextBox textBoxProductName;
        private ListBox listBox1;
        private Label label1;
        private Button btnImport;
    }
}