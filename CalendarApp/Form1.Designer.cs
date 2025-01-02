namespace CalendarApp
{
    partial class ScanGraphyMainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanGraphyMainForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TakvimdeGosterButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.EtkinlikEkleButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.EtkinlikSilButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.EtkinlikDuzenleButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TakvimdeGosterButton
            // 
            this.TakvimdeGosterButton.AllowAnimations = true;
            this.TakvimdeGosterButton.AllowMouseEffects = true;
            this.TakvimdeGosterButton.AllowToggling = false;
            this.TakvimdeGosterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TakvimdeGosterButton.AnimationSpeed = 200;
            this.TakvimdeGosterButton.AutoGenerateColors = false;
            this.TakvimdeGosterButton.AutoRoundBorders = false;
            this.TakvimdeGosterButton.AutoSizeLeftIcon = true;
            this.TakvimdeGosterButton.AutoSizeRightIcon = true;
            this.TakvimdeGosterButton.BackColor = System.Drawing.Color.Transparent;
            this.TakvimdeGosterButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.TakvimdeGosterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TakvimdeGosterButton.BackgroundImage")));
            this.TakvimdeGosterButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.TakvimdeGosterButton.ButtonText = "Takvimde Göster";
            this.TakvimdeGosterButton.ButtonTextMarginLeft = 0;
            this.TakvimdeGosterButton.ColorContrastOnClick = 45;
            this.TakvimdeGosterButton.ColorContrastOnHover = 45;
            this.TakvimdeGosterButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = false;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.TakvimdeGosterButton.CustomizableEdges = borderEdges1;
            this.TakvimdeGosterButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.TakvimdeGosterButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.TakvimdeGosterButton.DisabledFillColor = System.Drawing.Color.Empty;
            this.TakvimdeGosterButton.DisabledForecolor = System.Drawing.Color.Empty;
            this.TakvimdeGosterButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.TakvimdeGosterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TakvimdeGosterButton.ForeColor = System.Drawing.Color.White;
            this.TakvimdeGosterButton.IconLeft = null;
            this.TakvimdeGosterButton.IconLeftAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TakvimdeGosterButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.TakvimdeGosterButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.TakvimdeGosterButton.IconMarginLeft = 11;
            this.TakvimdeGosterButton.IconPadding = 10;
            this.TakvimdeGosterButton.IconRight = null;
            this.TakvimdeGosterButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TakvimdeGosterButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.TakvimdeGosterButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.TakvimdeGosterButton.IconSize = 25;
            this.TakvimdeGosterButton.IdleBorderColor = System.Drawing.Color.Empty;
            this.TakvimdeGosterButton.IdleBorderRadius = 0;
            this.TakvimdeGosterButton.IdleBorderThickness = 0;
            this.TakvimdeGosterButton.IdleFillColor = System.Drawing.Color.Empty;
            this.TakvimdeGosterButton.IdleIconLeftImage = null;
            this.TakvimdeGosterButton.IdleIconRightImage = null;
            this.TakvimdeGosterButton.IndicateFocus = false;
            this.TakvimdeGosterButton.Location = new System.Drawing.Point(12, 429);
            this.TakvimdeGosterButton.Name = "TakvimdeGosterButton";
            this.TakvimdeGosterButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TakvimdeGosterButton.OnDisabledState.BorderRadius = 52;
            this.TakvimdeGosterButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.TakvimdeGosterButton.OnDisabledState.BorderThickness = 1;
            this.TakvimdeGosterButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TakvimdeGosterButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TakvimdeGosterButton.OnDisabledState.IconLeftImage = null;
            this.TakvimdeGosterButton.OnDisabledState.IconRightImage = null;
            this.TakvimdeGosterButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.TakvimdeGosterButton.onHoverState.BorderRadius = 52;
            this.TakvimdeGosterButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.TakvimdeGosterButton.onHoverState.BorderThickness = 1;
            this.TakvimdeGosterButton.onHoverState.FillColor = System.Drawing.Color.White;
            this.TakvimdeGosterButton.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.TakvimdeGosterButton.onHoverState.IconLeftImage = null;
            this.TakvimdeGosterButton.onHoverState.IconRightImage = null;
            this.TakvimdeGosterButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.TakvimdeGosterButton.OnIdleState.BorderRadius = 52;
            this.TakvimdeGosterButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.TakvimdeGosterButton.OnIdleState.BorderThickness = 1;
            this.TakvimdeGosterButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.TakvimdeGosterButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.TakvimdeGosterButton.OnIdleState.IconLeftImage = null;
            this.TakvimdeGosterButton.OnIdleState.IconRightImage = null;
            this.TakvimdeGosterButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.TakvimdeGosterButton.OnPressedState.BorderRadius = 52;
            this.TakvimdeGosterButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.TakvimdeGosterButton.OnPressedState.BorderThickness = 1;
            this.TakvimdeGosterButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.TakvimdeGosterButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.TakvimdeGosterButton.OnPressedState.IconLeftImage = null;
            this.TakvimdeGosterButton.OnPressedState.IconRightImage = null;
            this.TakvimdeGosterButton.Size = new System.Drawing.Size(140, 55);
            this.TakvimdeGosterButton.TabIndex = 7;
            this.TakvimdeGosterButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TakvimdeGosterButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.TakvimdeGosterButton.TextMarginLeft = 0;
            this.TakvimdeGosterButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.TakvimdeGosterButton.UseDefaultRadiusAndThickness = true;
            this.TakvimdeGosterButton.Click += new System.EventHandler(this.TakvimdeGosterButton_Click_1);
            // 
            // EtkinlikEkleButton
            // 
            this.EtkinlikEkleButton.AllowAnimations = true;
            this.EtkinlikEkleButton.AllowMouseEffects = true;
            this.EtkinlikEkleButton.AllowToggling = false;
            this.EtkinlikEkleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EtkinlikEkleButton.AnimationSpeed = 200;
            this.EtkinlikEkleButton.AutoGenerateColors = false;
            this.EtkinlikEkleButton.AutoRoundBorders = true;
            this.EtkinlikEkleButton.AutoSizeLeftIcon = true;
            this.EtkinlikEkleButton.AutoSizeRightIcon = true;
            this.EtkinlikEkleButton.BackColor = System.Drawing.Color.Transparent;
            this.EtkinlikEkleButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.EtkinlikEkleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EtkinlikEkleButton.BackgroundImage")));
            this.EtkinlikEkleButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EtkinlikEkleButton.ButtonText = "Etkinlik Ekle";
            this.EtkinlikEkleButton.ButtonTextMarginLeft = 0;
            this.EtkinlikEkleButton.ColorContrastOnClick = 45;
            this.EtkinlikEkleButton.ColorContrastOnHover = 45;
            this.EtkinlikEkleButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = false;
            borderEdges2.BottomRight = false;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.EtkinlikEkleButton.CustomizableEdges = borderEdges2;
            this.EtkinlikEkleButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EtkinlikEkleButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.EtkinlikEkleButton.DisabledFillColor = System.Drawing.Color.Empty;
            this.EtkinlikEkleButton.DisabledForecolor = System.Drawing.Color.Empty;
            this.EtkinlikEkleButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.EtkinlikEkleButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.EtkinlikEkleButton.ForeColor = System.Drawing.Color.White;
            this.EtkinlikEkleButton.IconLeft = null;
            this.EtkinlikEkleButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EtkinlikEkleButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.EtkinlikEkleButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.EtkinlikEkleButton.IconMarginLeft = 11;
            this.EtkinlikEkleButton.IconPadding = 10;
            this.EtkinlikEkleButton.IconRight = null;
            this.EtkinlikEkleButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EtkinlikEkleButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.EtkinlikEkleButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.EtkinlikEkleButton.IconSize = 25;
            this.EtkinlikEkleButton.IdleBorderColor = System.Drawing.Color.Empty;
            this.EtkinlikEkleButton.IdleBorderRadius = 0;
            this.EtkinlikEkleButton.IdleBorderThickness = 0;
            this.EtkinlikEkleButton.IdleFillColor = System.Drawing.Color.Empty;
            this.EtkinlikEkleButton.IdleIconLeftImage = null;
            this.EtkinlikEkleButton.IdleIconRightImage = null;
            this.EtkinlikEkleButton.IndicateFocus = false;
            this.EtkinlikEkleButton.Location = new System.Drawing.Point(476, 429);
            this.EtkinlikEkleButton.Name = "EtkinlikEkleButton";
            this.EtkinlikEkleButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EtkinlikEkleButton.OnDisabledState.BorderRadius = 55;
            this.EtkinlikEkleButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.EtkinlikEkleButton.OnDisabledState.BorderThickness = 1;
            this.EtkinlikEkleButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EtkinlikEkleButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EtkinlikEkleButton.OnDisabledState.IconLeftImage = null;
            this.EtkinlikEkleButton.OnDisabledState.IconRightImage = null;
            this.EtkinlikEkleButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.EtkinlikEkleButton.onHoverState.BorderRadius = 55;
            this.EtkinlikEkleButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EtkinlikEkleButton.onHoverState.BorderThickness = 1;
            this.EtkinlikEkleButton.onHoverState.FillColor = System.Drawing.Color.White;
            this.EtkinlikEkleButton.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.EtkinlikEkleButton.onHoverState.IconLeftImage = null;
            this.EtkinlikEkleButton.onHoverState.IconRightImage = null;
            this.EtkinlikEkleButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.EtkinlikEkleButton.OnIdleState.BorderRadius = 55;
            this.EtkinlikEkleButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EtkinlikEkleButton.OnIdleState.BorderThickness = 1;
            this.EtkinlikEkleButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.EtkinlikEkleButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.EtkinlikEkleButton.OnIdleState.IconLeftImage = null;
            this.EtkinlikEkleButton.OnIdleState.IconRightImage = null;
            this.EtkinlikEkleButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.EtkinlikEkleButton.OnPressedState.BorderRadius = 55;
            this.EtkinlikEkleButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EtkinlikEkleButton.OnPressedState.BorderThickness = 1;
            this.EtkinlikEkleButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.EtkinlikEkleButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.EtkinlikEkleButton.OnPressedState.IconLeftImage = null;
            this.EtkinlikEkleButton.OnPressedState.IconRightImage = null;
            this.EtkinlikEkleButton.Size = new System.Drawing.Size(140, 55);
            this.EtkinlikEkleButton.TabIndex = 8;
            this.EtkinlikEkleButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EtkinlikEkleButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.EtkinlikEkleButton.TextMarginLeft = 0;
            this.EtkinlikEkleButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.EtkinlikEkleButton.UseDefaultRadiusAndThickness = true;
            this.EtkinlikEkleButton.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // EtkinlikSilButton
            // 
            this.EtkinlikSilButton.AllowAnimations = true;
            this.EtkinlikSilButton.AllowMouseEffects = true;
            this.EtkinlikSilButton.AllowToggling = false;
            this.EtkinlikSilButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EtkinlikSilButton.AnimationSpeed = 200;
            this.EtkinlikSilButton.AutoGenerateColors = false;
            this.EtkinlikSilButton.AutoRoundBorders = true;
            this.EtkinlikSilButton.AutoSizeLeftIcon = true;
            this.EtkinlikSilButton.AutoSizeRightIcon = true;
            this.EtkinlikSilButton.BackColor = System.Drawing.Color.Transparent;
            this.EtkinlikSilButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.EtkinlikSilButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EtkinlikSilButton.BackgroundImage")));
            this.EtkinlikSilButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EtkinlikSilButton.ButtonText = "Etkinlik Sil";
            this.EtkinlikSilButton.ButtonTextMarginLeft = 0;
            this.EtkinlikSilButton.ColorContrastOnClick = 45;
            this.EtkinlikSilButton.ColorContrastOnHover = 45;
            this.EtkinlikSilButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = false;
            borderEdges3.BottomRight = false;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.EtkinlikSilButton.CustomizableEdges = borderEdges3;
            this.EtkinlikSilButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EtkinlikSilButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.EtkinlikSilButton.DisabledFillColor = System.Drawing.Color.Empty;
            this.EtkinlikSilButton.DisabledForecolor = System.Drawing.Color.Empty;
            this.EtkinlikSilButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.EtkinlikSilButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.EtkinlikSilButton.ForeColor = System.Drawing.Color.White;
            this.EtkinlikSilButton.IconLeft = null;
            this.EtkinlikSilButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EtkinlikSilButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.EtkinlikSilButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.EtkinlikSilButton.IconMarginLeft = 11;
            this.EtkinlikSilButton.IconPadding = 10;
            this.EtkinlikSilButton.IconRight = null;
            this.EtkinlikSilButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EtkinlikSilButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.EtkinlikSilButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.EtkinlikSilButton.IconSize = 25;
            this.EtkinlikSilButton.IdleBorderColor = System.Drawing.Color.Empty;
            this.EtkinlikSilButton.IdleBorderRadius = 0;
            this.EtkinlikSilButton.IdleBorderThickness = 0;
            this.EtkinlikSilButton.IdleFillColor = System.Drawing.Color.Empty;
            this.EtkinlikSilButton.IdleIconLeftImage = null;
            this.EtkinlikSilButton.IdleIconRightImage = null;
            this.EtkinlikSilButton.IndicateFocus = false;
            this.EtkinlikSilButton.Location = new System.Drawing.Point(330, 429);
            this.EtkinlikSilButton.Name = "EtkinlikSilButton";
            this.EtkinlikSilButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EtkinlikSilButton.OnDisabledState.BorderRadius = 55;
            this.EtkinlikSilButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.EtkinlikSilButton.OnDisabledState.BorderThickness = 1;
            this.EtkinlikSilButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EtkinlikSilButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EtkinlikSilButton.OnDisabledState.IconLeftImage = null;
            this.EtkinlikSilButton.OnDisabledState.IconRightImage = null;
            this.EtkinlikSilButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.EtkinlikSilButton.onHoverState.BorderRadius = 55;
            this.EtkinlikSilButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EtkinlikSilButton.onHoverState.BorderThickness = 1;
            this.EtkinlikSilButton.onHoverState.FillColor = System.Drawing.Color.White;
            this.EtkinlikSilButton.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.EtkinlikSilButton.onHoverState.IconLeftImage = null;
            this.EtkinlikSilButton.onHoverState.IconRightImage = null;
            this.EtkinlikSilButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.EtkinlikSilButton.OnIdleState.BorderRadius = 55;
            this.EtkinlikSilButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EtkinlikSilButton.OnIdleState.BorderThickness = 1;
            this.EtkinlikSilButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.EtkinlikSilButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.EtkinlikSilButton.OnIdleState.IconLeftImage = null;
            this.EtkinlikSilButton.OnIdleState.IconRightImage = null;
            this.EtkinlikSilButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.EtkinlikSilButton.OnPressedState.BorderRadius = 55;
            this.EtkinlikSilButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EtkinlikSilButton.OnPressedState.BorderThickness = 1;
            this.EtkinlikSilButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.EtkinlikSilButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.EtkinlikSilButton.OnPressedState.IconLeftImage = null;
            this.EtkinlikSilButton.OnPressedState.IconRightImage = null;
            this.EtkinlikSilButton.Size = new System.Drawing.Size(140, 55);
            this.EtkinlikSilButton.TabIndex = 9;
            this.EtkinlikSilButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EtkinlikSilButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.EtkinlikSilButton.TextMarginLeft = 0;
            this.EtkinlikSilButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.EtkinlikSilButton.UseDefaultRadiusAndThickness = true;
            this.EtkinlikSilButton.Click += new System.EventHandler(this.bunifuButton2_Click);
            // 
            // EtkinlikDuzenleButton
            // 
            this.EtkinlikDuzenleButton.AllowAnimations = true;
            this.EtkinlikDuzenleButton.AllowMouseEffects = true;
            this.EtkinlikDuzenleButton.AllowToggling = false;
            this.EtkinlikDuzenleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EtkinlikDuzenleButton.AnimationSpeed = 200;
            this.EtkinlikDuzenleButton.AutoGenerateColors = false;
            this.EtkinlikDuzenleButton.AutoRoundBorders = true;
            this.EtkinlikDuzenleButton.AutoSizeLeftIcon = true;
            this.EtkinlikDuzenleButton.AutoSizeRightIcon = true;
            this.EtkinlikDuzenleButton.BackColor = System.Drawing.Color.Transparent;
            this.EtkinlikDuzenleButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.EtkinlikDuzenleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EtkinlikDuzenleButton.BackgroundImage")));
            this.EtkinlikDuzenleButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EtkinlikDuzenleButton.ButtonText = "Etkinlik Düzenle";
            this.EtkinlikDuzenleButton.ButtonTextMarginLeft = 0;
            this.EtkinlikDuzenleButton.ColorContrastOnClick = 45;
            this.EtkinlikDuzenleButton.ColorContrastOnHover = 45;
            this.EtkinlikDuzenleButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = false;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.EtkinlikDuzenleButton.CustomizableEdges = borderEdges4;
            this.EtkinlikDuzenleButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EtkinlikDuzenleButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.EtkinlikDuzenleButton.DisabledFillColor = System.Drawing.Color.Empty;
            this.EtkinlikDuzenleButton.DisabledForecolor = System.Drawing.Color.Empty;
            this.EtkinlikDuzenleButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.EtkinlikDuzenleButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.EtkinlikDuzenleButton.ForeColor = System.Drawing.Color.White;
            this.EtkinlikDuzenleButton.IconLeft = null;
            this.EtkinlikDuzenleButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EtkinlikDuzenleButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.EtkinlikDuzenleButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.EtkinlikDuzenleButton.IconMarginLeft = 11;
            this.EtkinlikDuzenleButton.IconPadding = 10;
            this.EtkinlikDuzenleButton.IconRight = null;
            this.EtkinlikDuzenleButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EtkinlikDuzenleButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.EtkinlikDuzenleButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.EtkinlikDuzenleButton.IconSize = 25;
            this.EtkinlikDuzenleButton.IdleBorderColor = System.Drawing.Color.Empty;
            this.EtkinlikDuzenleButton.IdleBorderRadius = 0;
            this.EtkinlikDuzenleButton.IdleBorderThickness = 0;
            this.EtkinlikDuzenleButton.IdleFillColor = System.Drawing.Color.Empty;
            this.EtkinlikDuzenleButton.IdleIconLeftImage = null;
            this.EtkinlikDuzenleButton.IdleIconRightImage = null;
            this.EtkinlikDuzenleButton.IndicateFocus = false;
            this.EtkinlikDuzenleButton.Location = new System.Drawing.Point(622, 429);
            this.EtkinlikDuzenleButton.Name = "EtkinlikDuzenleButton";
            this.EtkinlikDuzenleButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EtkinlikDuzenleButton.OnDisabledState.BorderRadius = 55;
            this.EtkinlikDuzenleButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.EtkinlikDuzenleButton.OnDisabledState.BorderThickness = 1;
            this.EtkinlikDuzenleButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EtkinlikDuzenleButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EtkinlikDuzenleButton.OnDisabledState.IconLeftImage = null;
            this.EtkinlikDuzenleButton.OnDisabledState.IconRightImage = null;
            this.EtkinlikDuzenleButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.EtkinlikDuzenleButton.onHoverState.BorderRadius = 55;
            this.EtkinlikDuzenleButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EtkinlikDuzenleButton.onHoverState.BorderThickness = 1;
            this.EtkinlikDuzenleButton.onHoverState.FillColor = System.Drawing.Color.White;
            this.EtkinlikDuzenleButton.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.EtkinlikDuzenleButton.onHoverState.IconLeftImage = null;
            this.EtkinlikDuzenleButton.onHoverState.IconRightImage = null;
            this.EtkinlikDuzenleButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.EtkinlikDuzenleButton.OnIdleState.BorderRadius = 55;
            this.EtkinlikDuzenleButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EtkinlikDuzenleButton.OnIdleState.BorderThickness = 1;
            this.EtkinlikDuzenleButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.EtkinlikDuzenleButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.EtkinlikDuzenleButton.OnIdleState.IconLeftImage = null;
            this.EtkinlikDuzenleButton.OnIdleState.IconRightImage = null;
            this.EtkinlikDuzenleButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.EtkinlikDuzenleButton.OnPressedState.BorderRadius = 55;
            this.EtkinlikDuzenleButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EtkinlikDuzenleButton.OnPressedState.BorderThickness = 1;
            this.EtkinlikDuzenleButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(74)))), ((int)(((byte)(222)))));
            this.EtkinlikDuzenleButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.EtkinlikDuzenleButton.OnPressedState.IconLeftImage = null;
            this.EtkinlikDuzenleButton.OnPressedState.IconRightImage = null;
            this.EtkinlikDuzenleButton.Size = new System.Drawing.Size(140, 55);
            this.EtkinlikDuzenleButton.TabIndex = 10;
            this.EtkinlikDuzenleButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EtkinlikDuzenleButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.EtkinlikDuzenleButton.TextMarginLeft = 0;
            this.EtkinlikDuzenleButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.EtkinlikDuzenleButton.UseDefaultRadiusAndThickness = true;
            this.EtkinlikDuzenleButton.Click += new System.EventHandler(this.EtkinlikDuzenleButton_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.CurrentTheme.Name = null;
            this.dataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(750, 225);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellValueChanged);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.bunifuDataGridView1_ColumnHeaderMouseClick);
            // 
            // ScanGraphyMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 496);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EtkinlikDuzenleButton);
            this.Controls.Add(this.EtkinlikSilButton);
            this.Controls.Add(this.EtkinlikEkleButton);
            this.Controls.Add(this.TakvimdeGosterButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScanGraphyMainForm";
            this.Text = "ScanGraphy";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton TakvimdeGosterButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton EtkinlikEkleButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton EtkinlikSilButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton EtkinlikDuzenleButton;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridView1;
    }
}

