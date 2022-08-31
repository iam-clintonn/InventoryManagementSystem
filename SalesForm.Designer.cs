namespace InventoryManagementSystem
{
    partial class SalesForm
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
        private void InitializeComponent(DataGridViewTextBoxColumn v)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.ORDERDGV = new System.Windows.Forms.DataGridView();
            this.bunifuThinButton26 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ProductPrc = new System.Windows.Forms.TextBox();
            this.CategoryDesc = new Bunifu.UI.WinForms.BunifuLabel();
            this.ProductNm = new System.Windows.Forms.TextBox();
            this.ProdName = new Bunifu.UI.WinForms.BunifuLabel();
            this.BILLID = new System.Windows.Forms.TextBox();
            this.CategoryId = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button1 = new System.Windows.Forms.Button();
            this.ProductQt = new System.Windows.Forms.TextBox();
            this.DateLbl = new System.Windows.Forms.Label();
            this.AttendantLbl = new System.Windows.Forms.Label();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ORDERDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.BorderRadius = 1;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.AttendantLbl);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuFlatButton1);
            this.bunifuShadowPanel1.Controls.Add(this.DateLbl);
            this.bunifuShadowPanel1.Controls.Add(this.ProductQt);
            this.bunifuShadowPanel1.Controls.Add(this.button1);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuThinButton21);
            this.bunifuShadowPanel1.Controls.Add(this.comboBox2);
            this.bunifuShadowPanel1.Controls.Add(this.dataGridView2);
            this.bunifuShadowPanel1.Controls.Add(this.dataGridView1);
            this.bunifuShadowPanel1.Controls.Add(this.ORDERDGV);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuThinButton26);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuThinButton25);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuThinButton24);
            this.bunifuShadowPanel1.Controls.Add(this.ProductPrc);
            this.bunifuShadowPanel1.Controls.Add(this.CategoryDesc);
            this.bunifuShadowPanel1.Controls.Add(this.ProductNm);
            this.bunifuShadowPanel1.Controls.Add(this.ProdName);
            this.bunifuShadowPanel1.Controls.Add(this.BILLID);
            this.bunifuShadowPanel1.Controls.Add(this.CategoryId);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(103, 12);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 5;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(805, 509);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 5;
            // 
            // ORDERDGV
            // 
            this.ORDERDGV.BackgroundColor = System.Drawing.Color.White;
            this.ORDERDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ORDERDGV.Location = new System.Drawing.Point(410, 69);
            this.ORDERDGV.Name = "ORDERDGV";
            this.ORDERDGV.RowTemplate.Height = 25;
            this.ORDERDGV.Size = new System.Drawing.Size(374, 177);
            this.ORDERDGV.TabIndex = 14;
            this.ORDERDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ORDERDGV_CellContentClick_1);
            // 
            // bunifuThinButton26
            // 
            this.bunifuThinButton26.ActiveBorderThickness = 1;
            this.bunifuThinButton26.ActiveCornerRadius = 20;
            this.bunifuThinButton26.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton26.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton26.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton26.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton26.BackgroundImage")));
            this.bunifuThinButton26.ButtonText = "DELETE";
            this.bunifuThinButton26.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bunifuThinButton26.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton26.IdleBorderThickness = 1;
            this.bunifuThinButton26.IdleCornerRadius = 20;
            this.bunifuThinButton26.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton26.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton26.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton26.Location = new System.Drawing.Point(655, 463);
            this.bunifuThinButton26.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton26.Name = "bunifuThinButton26";
            this.bunifuThinButton26.Size = new System.Drawing.Size(84, 41);
            this.bunifuThinButton26.TabIndex = 13;
            this.bunifuThinButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton25
            // 
            this.bunifuThinButton25.ActiveBorderThickness = 1;
            this.bunifuThinButton25.ActiveCornerRadius = 20;
            this.bunifuThinButton25.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton25.BackgroundImage")));
            this.bunifuThinButton25.ButtonText = "PRINT";
            this.bunifuThinButton25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 20;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.Location = new System.Drawing.Point(561, 463);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(84, 41);
            this.bunifuThinButton25.TabIndex = 12;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "ADD";
            this.bunifuThinButton24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.Location = new System.Drawing.Point(474, 463);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(77, 41);
            this.bunifuThinButton24.TabIndex = 11;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.ProductPrc.Location = new System.Drawing.Point(119, 132);
            this.ProductPrc.Multiline = true;
            this.ProductPrc.Name = "textBox3";
            this.ProductPrc.Size = new System.Drawing.Size(199, 23);
            this.ProductPrc.TabIndex = 6;
            // 
            // CategoryDesc
            // 
            this.CategoryDesc.AllowParentOverrides = false;
            this.CategoryDesc.AutoEllipsis = false;
            this.CategoryDesc.CursorType = System.Windows.Forms.Cursors.Default;
            this.CategoryDesc.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CategoryDesc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CategoryDesc.Location = new System.Drawing.Point(21, 132);
            this.CategoryDesc.Name = "CategoryDesc";
            this.CategoryDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CategoryDesc.Size = new System.Drawing.Size(41, 19);
            this.CategoryDesc.TabIndex = 5;
            this.CategoryDesc.Text = "Price";
            this.CategoryDesc.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.CategoryDesc.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // textBox2
            // 
            this.ProductNm.Location = new System.Drawing.Point(119, 103);
            this.ProductNm.Multiline = true;
            this.ProductNm.Name = "textBox2";
            this.ProductNm.Size = new System.Drawing.Size(199, 23);
            this.ProductNm.TabIndex = 4;
            // 
            // CategoryName
            // 
            this.ProdName.AllowParentOverrides = false;
            this.ProdName.AutoEllipsis = false;
            this.ProdName.CursorType = System.Windows.Forms.Cursors.Default;
            this.ProdName.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProdName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProdName.Location = new System.Drawing.Point(21, 107);
            this.ProdName.Name = "CategoryName";
            this.ProdName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProdName.Size = new System.Drawing.Size(83, 19);
            this.ProdName.TabIndex = 3;
            this.ProdName.Text = "ProdName";
            this.ProdName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.ProdName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // textBox1
            // 
            this.BILLID.Location = new System.Drawing.Point(119, 69);
            this.BILLID.Multiline = true;
            this.BILLID.Name = "textBox1";
            this.BILLID.Size = new System.Drawing.Size(199, 23);
            this.BILLID.TabIndex = 2;
            this.BILLID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CategoryId
            // 
            this.CategoryId.AllowParentOverrides = false;
            this.CategoryId.AutoEllipsis = false;
            this.CategoryId.CursorType = System.Windows.Forms.Cursors.Default;
            this.CategoryId.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CategoryId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CategoryId.Location = new System.Drawing.Point(21, 73);
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CategoryId.Size = new System.Drawing.Size(61, 19);
            this.CategoryId.TabIndex = 1;
            this.CategoryId.Text = "BILLID";
            this.CategoryId.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.CategoryId.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuLabel1.Location = new System.Drawing.Point(355, 10);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(68, 23);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "SALES";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "X";
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(779, 0);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(37, 33);
            this.bunifuFlatButton1.TabIndex = 18;
            this.bunifuFlatButton1.Text = "X";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(410, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(374, 177);
            this.dataGridView1.TabIndex = 15;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(22, 249);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(296, 251);
            this.dataGridView2.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(22, 219);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(199, 24);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.Text = "Select Category";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "ADD PRODUCT";
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(138, 182);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(168, 29);
            this.bunifuThinButton21.TabIndex = 18;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(243, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "REFRESH";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.ProductQt.Location = new System.Drawing.Point(119, 161);
            this.ProductQt.Multiline = true;
            this.ProductQt.Name = "textBox4";
            this.ProductQt.Size = new System.Drawing.Size(199, 23);
            this.ProductQt.TabIndex = 21;
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateLbl.ForeColor = System.Drawing.Color.White;
            this.DateLbl.Location = new System.Drawing.Point(655, 17);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(35, 16);
            this.DateLbl.TabIndex = 22;
            this.DateLbl.Text = "Date";
            this.DateLbl.Click += new System.EventHandler(this.DateLbl_Click);
            // 
            // AttendantLbl
            // 
            this.AttendantLbl.AutoSize = true;
            this.AttendantLbl.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AttendantLbl.ForeColor = System.Drawing.Color.White;
            this.AttendantLbl.Location = new System.Drawing.Point(27, 17);
            this.AttendantLbl.Name = "AttendantLbl";
            this.AttendantLbl.Size = new System.Drawing.Size(67, 16);
            this.AttendantLbl.TabIndex = 23;
            this.AttendantLbl.Text = "Attendant";
            // 
            // SalesForm
            // 
            this.ClientSize = new System.Drawing.Size(920, 524);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesForm";
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ORDERDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Button button1;
        private ComboBox comboBox2;
        private TextBox ProductQty;
        private DataGridViewTextBoxColumn ProdId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn ProductQuantity;
        private DataGridViewTextBoxColumn Total;
        private TextBox BillId;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Label DateLbl;
        private DataGridView BillsDGV;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private DataGridView ProductDGV;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton26;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Label AttendantNameLbl;
        private Bunifu.UI.WinForms.BunifuLabel AmountLbl;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private DataGridView ORDERINGDGV;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridView ORDERDGV;
        private TextBox ProductPrc;
        private Bunifu.UI.WinForms.BunifuLabel CategoryDesc;
        private TextBox ProductNm;
        private Bunifu.UI.WinForms.BunifuLabel ProdName;
        private TextBox BILLID;
        private Bunifu.UI.WinForms.BunifuLabel CategoryId;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Label AttendantLbl;
        private TextBox ProductQt;
    }
}