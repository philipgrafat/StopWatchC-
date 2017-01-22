namespace StopWatch
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.hoursValueLabel = new System.Windows.Forms.Label();
            this.minutesValueLabel = new System.Windows.Forms.Label();
            this.secondsValueLabel = new System.Windows.Forms.Label();
            this.hoursTextLabel = new System.Windows.Forms.Label();
            this.minutesTextLabel = new System.Windows.Forms.Label();
            this.secondsTextLabel = new System.Windows.Forms.Label();
            this.centisecondsValueLabel = new System.Windows.Forms.Label();
            this.resetLabel = new System.Windows.Forms.Label();
            this.lapsView = new System.Windows.Forms.ListView();
            this.lapsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.durationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lapLabel = new System.Windows.Forms.Label();
            this.lapIcon = new System.Windows.Forms.PictureBox();
            this.lapButton = new System.Windows.Forms.PictureBox();
            this.htlLogo = new System.Windows.Forms.PictureBox();
            this.resetIcon = new System.Windows.Forms.PictureBox();
            this.resetButton = new System.Windows.Forms.PictureBox();
            this.whiteBox = new System.Windows.Forms.PictureBox();
            this.whiteBoxShadow = new System.Windows.Forms.PictureBox();
            this.toggleButton = new StopWatch.OvalPictureBox();
            this.toggleButtonShadow = new StopWatch.OvalPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lapIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lapButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.htlLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteBoxShadow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButtonShadow)).BeginInit();
            this.SuspendLayout();
            // 
            // hoursValueLabel
            // 
            this.hoursValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hoursValueLabel.AutoSize = true;
            this.hoursValueLabel.BackColor = System.Drawing.Color.White;
            this.hoursValueLabel.Font = new System.Drawing.Font("Roboto", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.hoursValueLabel.Location = new System.Drawing.Point(143, 86);
            this.hoursValueLabel.Name = "hoursValueLabel";
            this.hoursValueLabel.Size = new System.Drawing.Size(149, 175);
            this.hoursValueLabel.TabIndex = 5;
            this.hoursValueLabel.Text = "0";
            // 
            // minutesValueLabel
            // 
            this.minutesValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minutesValueLabel.AutoSize = true;
            this.minutesValueLabel.BackColor = System.Drawing.Color.White;
            this.minutesValueLabel.Font = new System.Drawing.Font("Roboto", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.minutesValueLabel.Location = new System.Drawing.Point(244, 86);
            this.minutesValueLabel.Name = "minutesValueLabel";
            this.minutesValueLabel.Size = new System.Drawing.Size(224, 175);
            this.minutesValueLabel.TabIndex = 11;
            this.minutesValueLabel.Text = "00";
            // 
            // secondsValueLabel
            // 
            this.secondsValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.secondsValueLabel.AutoSize = true;
            this.secondsValueLabel.BackColor = System.Drawing.Color.White;
            this.secondsValueLabel.Font = new System.Drawing.Font("Roboto", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.secondsValueLabel.Location = new System.Drawing.Point(423, 86);
            this.secondsValueLabel.Name = "secondsValueLabel";
            this.secondsValueLabel.Size = new System.Drawing.Size(224, 175);
            this.secondsValueLabel.TabIndex = 12;
            this.secondsValueLabel.Text = "00";
            // 
            // hoursTextLabel
            // 
            this.hoursTextLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hoursTextLabel.AutoSize = true;
            this.hoursTextLabel.BackColor = System.Drawing.Color.White;
            this.hoursTextLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.hoursTextLabel.Location = new System.Drawing.Point(246, 209);
            this.hoursTextLabel.Name = "hoursTextLabel";
            this.hoursTextLabel.Size = new System.Drawing.Size(21, 21);
            this.hoursTextLabel.TabIndex = 13;
            this.hoursTextLabel.Text = "H";
            // 
            // minutesTextLabel
            // 
            this.minutesTextLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minutesTextLabel.AutoSize = true;
            this.minutesTextLabel.BackColor = System.Drawing.Color.White;
            this.minutesTextLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.minutesTextLabel.Location = new System.Drawing.Point(421, 208);
            this.minutesTextLabel.Name = "minutesTextLabel";
            this.minutesTextLabel.Size = new System.Drawing.Size(24, 21);
            this.minutesTextLabel.TabIndex = 14;
            this.minutesTextLabel.Text = "M";
            // 
            // secondsTextLabel
            // 
            this.secondsTextLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.secondsTextLabel.AutoSize = true;
            this.secondsTextLabel.BackColor = System.Drawing.Color.White;
            this.secondsTextLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.secondsTextLabel.Location = new System.Drawing.Point(602, 209);
            this.secondsTextLabel.Name = "secondsTextLabel";
            this.secondsTextLabel.Size = new System.Drawing.Size(20, 21);
            this.secondsTextLabel.TabIndex = 15;
            this.secondsTextLabel.Text = "S";
            // 
            // centisecondsValueLabel
            // 
            this.centisecondsValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.centisecondsValueLabel.AutoSize = true;
            this.centisecondsValueLabel.BackColor = System.Drawing.Color.White;
            this.centisecondsValueLabel.Font = new System.Drawing.Font("Roboto", 20.25F);
            this.centisecondsValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.centisecondsValueLabel.Location = new System.Drawing.Point(628, 197);
            this.centisecondsValueLabel.Name = "centisecondsValueLabel";
            this.centisecondsValueLabel.Size = new System.Drawing.Size(45, 35);
            this.centisecondsValueLabel.TabIndex = 16;
            this.centisecondsValueLabel.Text = "00";
            // 
            // resetLabel
            // 
            this.resetLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resetLabel.AutoSize = true;
            this.resetLabel.BackColor = System.Drawing.Color.White;
            this.resetLabel.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.resetLabel.Location = new System.Drawing.Point(543, 274);
            this.resetLabel.Name = "resetLabel";
            this.resetLabel.Size = new System.Drawing.Size(54, 20);
            this.resetLabel.TabIndex = 19;
            this.resetLabel.Text = "RESET";
            this.resetLabel.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // lapsView
            // 
            this.lapsView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lapsView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(9)))));
            this.lapsView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lapsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lapsHeader,
            this.durationHeader,
            this.timeHeader});
            this.lapsView.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapsView.ForeColor = System.Drawing.Color.White;
            this.lapsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lapsView.Location = new System.Drawing.Point(263, 345);
            this.lapsView.Name = "lapsView";
            this.lapsView.Size = new System.Drawing.Size(346, 115);
            this.lapsView.TabIndex = 23;
            this.lapsView.UseCompatibleStateImageBehavior = false;
            this.lapsView.View = System.Windows.Forms.View.Details;
            // 
            // lapsHeader
            // 
            this.lapsHeader.Text = "Laps";
            this.lapsHeader.Width = 95;
            // 
            // durationHeader
            // 
            this.durationHeader.Text = "Duration";
            this.durationHeader.Width = 124;
            // 
            // timeHeader
            // 
            this.timeHeader.Text = "Time";
            this.timeHeader.Width = 113;
            // 
            // lapLabel
            // 
            this.lapLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lapLabel.AutoSize = true;
            this.lapLabel.BackColor = System.Drawing.Color.White;
            this.lapLabel.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.lapLabel.Location = new System.Drawing.Point(257, 274);
            this.lapLabel.Name = "lapLabel";
            this.lapLabel.Size = new System.Drawing.Size(36, 20);
            this.lapLabel.TabIndex = 24;
            this.lapLabel.Text = "LAP";
            // 
            // lapIcon
            // 
            this.lapIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lapIcon.BackColor = System.Drawing.Color.White;
            this.lapIcon.Image = global::StopWatch.Properties.Resources.flag_disabled;
            this.lapIcon.Location = new System.Drawing.Point(234, 273);
            this.lapIcon.Name = "lapIcon";
            this.lapIcon.Size = new System.Drawing.Size(20, 23);
            this.lapIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lapIcon.TabIndex = 25;
            this.lapIcon.TabStop = false;
            // 
            // lapButton
            // 
            this.lapButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lapButton.BackColor = System.Drawing.Color.White;
            this.lapButton.Location = new System.Drawing.Point(225, 266);
            this.lapButton.Name = "lapButton";
            this.lapButton.Size = new System.Drawing.Size(68, 33);
            this.lapButton.TabIndex = 26;
            this.lapButton.TabStop = false;
            this.lapButton.Click += new System.EventHandler(this.lapButton_Click);
            // 
            // htlLogo
            // 
            this.htlLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.htlLogo.Image = global::StopWatch.Properties.Resources.htl_logo_bw;
            this.htlLogo.Location = new System.Drawing.Point(654, 418);
            this.htlLogo.Name = "htlLogo";
            this.htlLogo.Size = new System.Drawing.Size(118, 42);
            this.htlLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.htlLogo.TabIndex = 22;
            this.htlLogo.TabStop = false;
            this.htlLogo.Click += new System.EventHandler(this.htlLogo_Click);
            this.htlLogo.MouseEnter += new System.EventHandler(this.htlLogo_MouseEnter);
            this.htlLogo.MouseLeave += new System.EventHandler(this.htlLogo_MouseLeave);
            // 
            // resetIcon
            // 
            this.resetIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resetIcon.BackColor = System.Drawing.Color.White;
            this.resetIcon.Image = global::StopWatch.Properties.Resources.reset_disabled;
            this.resetIcon.Location = new System.Drawing.Point(520, 273);
            this.resetIcon.Name = "resetIcon";
            this.resetIcon.Size = new System.Drawing.Size(20, 23);
            this.resetIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resetIcon.TabIndex = 20;
            this.resetIcon.TabStop = false;
            this.resetIcon.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resetButton.BackColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(511, 266);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(86, 33);
            this.resetButton.TabIndex = 21;
            this.resetButton.TabStop = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // whiteBox
            // 
            this.whiteBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.whiteBox.BackColor = System.Drawing.Color.White;
            this.whiteBox.Location = new System.Drawing.Point(100, 50);
            this.whiteBox.MinimumSize = new System.Drawing.Size(600, 250);
            this.whiteBox.Name = "whiteBox";
            this.whiteBox.Size = new System.Drawing.Size(600, 250);
            this.whiteBox.TabIndex = 9;
            this.whiteBox.TabStop = false;
            // 
            // whiteBoxShadow
            // 
            this.whiteBoxShadow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.whiteBoxShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(113)))), ((int)(((byte)(43)))));
            this.whiteBoxShadow.Location = new System.Drawing.Point(99, 52);
            this.whiteBoxShadow.MinimumSize = new System.Drawing.Size(600, 250);
            this.whiteBoxShadow.Name = "whiteBoxShadow";
            this.whiteBoxShadow.Size = new System.Drawing.Size(602, 250);
            this.whiteBoxShadow.TabIndex = 10;
            this.whiteBoxShadow.TabStop = false;
            // 
            // toggleButton
            // 
            this.toggleButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toggleButton.BackColor = System.Drawing.Color.Transparent;
            this.toggleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButton.Image = global::StopWatch.Properties.Resources.play;
            this.toggleButton.Location = new System.Drawing.Point(368, 266);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.Size = new System.Drawing.Size(65, 65);
            this.toggleButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.toggleButton.TabIndex = 17;
            this.toggleButton.TabStop = false;
            this.toggleButton.Click += new System.EventHandler(this.toggleButton_Click);
            // 
            // toggleButtonShadow
            // 
            this.toggleButtonShadow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toggleButtonShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(113)))), ((int)(((byte)(43)))));
            this.toggleButtonShadow.Location = new System.Drawing.Point(368, 267);
            this.toggleButtonShadow.Name = "toggleButtonShadow";
            this.toggleButtonShadow.Size = new System.Drawing.Size(66, 66);
            this.toggleButtonShadow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.toggleButtonShadow.TabIndex = 18;
            this.toggleButtonShadow.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(9)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lapsView);
            this.Controls.Add(this.lapLabel);
            this.Controls.Add(this.lapIcon);
            this.Controls.Add(this.lapButton);
            this.Controls.Add(this.htlLogo);
            this.Controls.Add(this.centisecondsValueLabel);
            this.Controls.Add(this.secondsTextLabel);
            this.Controls.Add(this.minutesTextLabel);
            this.Controls.Add(this.hoursTextLabel);
            this.Controls.Add(this.secondsValueLabel);
            this.Controls.Add(this.minutesValueLabel);
            this.Controls.Add(this.hoursValueLabel);
            this.Controls.Add(this.toggleButton);
            this.Controls.Add(this.resetLabel);
            this.Controls.Add(this.resetIcon);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.whiteBox);
            this.Controls.Add(this.whiteBoxShadow);
            this.Controls.Add(this.toggleButtonShadow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.Text = "StopWatch by Philip Graf";
            ((System.ComponentModel.ISupportInitialize)(this.lapIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lapButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.htlLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteBoxShadow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButtonShadow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label hoursValueLabel;
        private System.Windows.Forms.PictureBox whiteBox;
        private System.Windows.Forms.PictureBox whiteBoxShadow;
        private System.Windows.Forms.Label minutesValueLabel;
        private System.Windows.Forms.Label secondsValueLabel;
        private System.Windows.Forms.Label hoursTextLabel;
        private System.Windows.Forms.Label minutesTextLabel;
        private System.Windows.Forms.Label secondsTextLabel;
        private System.Windows.Forms.Label centisecondsValueLabel;
        private OvalPictureBox toggleButton;
        private OvalPictureBox toggleButtonShadow;
        private System.Windows.Forms.Label resetLabel;
        private System.Windows.Forms.PictureBox resetIcon;
        private System.Windows.Forms.PictureBox resetButton;
        private System.Windows.Forms.PictureBox htlLogo;
        private System.Windows.Forms.ListView lapsView;
        private System.Windows.Forms.Label lapLabel;
        private System.Windows.Forms.PictureBox lapIcon;
        private System.Windows.Forms.PictureBox lapButton;
        private System.Windows.Forms.ColumnHeader lapsHeader;
        private System.Windows.Forms.ColumnHeader timeHeader;
        private System.Windows.Forms.ColumnHeader durationHeader;
    }
}

