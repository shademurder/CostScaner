namespace CostScaner
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Shop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cooler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motherboard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoyalWhite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoyalGold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Shop,
            this.CP,
            this.Cooler,
            this.Motherboard,
            this.ALU,
            this.RoyalWhite,
            this.RoyalGold});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1025, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // Shop
            // 
            this.Shop.HeaderText = "Магазин";
            this.Shop.Name = "Shop";
            this.Shop.ReadOnly = true;
            this.Shop.Width = 140;
            // 
            // CP
            // 
            this.CP.HeaderText = "ЦП AMD Ryzen 7 3800X AM4 OEM";
            this.CP.Name = "CP";
            this.CP.ReadOnly = true;
            this.CP.Width = 140;
            // 
            // Cooler
            // 
            this.Cooler.HeaderText = "Кулер DEEPCOOL CASTLE 240 RGB V2";
            this.Cooler.Name = "Cooler";
            this.Cooler.ReadOnly = true;
            this.Cooler.Width = 140;
            // 
            // Motherboard
            // 
            this.Motherboard.HeaderText = "МП ASUS ROG Strix X570-F Gaming";
            this.Motherboard.Name = "Motherboard";
            this.Motherboard.ReadOnly = true;
            this.Motherboard.Width = 140;
            // 
            // ALU
            // 
            this.ALU.HeaderText = "ОЗУ F4-3600C16D-32GTZNC NEO";
            this.ALU.Name = "ALU";
            this.ALU.ReadOnly = true;
            this.ALU.Width = 140;
            // 
            // RoyalWhite
            // 
            this.RoyalWhite.HeaderText = "G.SKILL TRIDENT Z ROYAL White";
            this.RoyalWhite.Name = "RoyalWhite";
            this.RoyalWhite.ReadOnly = true;
            this.RoyalWhite.Width = 140;
            // 
            // RoyalGold
            // 
            this.RoyalGold.HeaderText = "G.SKILL TRIDENT Z ROYAL Gold";
            this.RoyalGold.Name = "RoyalGold";
            this.RoyalGold.ReadOnly = true;
            this.RoyalGold.Width = 140;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(412, 318);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(250, 250);
            this.webBrowser.TabIndex = 1;
            this.webBrowser.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 323);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shop;
        private System.Windows.Forms.DataGridViewTextBoxColumn CP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cooler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motherboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALU;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoyalWhite;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoyalGold;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

