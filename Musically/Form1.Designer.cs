namespace Musically
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.r = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.mTrackPos = new XComponent.SliderBar.MACTrackBar();
            this.mTrackVolumen = new XComponent.SliderBar.MACTrackBar();
            this.lblCancion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 274);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(290, 43);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // r
            // 
            this.r.Enabled = true;
            this.r.Location = new System.Drawing.Point(12, 169);
            this.r.Name = "r";
            this.r.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("r.OcxState")));
            this.r.Size = new System.Drawing.Size(290, 50);
            this.r.TabIndex = 4;
            this.r.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.r_PlayStateChange);
            this.r.Enter += new System.EventHandler(this.r_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 447);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(218, 447);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(130, 447);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 49);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // mTrackPos
            // 
            this.mTrackPos.BackColor = System.Drawing.Color.Transparent;
            this.mTrackPos.BorderColor = System.Drawing.Color.OrangeRed;
            this.mTrackPos.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTrackPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mTrackPos.IndentHeight = 6;
            this.mTrackPos.Location = new System.Drawing.Point(12, 401);
            this.mTrackPos.Maximum = 100;
            this.mTrackPos.Minimum = 0;
            this.mTrackPos.Name = "mTrackPos";
            this.mTrackPos.Size = new System.Drawing.Size(271, 26);
            this.mTrackPos.TabIndex = 9;
            this.mTrackPos.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mTrackPos.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(35)))));
            this.mTrackPos.TickHeight = 4;
            this.mTrackPos.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mTrackPos.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(35)))));
            this.mTrackPos.TrackerSize = new System.Drawing.Size(14, 14);
            this.mTrackPos.TrackLineColor = System.Drawing.Color.Silver;
            this.mTrackPos.TrackLineHeight = 3;
            this.mTrackPos.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(35)))));
            this.mTrackPos.Value = 0;
            // 
            // mTrackVolumen
            // 
            this.mTrackVolumen.BackColor = System.Drawing.Color.Transparent;
            this.mTrackVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mTrackVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTrackVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mTrackVolumen.IndentHeight = 6;
            this.mTrackVolumen.Location = new System.Drawing.Point(289, 336);
            this.mTrackVolumen.Maximum = 100;
            this.mTrackVolumen.Minimum = 0;
            this.mTrackVolumen.Name = "mTrackVolumen";
            this.mTrackVolumen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.mTrackVolumen.Size = new System.Drawing.Size(22, 93);
            this.mTrackVolumen.TabIndex = 10;
            this.mTrackVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mTrackVolumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(35)))));
            this.mTrackVolumen.TickHeight = 4;
            this.mTrackVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mTrackVolumen.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(35)))));
            this.mTrackVolumen.TrackerSize = new System.Drawing.Size(10, 10);
            this.mTrackVolumen.TrackLineColor = System.Drawing.Color.Silver;
            this.mTrackVolumen.TrackLineHeight = 3;
            this.mTrackVolumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(35)))));
            this.mTrackVolumen.Value = 0;
            // 
            // lblCancion
            // 
            this.lblCancion.AutoSize = true;
            this.lblCancion.Location = new System.Drawing.Point(127, 81);
            this.lblCancion.Name = "lblCancion";
            this.lblCancion.Size = new System.Drawing.Size(13, 13);
            this.lblCancion.TabIndex = 11;
            this.lblCancion.Text = "--";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(315, 526);
            this.Controls.Add(this.lblCancion);
            this.Controls.Add(this.mTrackVolumen);
            this.Controls.Add(this.mTrackPos);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.r);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private AxWMPLib.AxWindowsMediaPlayer r;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private XComponent.SliderBar.MACTrackBar mTrackPos;
        private XComponent.SliderBar.MACTrackBar mTrackVolumen;
        private System.Windows.Forms.Label lblCancion;
        private System.Windows.Forms.Timer timer1;
    }
}

