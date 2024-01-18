namespace GuiScrcpyPlusPlus
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scrcpyPanel = new CustomComponent.RoundPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.roundPanel1 = new CustomComponent.RoundPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.screenOff = new CustomComponent.SwitchButton();
            this.roundPanel3 = new CustomComponent.RoundPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.alwaysTop = new CustomComponent.SwitchButton();
            this.scrcpyVersion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.roundPanel5 = new CustomComponent.RoundPanel();
            this.scrcpyPath = new System.Windows.Forms.Label();
            this.roundButton1 = new CustomComponent.RoundButton(this.components);
            this.roundPanel6 = new CustomComponent.RoundPanel();
            this.roundPanel4 = new CustomComponent.RoundPanel();
            this.startLabel = new System.Windows.Forms.Label();
            this.toggle = new CustomComponent.SwitchButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.scrcpyPanel.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            this.roundPanel3.SuspendLayout();
            this.roundPanel5.SuspendLayout();
            this.roundPanel6.SuspendLayout();
            this.roundPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.CausesValidation = false;
            this.info.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.75F, System.Drawing.FontStyle.Bold);
            this.info.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.info.Location = new System.Drawing.Point(25, 38);
            this.info.Name = "info";
            this.info.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.info.Size = new System.Drawing.Size(99, 36);
            this.info.TabIndex = 1;
            this.info.Text = "No device found!";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Not running";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(19, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // scrcpyPanel
            // 
            this.scrcpyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrcpyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.scrcpyPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.scrcpyPanel.BorderRadius = 5;
            this.scrcpyPanel.BorderRoundSize = 1;
            this.scrcpyPanel.Clickable = false;
            this.scrcpyPanel.Controls.Add(this.label9);
            this.scrcpyPanel.Controls.Add(this.roundPanel1);
            this.scrcpyPanel.Controls.Add(this.roundPanel3);
            this.scrcpyPanel.Controls.Add(this.scrcpyVersion);
            this.scrcpyPanel.Controls.Add(this.label5);
            this.scrcpyPanel.Controls.Add(this.roundPanel5);
            this.scrcpyPanel.Controls.Add(this.roundButton1);
            this.scrcpyPanel.Controls.Add(this.roundPanel6);
            this.scrcpyPanel.Location = new System.Drawing.Point(26, 203);
            this.scrcpyPanel.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.scrcpyPanel.MouseLeaveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.scrcpyPanel.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.scrcpyPanel.MouseUpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.scrcpyPanel.Name = "scrcpyPanel";
            this.scrcpyPanel.Size = new System.Drawing.Size(518, 281);
            this.scrcpyPanel.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(19, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Options";
            // 
            // roundPanel1
            // 
            this.roundPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roundPanel1.BorderRadius = 5;
            this.roundPanel1.BorderRoundSize = 1;
            this.roundPanel1.Clickable = false;
            this.roundPanel1.Controls.Add(this.label7);
            this.roundPanel1.Controls.Add(this.screenOff);
            this.roundPanel1.Location = new System.Drawing.Point(16, 203);
            this.roundPanel1.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel1.MouseLeaveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel1.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel1.MouseUpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(487, 36);
            this.roundPanel1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Turn screen off";
            // 
            // screenOff
            // 
            this.screenOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.screenOff.AutoSize = true;
            this.screenOff.BackColor = System.Drawing.Color.Transparent;
            this.screenOff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.screenOff.BorderRoundSize = 1;
            this.screenOff.Font = new System.Drawing.Font("Microsoft YaHei", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenOff.Location = new System.Drawing.Point(436, 9);
            this.screenOff.Name = "screenOff";
            this.screenOff.Padding = new System.Windows.Forms.Padding(6);
            this.screenOff.Size = new System.Drawing.Size(46, 26);
            this.screenOff.TabIndex = 14;
            this.screenOff.Text = "             ";
            this.screenOff.UseVisualStyleBackColor = false;
            this.screenOff.CheckedChanged += new System.EventHandler(this.screenOff_CheckedChanged);
            // 
            // roundPanel3
            // 
            this.roundPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roundPanel3.BorderRadius = 5;
            this.roundPanel3.BorderRoundSize = 1;
            this.roundPanel3.Clickable = false;
            this.roundPanel3.Controls.Add(this.label8);
            this.roundPanel3.Controls.Add(this.alwaysTop);
            this.roundPanel3.Location = new System.Drawing.Point(16, 231);
            this.roundPanel3.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel3.MouseLeaveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel3.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel3.MouseUpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel3.Name = "roundPanel3";
            this.roundPanel3.Size = new System.Drawing.Size(487, 36);
            this.roundPanel3.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Always on Top";
            // 
            // alwaysTop
            // 
            this.alwaysTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.alwaysTop.AutoSize = true;
            this.alwaysTop.BackColor = System.Drawing.Color.Transparent;
            this.alwaysTop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.alwaysTop.BorderRoundSize = 1;
            this.alwaysTop.Font = new System.Drawing.Font("Microsoft YaHei", 2.25F);
            this.alwaysTop.Location = new System.Drawing.Point(436, 9);
            this.alwaysTop.Name = "alwaysTop";
            this.alwaysTop.Padding = new System.Windows.Forms.Padding(6);
            this.alwaysTop.Size = new System.Drawing.Size(46, 26);
            this.alwaysTop.TabIndex = 14;
            this.alwaysTop.Text = "             ";
            this.alwaysTop.UseVisualStyleBackColor = false;
            this.alwaysTop.CheckedChanged += new System.EventHandler(this.alwaysTop_CheckedChanged);
            // 
            // scrcpyVersion
            // 
            this.scrcpyVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scrcpyVersion.BackColor = System.Drawing.Color.Transparent;
            this.scrcpyVersion.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.75F, System.Drawing.FontStyle.Bold);
            this.scrcpyVersion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.scrcpyVersion.Location = new System.Drawing.Point(314, 18);
            this.scrcpyVersion.Name = "scrcpyVersion";
            this.scrcpyVersion.Size = new System.Drawing.Size(188, 16);
            this.scrcpyVersion.TabIndex = 12;
            this.scrcpyVersion.Text = "Scrcpy not found!";
            this.scrcpyVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(19, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Scrcpy Path";
            // 
            // roundPanel5
            // 
            this.roundPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.roundPanel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel5.BorderRadius = 5;
            this.roundPanel5.BorderRoundSize = 1;
            this.roundPanel5.Clickable = false;
            this.roundPanel5.Controls.Add(this.scrcpyPath);
            this.roundPanel5.Location = new System.Drawing.Point(15, 39);
            this.roundPanel5.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.roundPanel5.MouseLeaveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.roundPanel5.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.roundPanel5.MouseUpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.roundPanel5.Name = "roundPanel5";
            this.roundPanel5.Size = new System.Drawing.Size(440, 33);
            this.roundPanel5.TabIndex = 12;
            // 
            // scrcpyPath
            // 
            this.scrcpyPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrcpyPath.AutoEllipsis = true;
            this.scrcpyPath.BackColor = System.Drawing.Color.Transparent;
            this.scrcpyPath.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.75F, System.Drawing.FontStyle.Bold);
            this.scrcpyPath.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.scrcpyPath.Location = new System.Drawing.Point(6, 8);
            this.scrcpyPath.Name = "scrcpyPath";
            this.scrcpyPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scrcpyPath.Size = new System.Drawing.Size(431, 17);
            this.scrcpyPath.TabIndex = 4;
            this.scrcpyPath.Text = "C:\\Users\\";
            // 
            // roundButton1
            // 
            this.roundButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roundButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundButton1.BorderRadius = 5;
            this.roundButton1.BorderRoundSize = 1;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.roundButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold);
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(461, 39);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(39, 33);
            this.roundButton1.TabIndex = 11;
            this.roundButton1.Text = "...";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // roundPanel6
            // 
            this.roundPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roundPanel6.BorderRadius = 5;
            this.roundPanel6.BorderRoundSize = 1;
            this.roundPanel6.Clickable = false;
            this.roundPanel6.Controls.Add(this.label1);
            this.roundPanel6.Controls.Add(this.info);
            this.roundPanel6.Location = new System.Drawing.Point(-5, 82);
            this.roundPanel6.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel6.MouseLeaveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel6.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel6.MouseUpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel6.Name = "roundPanel6";
            this.roundPanel6.Size = new System.Drawing.Size(529, 87);
            this.roundPanel6.TabIndex = 18;
            // 
            // roundPanel4
            // 
            this.roundPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roundPanel4.BorderRadius = 5;
            this.roundPanel4.BorderRoundSize = 1;
            this.roundPanel4.Clickable = false;
            this.roundPanel4.Controls.Add(this.startLabel);
            this.roundPanel4.Controls.Add(this.toggle);
            this.roundPanel4.Controls.Add(this.label3);
            this.roundPanel4.Controls.Add(this.label2);
            this.roundPanel4.Location = new System.Drawing.Point(26, 133);
            this.roundPanel4.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel4.MouseLeaveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel4.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel4.MouseUpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel4.Name = "roundPanel4";
            this.roundPanel4.Size = new System.Drawing.Size(518, 70);
            this.roundPanel4.TabIndex = 10;
            // 
            // startLabel
            // 
            this.startLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startLabel.BackColor = System.Drawing.Color.Transparent;
            this.startLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.startLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.startLabel.Location = new System.Drawing.Point(378, 25);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(63, 19);
            this.startLabel.TabIndex = 13;
            this.startLabel.Text = "Off";
            this.startLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toggle
            // 
            this.toggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toggle.AutoCheck = false;
            this.toggle.AutoSize = true;
            this.toggle.BackColor = System.Drawing.Color.Transparent;
            this.toggle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.toggle.BorderRoundSize = 1;
            this.toggle.Cursor = System.Windows.Forms.Cursors.Default;
            this.toggle.Location = new System.Drawing.Point(444, 25);
            this.toggle.Name = "toggle";
            this.toggle.Padding = new System.Windows.Forms.Padding(6);
            this.toggle.Size = new System.Drawing.Size(56, 29);
            this.toggle.TabIndex = 12;
            this.toggle.Text = "      ";
            this.toggle.UseVisualStyleBackColor = false;
            this.toggle.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(115, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "GuiScrcpy++";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(119, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Developed by IanDiv";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 15.25F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Location = new System.Drawing.Point(511, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 30);
            this.label12.TabIndex = 20;
            this.label12.Text = "ⓘ";
            this.label12.Click += new System.EventHandler(this.roundPanel7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GuiScrcpyPlusPlus.Properties.Resources.GuiScrcpy__;
            this.pictureBox1.Location = new System.Drawing.Point(16, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(574, 515);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scrcpyPanel);
            this.Controls.Add(this.roundPanel4);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(456, 533);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuiScrcpy++";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.scrcpyPanel.ResumeLayout(false);
            this.scrcpyPanel.PerformLayout();
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            this.roundPanel3.ResumeLayout(false);
            this.roundPanel3.PerformLayout();
            this.roundPanel5.ResumeLayout(false);
            this.roundPanel6.ResumeLayout(false);
            this.roundPanel6.PerformLayout();
            this.roundPanel4.ResumeLayout(false);
            this.roundPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomComponent.RoundPanel scrcpyPanel;
        private CustomComponent.RoundPanel roundPanel4;
        private System.Windows.Forms.Label label4;
        private CustomComponent.RoundButton roundButton1;
        private CustomComponent.RoundPanel roundPanel5;
        private System.Windows.Forms.Label scrcpyPath;
        private System.Windows.Forms.Label scrcpyVersion;
        private System.Windows.Forms.Label label5;
        private CustomComponent.SwitchButton toggle;
        private System.Windows.Forms.Label label8;
        private CustomComponent.SwitchButton alwaysTop;
        private CustomComponent.RoundPanel roundPanel3;
        private CustomComponent.SwitchButton screenOff;
        private System.Windows.Forms.Label label7;
        private CustomComponent.RoundPanel roundPanel1;
        private CustomComponent.RoundPanel roundPanel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

