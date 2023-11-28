namespace DIPActivity2
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            openBackgroundToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            webcamToolStripMenuItem = new ToolStripMenuItem();
            openWebcamToolStripMenuItem1 = new ToolStripMenuItem();
            realtimeWebcamCaptureToolStripMenuItem = new ToolStripMenuItem();
            webcamSubtractionToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem1 = new ToolStripMenuItem();
            closeWebcamToolStripMenuItem1 = new ToolStripMenuItem();
            imageProcessingToolStripMenuItem = new ToolStripMenuItem();
            basicCopyToolStripMenuItem = new ToolStripMenuItem();
            grayscaleToolStripMenuItem = new ToolStripMenuItem();
            colorInversionToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            sepiaToolStripMenuItem = new ToolStripMenuItem();
            subtractionToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog2 = new OpenFileDialog();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            saveFileDialog2 = new SaveFileDialog();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            saveFileDialog3 = new SaveFileDialog();
            saveSubtractionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, webcamToolStripMenuItem, imageProcessingToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1248, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, openBackgroundToolStripMenuItem, saveToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(211, 26);
            openToolStripMenuItem.Text = "Open Image";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // openBackgroundToolStripMenuItem
            // 
            openBackgroundToolStripMenuItem.Name = "openBackgroundToolStripMenuItem";
            openBackgroundToolStripMenuItem.Size = new Size(211, 26);
            openBackgroundToolStripMenuItem.Text = "Open Background";
            openBackgroundToolStripMenuItem.Click += openBackgroundToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(211, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(211, 26);
            closeToolStripMenuItem.Text = "Close Image";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // webcamToolStripMenuItem
            // 
            webcamToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openWebcamToolStripMenuItem1, realtimeWebcamCaptureToolStripMenuItem, webcamSubtractionToolStripMenuItem, saveSubtractionToolStripMenuItem, saveToolStripMenuItem1, closeWebcamToolStripMenuItem1 });
            webcamToolStripMenuItem.Name = "webcamToolStripMenuItem";
            webcamToolStripMenuItem.Size = new Size(85, 24);
            webcamToolStripMenuItem.Text = "Webcam ";
            // 
            // openWebcamToolStripMenuItem1
            // 
            openWebcamToolStripMenuItem1.Name = "openWebcamToolStripMenuItem1";
            openWebcamToolStripMenuItem1.Size = new Size(230, 26);
            openWebcamToolStripMenuItem1.Text = "Open Webcam";
            openWebcamToolStripMenuItem1.Click += openWebcamToolStripMenuItem1_Click;
            // 
            // realtimeWebcamCaptureToolStripMenuItem
            // 
            realtimeWebcamCaptureToolStripMenuItem.Name = "realtimeWebcamCaptureToolStripMenuItem";
            realtimeWebcamCaptureToolStripMenuItem.Size = new Size(230, 26);
            realtimeWebcamCaptureToolStripMenuItem.Text = "Webcam Capture";
            realtimeWebcamCaptureToolStripMenuItem.Click += realtimeWebcamCaptureToolStripMenuItem_Click;
            // 
            // webcamSubtractionToolStripMenuItem
            // 
            webcamSubtractionToolStripMenuItem.Name = "webcamSubtractionToolStripMenuItem";
            webcamSubtractionToolStripMenuItem.Size = new Size(230, 26);
            webcamSubtractionToolStripMenuItem.Text = "Webcam Subtraction";
            webcamSubtractionToolStripMenuItem.Click += webcamSubtractionToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.Size = new Size(230, 26);
            saveToolStripMenuItem1.Text = "Save Capture";
            saveToolStripMenuItem1.Click += saveToolStripMenuItem1_Click;
            // 
            // closeWebcamToolStripMenuItem1
            // 
            closeWebcamToolStripMenuItem1.Name = "closeWebcamToolStripMenuItem1";
            closeWebcamToolStripMenuItem1.Size = new Size(230, 26);
            closeWebcamToolStripMenuItem1.Text = "Close Webcam";
            closeWebcamToolStripMenuItem1.Click += closeWebcamToolStripMenuItem1_Click;
            // 
            // imageProcessingToolStripMenuItem
            // 
            imageProcessingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { basicCopyToolStripMenuItem, grayscaleToolStripMenuItem, colorInversionToolStripMenuItem, histogramToolStripMenuItem, sepiaToolStripMenuItem, subtractionToolStripMenuItem });
            imageProcessingToolStripMenuItem.Name = "imageProcessingToolStripMenuItem";
            imageProcessingToolStripMenuItem.Size = new Size(139, 24);
            imageProcessingToolStripMenuItem.Text = "Image Processing";
            // 
            // basicCopyToolStripMenuItem
            // 
            basicCopyToolStripMenuItem.Name = "basicCopyToolStripMenuItem";
            basicCopyToolStripMenuItem.Size = new Size(191, 26);
            basicCopyToolStripMenuItem.Text = "Basic Copy";
            basicCopyToolStripMenuItem.Click += basicCopyToolStripMenuItem_Click;
            // 
            // grayscaleToolStripMenuItem
            // 
            grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            grayscaleToolStripMenuItem.Size = new Size(191, 26);
            grayscaleToolStripMenuItem.Text = "Grayscale";
            grayscaleToolStripMenuItem.Click += grayscaleToolStripMenuItem_Click;
            // 
            // colorInversionToolStripMenuItem
            // 
            colorInversionToolStripMenuItem.Name = "colorInversionToolStripMenuItem";
            colorInversionToolStripMenuItem.Size = new Size(191, 26);
            colorInversionToolStripMenuItem.Text = "Color Inversion";
            colorInversionToolStripMenuItem.Click += colorInversionToolStripMenuItem_Click;
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(191, 26);
            histogramToolStripMenuItem.Text = "Histogram";
            histogramToolStripMenuItem.Click += histogramToolStripMenuItem_Click;
            // 
            // sepiaToolStripMenuItem
            // 
            sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            sepiaToolStripMenuItem.Size = new Size(191, 26);
            sepiaToolStripMenuItem.Text = "Sepia";
            sepiaToolStripMenuItem.Click += sepiaToolStripMenuItem_Click;
            // 
            // subtractionToolStripMenuItem
            // 
            subtractionToolStripMenuItem.Name = "subtractionToolStripMenuItem";
            subtractionToolStripMenuItem.Size = new Size(191, 26);
            subtractionToolStripMenuItem.Text = "Subtraction";
            subtractionToolStripMenuItem.Click += subtractionToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(25, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 388);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(430, 99);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(370, 388);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(845, 99);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(370, 388);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 66);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 4;
            label1.Text = "Image";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(447, 66);
            label2.Name = "label2";
            label2.Size = new Size(332, 20);
            label2.TabIndex = 5;
            label2.Text = "Background Image (for Subtraction Process only)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(966, 66);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 6;
            label3.Text = "Final Image Output";
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(25, 572);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(370, 388);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Menu;
            label4.Location = new Point(175, 540);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 8;
            label4.Text = "Webcam";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saveFileDialog2
            // 
            saveFileDialog2.FileOk += saveFileDialog2_FileOk;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.Control;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Location = new Point(430, 572);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(370, 388);
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Location = new Point(845, 572);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(370, 388);
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(932, 540);
            label5.Name = "label5";
            label5.Size = new Size(195, 20);
            label5.TabIndex = 11;
            label5.Text = "Webcam Real-Time Capture";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(485, 540);
            label6.Name = "label6";
            label6.Size = new Size(257, 20);
            label6.TabIndex = 12;
            label6.Text = "Webcam Subtraction Implementation";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // saveFileDialog3
            // 
            saveFileDialog3.FileOk += saveFileDialog3_FileOk;
            // 
            // saveSubtractionToolStripMenuItem
            // 
            saveSubtractionToolStripMenuItem.Name = "saveSubtractionToolStripMenuItem";
            saveSubtractionToolStripMenuItem.Size = new Size(230, 26);
            saveSubtractionToolStripMenuItem.Text = "Save Subtraction";
            saveSubtractionToolStripMenuItem.Click += saveSubtractionToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 987);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(label4);
            Controls.Add(pictureBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DIP Activity 2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem imageProcessingToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem openBackgroundToolStripMenuItem;
        private OpenFileDialog openFileDialog2;
        private ToolStripMenuItem subtractionToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private ToolStripMenuItem basicCopyToolStripMenuItem;
        private ToolStripMenuItem grayscaleToolStripMenuItem;
        private ToolStripMenuItem colorInversionToolStripMenuItem;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private ToolStripMenuItem sepiaToolStripMenuItem;
        private ToolStripMenuItem webcamToolStripMenuItem;
        private ToolStripMenuItem openWebcamToolStripMenuItem1;
        private ToolStripMenuItem closeWebcamToolStripMenuItem1;
        private PictureBox pictureBox4;
        private Label label4;
        private ToolStripMenuItem realtimeWebcamCaptureToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private SaveFileDialog saveFileDialog2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label5;
        private Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ToolStripMenuItem webcamSubtractionToolStripMenuItem;
        private SaveFileDialog saveFileDialog3;
        private ToolStripMenuItem saveSubtractionToolStripMenuItem;
    }
}
