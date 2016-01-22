namespace Project
{
    partial class ucSaveUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSaveUser));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnNext = new DevComponents.DotNetBar.ButtonX();
            this.btnPrevious = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtFullName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBirthday = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaSV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbBirthday = new DevComponents.DotNetBar.LabelX();
            this.lbFullName = new DevComponents.DotNetBar.LabelX();
            this.lbMaSV = new DevComponents.DotNetBar.LabelX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.imageFile = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnNext);
            this.groupPanel1.Controls.Add(this.btnPrevious);
            this.groupPanel1.Controls.Add(this.btnSave);
            this.groupPanel1.Controls.Add(this.txtFullName);
            this.groupPanel1.Controls.Add(this.txtBirthday);
            this.groupPanel1.Controls.Add(this.txtMaSV);
            this.groupPanel1.Controls.Add(this.lbBirthday);
            this.groupPanel1.Controls.Add(this.lbFullName);
            this.groupPanel1.Controls.Add(this.lbMaSV);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(13, 16);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(345, 259);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Thông tin người dùng";
            // 
            // btnNext
            // 
            this.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNext.Location = new System.Drawing.Point(237, 194);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            // 
            // btnPrevious
            // 
            this.btnPrevious.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrevious.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrevious.Location = new System.Drawing.Point(129, 195);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "Previous";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(24, 196);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            // 
            // txtFullName
            // 
            // 
            // 
            // 
            this.txtFullName.Border.Class = "TextBoxBorder";
            this.txtFullName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFullName.Location = new System.Drawing.Point(104, 70);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PreventEnterBeep = true;
            this.txtFullName.Size = new System.Drawing.Size(180, 20);
            this.txtFullName.TabIndex = 5;
            // 
            // txtBirthday
            // 
            // 
            // 
            // 
            this.txtBirthday.Border.Class = "TextBoxBorder";
            this.txtBirthday.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBirthday.Location = new System.Drawing.Point(104, 112);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.PreventEnterBeep = true;
            this.txtBirthday.Size = new System.Drawing.Size(180, 20);
            this.txtBirthday.TabIndex = 4;
            // 
            // txtMaSV
            // 
            // 
            // 
            // 
            this.txtMaSV.Border.Class = "TextBoxBorder";
            this.txtMaSV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaSV.Location = new System.Drawing.Point(104, 32);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.PreventEnterBeep = true;
            this.txtMaSV.Size = new System.Drawing.Size(180, 20);
            this.txtMaSV.TabIndex = 3;
            // 
            // lbBirthday
            // 
            // 
            // 
            // 
            this.lbBirthday.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbBirthday.Location = new System.Drawing.Point(22, 112);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(70, 20);
            this.lbBirthday.TabIndex = 2;
            this.lbBirthday.Text = "Ngày Sinh :";
            // 
            // lbFullName
            // 
            // 
            // 
            // 
            this.lbFullName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbFullName.Location = new System.Drawing.Point(22, 70);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(70, 20);
            this.lbFullName.TabIndex = 1;
            this.lbFullName.Text = "Họ Và Tên :";
            // 
            // lbMaSV
            // 
            this.lbMaSV.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbMaSV.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.DockSiteBackColor2;
            this.lbMaSV.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbMaSV.Location = new System.Drawing.Point(22, 30);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(70, 20);
            this.lbMaSV.TabIndex = 0;
            this.lbMaSV.Text = "Mã SV :";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.imageFile);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(373, 16);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(240, 259);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 1;
            this.groupPanel2.Text = "Hình ảnh";
            // 
            // imageFile
            // 
            // 
            // 
            // 
            this.imageFile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.imageFile.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.imageFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageFile.Image = ((System.Drawing.Image)(resources.GetObject("imageFile.Image")));
            this.imageFile.Location = new System.Drawing.Point(0, 0);
            this.imageFile.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.imageFile.Name = "imageFile";
            this.imageFile.Size = new System.Drawing.Size(234, 238);
            this.imageFile.TabIndex = 0;
            this.imageFile.Click += new System.EventHandler(this.reflectionImage1_Click);
            // 
            // ucSaveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Name = "ucSaveUser";
            this.Size = new System.Drawing.Size(627, 300);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnNext;
        private DevComponents.DotNetBar.ButtonX btnPrevious;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFullName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBirthday;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaSV;
        private DevComponents.DotNetBar.LabelX lbBirthday;
        private DevComponents.DotNetBar.LabelX lbFullName;
        private DevComponents.DotNetBar.LabelX lbMaSV;
        private DevComponents.DotNetBar.Controls.ReflectionImage imageFile;

    }
}
