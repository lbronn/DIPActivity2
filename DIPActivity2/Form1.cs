using System.ComponentModel;
using WebCamLib;

namespace DIPActivity2
{
    public partial class Form1 : Form
    {
        Bitmap image, background, output, webcamCapture;
        Device[] allWebcam;
        Device webcam;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            image = new Bitmap(openFileDialog1.FileName);

            pictureBox1.Image = image;
        }

        private void openBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog(this);
            background = new Bitmap(openFileDialog2.FileName);

            pictureBox2.Image = background;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image != null)
            {
                saveFileDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("There is no final output, cannot save.", "Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            output.Save(saveFileDialog1.FileName);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
            }
            else
            {
                MessageBox.Show("Picture Box 1 is already empty.", "Closing Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openWebcamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                allWebcam = DeviceManager.GetAllDevices();

                if (allWebcam.Length > 0)
                {
                    webcam = allWebcam[0];
                    webcam.ShowWindow(pictureBox4);
                }
                else
                {
                    MessageBox.Show("No webcam devices found.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error in initializing the webcam, please try again.", "Webcam Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void realtimeWebcamCaptureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(webcam == null)
            {
                MessageBox.Show("No webcam selected.", "Webcam Capturing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if(timer1.Enabled)
            //{
            //    timer1.Stop();
            //}
            //if(timer2.Enabled)
            //{
            //    timer2.Stop();
            //}

            //if(pictureBox6 != null && pictureBox6.Image != null)
            //{
            //    pictureBox6.Image.Dispose();
            //    background = null;
            //}

            //if(pictureBox3 != null && pictureBox3.Image != null)
            //{
            //    pictureBox3.Image.Dispose();
            //    pictureBox3.Image = null;
            //}

            try
            {
                background = CaptureAndDisplayImage();
                pictureBox6.Image = background;
            }
            catch(Exception)
            {
                MessageBox.Show("Please open the webcam first, if available.", "");
            }
        }

        private void webcamSubtractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (background == null || image == null)
            {
                MessageBox.Show("There is no webcam or background image available.", "Webcam Subtraction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (timer1.Enabled && pictureBox2 != null && pictureBox2.Image != null)
            {
                timer2.Start();
            }
            else
            {
                webcamSubtract(background);
            }
        }

        private void saveFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            webcamCapture.Save(saveFileDialog2.FileName);
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Image != null)
            {
                saveFileDialog2.ShowDialog();
            }
            else
            {
                MessageBox.Show("There is no captured webcam image, cannot save.", "Webcam Capture Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveFileDialog3_FileOk(object sender, CancelEventArgs e)
        {
            webcamCapture.Save(saveFileDialog3.FileName);
        }

        private void saveSubtractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image != null)
            {
                saveFileDialog3.ShowDialog();
            }
            else
            {
                MessageBox.Show("There is no subtracted webcam image, cannot save.", "Webcam Subtraction Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeWebcamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                allWebcam = DeviceManager.GetAllDevices();

                if (allWebcam.Length > 0)
                {
                    webcam = allWebcam[0];
                    webcam.Stop();
                }
                else
                {
                    MessageBox.Show("No webcam devices found.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error in closing the webcam, please try again.", "Webcam Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void basicCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            output = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < output.Width; i++)
            {
                for (int j = 0; j < output.Height; j++)
                {
                    Color imageColor = image.GetPixel(i, j);
                    output.SetPixel(i, j, imageColor);
                }
            }

            pictureBox3.Image = output;
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            output = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < output.Width; i++)
            {
                for (int j = 0; j < output.Height; j++)
                {
                    Color changeColor = image.GetPixel(i, j);
                    int gray = (int)(changeColor.R + changeColor.G + changeColor.B) / 3;
                    output.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }

            pictureBox3.Image = output;
        }

        private void colorInversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            output = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < output.Width; i++)
            {
                for (int j = 0; j < output.Height; j++)
                {
                    Color changeColor = image.GetPixel(i, j);
                    output.SetPixel(i, j, Color.FromArgb(255 - changeColor.R, 255 - changeColor.G, 255 - changeColor.B));
                }
            }

            pictureBox3.Image = output;
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            output = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < output.Width; i++)
            {
                for (int j = 0; j < output.Height; j++)
                {
                    Color changeColor = image.GetPixel(i, j);
                    int gray = (int)(changeColor.R + changeColor.G + changeColor.B) / 3;
                    output.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }

            int[] histogramData = new int[256];
            for (int i = 0; i < output.Width; i++)
            {
                for (int j = 0; j < output.Height; j++)
                {
                    Color greyscaleData = output.GetPixel(i, j);
                    histogramData[greyscaleData.R]++;
                }
            }

            Bitmap histogramGraph = new Bitmap(256, 800);
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 800; j++)
                {
                    histogramGraph.SetPixel(i, j, Color.White);
                }
            }

            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < Math.Min(histogramData[i] / 5, 800); j++)
                {
                    histogramGraph.SetPixel(i, j, Color.Black);
                }
            }

            pictureBox3.Image = histogramGraph;
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            output = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < output.Width; i++)
            {
                for (int j = 0; j < output.Height; j++)
                {
                    Color changeColor = image.GetPixel(i, j);
                    int red = (int)(changeColor.R);
                    int green = (int)(changeColor.G);
                    int blue = (int)(changeColor.B);
                    int sepiaRed = (int)((0.393 * red) + (0.769 * green) + (0.189 * blue));
                    int sepiaGreen = (int)((0.349 * red) + (0.686 * green) + (0.168 * blue));
                    int sepiaBlue = (int)((0.272 * red) + (0.534 * green) + (0.131 * blue));

                    if (sepiaRed > 255)
                    {
                        red = 255;
                    }
                    else
                    {
                        red = sepiaRed;
                    }

                    if (sepiaGreen > 255)
                    {
                        green = 255;
                    }
                    else
                    {
                        green = sepiaGreen;
                    }

                    if (sepiaBlue > 255)
                    {
                        blue = 255;
                    }
                    else
                    {
                        blue = sepiaBlue;
                    }

                    output.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }
            }

            pictureBox3.Image = output;
        }

        private void subtractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                output = new Bitmap(image.Width, image.Height);
                Color bgGreen = Color.FromArgb(0, 0, 255);
                int green = (int)(bgGreen.R + bgGreen.G + bgGreen.B) / 3;
                int greenThreshold = 10;

                for (int i = 0; i < image.Width; i++)
                {
                    for (int j = 0; j < image.Height; j++)
                    {
                        Color imageColor = image.GetPixel(i, j);
                        Color backgroundColor;
                        if (i <= background.Width && j <= background.Height)
                        {
                            backgroundColor = background.GetPixel(i, j);
                        }
                        else
                        {
                            backgroundColor = Color.Black;
                        }

                        int grey = (int)(imageColor.R + imageColor.G + imageColor.B) / 3;
                        int subtract = Math.Abs(grey - green);

                        if (subtract < greenThreshold)
                        {
                            output.SetPixel(i, j, backgroundColor);
                        }
                        else
                        {
                            output.SetPixel(i, j, imageColor);
                        }
                    }
                }
                pictureBox3.Image = output;
            }
            else
            {
                MessageBox.Show("There is no image in Picture Box 2, cannot use Subtraction as an image process.", "Image Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Additional functionalities
        public void webcamSubtract(Bitmap frame)
        {
            output = new Bitmap(image.Width, image.Height);
            Color bgGreen = Color.FromArgb(0, 0, 255);
            int green = (int)(bgGreen.R + bgGreen.G + bgGreen.B) / 3;
            int greenThreshold = 10;

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color imageColor = image.GetPixel(x, y);
                    Color backgroundColor = frame.GetPixel(x, y);
                    int grey = (int)(imageColor.R + imageColor.G + imageColor.B) / 3;
                    bool subtract = Math.Abs(grey - green) < greenThreshold;
                    if (subtract)
                        output.SetPixel(x, y, backgroundColor);
                    else
                        output.SetPixel(x, y, imageColor);
                }
            }
            pictureBox5.Image = output;
        }

        private Bitmap CaptureAndDisplayImage()
        {
            if (webcam == null)
            {
                MessageBox.Show("There is no webcam selected.", "Webcam Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            webcam.Sendmessage();
            IDataObject data = Clipboard.GetDataObject();
            if (data != null && data.GetData("System.Drawing.Bitmap", true) != null)
            {
                Image bmap = (Image)data.GetData("System.Drawing.Bitmap", true);
                if (bmap != null)
                {
                    return new Bitmap(bmap);
                }
            }
            return null;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (webcam != null)
            {
                background = CaptureAndDisplayImage();
                if (background != null)
                {
                    if (pictureBox2 != null && pictureBox2.Image != null)
                    {
                        pictureBox2.Image.Dispose();
                    }
                    pictureBox2.Image = background;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Bitmap newBmap = CaptureAndDisplayImage();
            if (newBmap != null)
            {
                webcamSubtract(newBmap);
            }
        }

        //private void WebcamProcessing(PictureBox pictureBox)
        //{
        //        webcam.Sendmessage();
        //        IDataObject data = Clipboard.GetDataObject();
        //        if(data != null && data.GetData("System.Drawing.Bitmap", true) != null )
        //        {
        //            Image bmap = (Image)data.GetData("System.Drawing.Bitmap", true);
        //            if(bmap != null )
        //            {
        //                Bitmap b = new Bitmap(bmap);
        //                if (pictureBox.Image  != null )
        //                {
        //                    pictureBox.Image.Dispose();
        //                }
        //            }
        //        }

        //}
    }
}