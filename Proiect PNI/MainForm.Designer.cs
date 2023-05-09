namespace ProiectPNI
{
    partial class MainForm
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
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.pnlFilterControls = new System.Windows.Forms.Panel();
            this.lblRedValue = new System.Windows.Forms.Label();
            this.lblGreenValue = new System.Windows.Forms.Label();
            this.lblBlueValue = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.trcRed = new System.Windows.Forms.TrackBar();
            this.trcGreen = new System.Windows.Forms.TrackBar();
            this.trcBlue = new System.Windows.Forms.TrackBar();
            this.btnOpenOriginal = new System.Windows.Forms.Button();
            this.btnSaveNewImage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblContrastValue = new System.Windows.Forms.Label();
            this.lblContrast = new System.Windows.Forms.Label();
            this.GreyScale = new System.Windows.Forms.Button();
            this.btn_blur = new System.Windows.Forms.Button();
            this.btn_sepia = new System.Windows.Forms.Button();
            this.btn_negative = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.pnlFilterControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBlue)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.MistyRose;
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picPreview.Location = new System.Drawing.Point(636, 10);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(400, 400);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 13;
            this.picPreview.TabStop = false;
            // 
            // pnlFilterControls
            // 
            this.pnlFilterControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilterControls.Controls.Add(this.lblRedValue);
            this.pnlFilterControls.Controls.Add(this.lblGreenValue);
            this.pnlFilterControls.Controls.Add(this.lblBlueValue);
            this.pnlFilterControls.Controls.Add(this.lblRed);
            this.pnlFilterControls.Controls.Add(this.lblGreen);
            this.pnlFilterControls.Controls.Add(this.lblBlue);
            this.pnlFilterControls.Controls.Add(this.trcRed);
            this.pnlFilterControls.Controls.Add(this.trcGreen);
            this.pnlFilterControls.Controls.Add(this.trcBlue);
            this.pnlFilterControls.Location = new System.Drawing.Point(12, 49);
            this.pnlFilterControls.Name = "pnlFilterControls";
            this.pnlFilterControls.Size = new System.Drawing.Size(200, 388);
            this.pnlFilterControls.TabIndex = 14;
            this.pnlFilterControls.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFilterControls_Paint);
            // 
            // lblRedValue
            // 
            this.lblRedValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedValue.Location = new System.Drawing.Point(137, 8);
            this.lblRedValue.Name = "lblRedValue";
            this.lblRedValue.Size = new System.Drawing.Size(58, 30);
            this.lblRedValue.TabIndex = 24;
            this.lblRedValue.Text = "0";
            this.lblRedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGreenValue
            // 
            this.lblGreenValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreenValue.Location = new System.Drawing.Point(61, 8);
            this.lblGreenValue.Name = "lblGreenValue";
            this.lblGreenValue.Size = new System.Drawing.Size(70, 30);
            this.lblGreenValue.TabIndex = 23;
            this.lblGreenValue.Text = "0";
            this.lblGreenValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlueValue
            // 
            this.lblBlueValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueValue.Location = new System.Drawing.Point(3, 8);
            this.lblBlueValue.Name = "lblBlueValue";
            this.lblBlueValue.Size = new System.Drawing.Size(55, 30);
            this.lblBlueValue.TabIndex = 22;
            this.lblBlueValue.Text = "0";
            this.lblBlueValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRed
            // 
            this.lblRed.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.Location = new System.Drawing.Point(137, 357);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(58, 30);
            this.lblRed.TabIndex = 21;
            this.lblRed.Text = "Red";
            this.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGreen
            // 
            this.lblGreen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.Location = new System.Drawing.Point(65, 357);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(70, 30);
            this.lblGreen.TabIndex = 20;
            this.lblGreen.Text = "Green";
            this.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlue
            // 
            this.lblBlue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.Location = new System.Drawing.Point(4, 357);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(55, 30);
            this.lblBlue.TabIndex = 19;
            this.lblBlue.Text = "Blue";
            this.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBlue.Click += new System.EventHandler(this.LblBlue_Click);
            // 
            // trcRed
            // 
            this.trcRed.AutoSize = false;
            this.trcRed.BackColor = System.Drawing.Color.RosyBrown;
            this.trcRed.Location = new System.Drawing.Point(141, 48);
            this.trcRed.Maximum = 255;
            this.trcRed.Name = "trcRed";
            this.trcRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcRed.Size = new System.Drawing.Size(23, 309);
            this.trcRed.TabIndex = 18;
            this.trcRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcRed.ValueChanged += new System.EventHandler(this.ColourComponentValueChangedEventHandler);
            // 
            // trcGreen
            // 
            this.trcGreen.AutoSize = false;
            this.trcGreen.BackColor = System.Drawing.Color.RosyBrown;
            this.trcGreen.Location = new System.Drawing.Point(87, 45);
            this.trcGreen.Maximum = 255;
            this.trcGreen.Name = "trcGreen";
            this.trcGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcGreen.Size = new System.Drawing.Size(23, 309);
            this.trcGreen.TabIndex = 17;
            this.trcGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcGreen.ValueChanged += new System.EventHandler(this.ColourComponentValueChangedEventHandler);
            // 
            // trcBlue
            // 
            this.trcBlue.AutoSize = false;
            this.trcBlue.BackColor = System.Drawing.Color.RosyBrown;
            this.trcBlue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.trcBlue.Location = new System.Drawing.Point(25, 45);
            this.trcBlue.Maximum = 255;
            this.trcBlue.Name = "trcBlue";
            this.trcBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcBlue.Size = new System.Drawing.Size(23, 309);
            this.trcBlue.TabIndex = 16;
            this.trcBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcBlue.ValueChanged += new System.EventHandler(this.ColourComponentValueChangedEventHandler);
            // 
            // btnOpenOriginal
            // 
            this.btnOpenOriginal.BackColor = System.Drawing.Color.RosyBrown;
            this.btnOpenOriginal.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenOriginal.Location = new System.Drawing.Point(655, 420);
            this.btnOpenOriginal.Name = "btnOpenOriginal";
            this.btnOpenOriginal.Size = new System.Drawing.Size(149, 46);
            this.btnOpenOriginal.TabIndex = 15;
            this.btnOpenOriginal.Text = "Load Image";
            this.btnOpenOriginal.UseVisualStyleBackColor = false;
            this.btnOpenOriginal.Click += new System.EventHandler(this.btnOpenOriginal_Click);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSaveNewImage.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewImage.Location = new System.Drawing.Point(843, 420);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(171, 46);
            this.btnSaveNewImage.TabIndex = 16;
            this.btnSaveNewImage.Text = "Save Image";
            this.btnSaveNewImage.UseVisualStyleBackColor = false;
            this.btnSaveNewImage.Click += new System.EventHandler(this.btnSaveNewImage_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.lblContrastValue);
            this.panel1.Location = new System.Drawing.Point(231, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 388);
            this.panel1.TabIndex = 17;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(53, 44);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 309);
            this.trackBar1.TabIndex = 18;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblContrastValue
            // 
            this.lblContrastValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrastValue.Location = new System.Drawing.Point(10, 356);
            this.lblContrastValue.Name = "lblContrastValue";
            this.lblContrastValue.Size = new System.Drawing.Size(131, 23);
            this.lblContrastValue.TabIndex = 24;
            this.lblContrastValue.Text = "0";
            this.lblContrastValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContrast
            // 
            this.lblContrast.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrast.Location = new System.Drawing.Point(242, 9);
            this.lblContrast.Name = "lblContrast";
            this.lblContrast.Size = new System.Drawing.Size(134, 30);
            this.lblContrast.TabIndex = 25;
            this.lblContrast.Text = "Contrast";
            this.lblContrast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblContrast.Click += new System.EventHandler(this.LblContrast_Click);
            // 
            // GreyScale
            // 
            this.GreyScale.BackColor = System.Drawing.Color.RosyBrown;
            this.GreyScale.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreyScale.Location = new System.Drawing.Point(57, 466);
            this.GreyScale.Name = "GreyScale";
            this.GreyScale.Size = new System.Drawing.Size(120, 29);
            this.GreyScale.TabIndex = 21;
            this.GreyScale.Text = "GreyScale";
            this.GreyScale.UseVisualStyleBackColor = false;
            this.GreyScale.Click += new System.EventHandler(this.GreyScale_Click);
            // 
            // btn_blur
            // 
            this.btn_blur.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_blur.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_blur.Location = new System.Drawing.Point(324, 466);
            this.btn_blur.Name = "btn_blur";
            this.btn_blur.Size = new System.Drawing.Size(105, 29);
            this.btn_blur.TabIndex = 20;
            this.btn_blur.Text = "Blur";
            this.btn_blur.UseVisualStyleBackColor = false;
            this.btn_blur.Click += new System.EventHandler(this.btn_blur_Click);
            // 
            // btn_sepia
            // 
            this.btn_sepia.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_sepia.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sepia.Location = new System.Drawing.Point(454, 466);
            this.btn_sepia.Name = "btn_sepia";
            this.btn_sepia.Size = new System.Drawing.Size(105, 29);
            this.btn_sepia.TabIndex = 19;
            this.btn_sepia.Text = "Sepia";
            this.btn_sepia.UseVisualStyleBackColor = false;
            this.btn_sepia.Click += new System.EventHandler(this.btn_sepia_Click);
            // 
            // btn_negative
            // 
            this.btn_negative.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_negative.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_negative.Location = new System.Drawing.Point(201, 466);
            this.btn_negative.Name = "btn_negative";
            this.btn_negative.Size = new System.Drawing.Size(100, 29);
            this.btn_negative.TabIndex = 18;
            this.btn_negative.Text = "Negative";
            this.btn_negative.UseVisualStyleBackColor = false;
            this.btn_negative.Click += new System.EventHandler(this.btn_negative_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(767, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 29);
            this.button1.TabIndex = 22;
            this.button1.Text = "RESET IMAGE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.trackBar2);
            this.panel2.Controls.Add(this.trackBar3);
            this.panel2.Controls.Add(this.trackBar4);
            this.panel2.Location = new System.Drawing.Point(395, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 388);
            this.panel2.TabIndex = 23;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 30);
            this.label4.TabIndex = 21;
            this.label4.Text = "Red";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 30);
            this.label5.TabIndex = 20;
            this.label5.Text = "Green";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 30);
            this.label6.TabIndex = 19;
            this.label6.Text = "Blue";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.BackColor = System.Drawing.Color.RosyBrown;
            this.trackBar2.Location = new System.Drawing.Point(150, 45);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(23, 309);
            this.trackBar2.TabIndex = 18;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.ValueChanged += new System.EventHandler(this.ColourSolariseComponentValueChangedEventHandler);
            // 
            // trackBar3
            // 
            this.trackBar3.AutoSize = false;
            this.trackBar3.BackColor = System.Drawing.Color.RosyBrown;
            this.trackBar3.Location = new System.Drawing.Point(87, 45);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(23, 309);
            this.trackBar3.TabIndex = 17;
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar3.ValueChanged += new System.EventHandler(this.ColourSolariseComponentValueChangedEventHandler);
            // 
            // trackBar4
            // 
            this.trackBar4.AutoSize = false;
            this.trackBar4.BackColor = System.Drawing.Color.RosyBrown;
            this.trackBar4.Location = new System.Drawing.Point(25, 45);
            this.trackBar4.Maximum = 255;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar4.Size = new System.Drawing.Size(23, 309);
            this.trackBar4.TabIndex = 16;
            this.trackBar4.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            this.trackBar4.ValueChanged += new System.EventHandler(this.ColourSolariseComponentValueChangedEventHandler);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 27);
            this.label7.TabIndex = 24;
            this.label7.Text = "Color Balance";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(449, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 27);
            this.label8.TabIndex = 25;
            this.label8.Text = "Solarise";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(274, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 23);
            this.label9.TabIndex = 28;
            this.label9.Text = "Filtre";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1048, 513);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblContrast);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GreyScale);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_blur);
            this.Controls.Add(this.btn_sepia);
            this.Controls.Add(this.btnOpenOriginal);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.pnlFilterControls);
            this.Controls.Add(this.btn_negative);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de imagine";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.pnlFilterControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trcRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBlue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Panel pnlFilterControls;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.TrackBar trcRed;
        private System.Windows.Forms.TrackBar trcGreen;
        private System.Windows.Forms.TrackBar trcBlue;
        private System.Windows.Forms.Label lblRedValue;
        private System.Windows.Forms.Label lblGreenValue;
        private System.Windows.Forms.Label lblBlueValue;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblContrast;
        private System.Windows.Forms.Label lblContrastValue;
        private System.Windows.Forms.Button GreyScale;
        private System.Windows.Forms.Button btn_blur;
        private System.Windows.Forms.Button btn_sepia;
        private System.Windows.Forms.Button btn_negative;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

