using WebCamLib;

namespace DIPActivity2
{
    public partial class Form1 : Form
    {
        Bitmap image, background, output;
        Device firstDevice;

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
            Close();
        }

        private void openWebcamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Device[] allDevices = DeviceManager.GetAllDevices();

                if (allDevices.Length > 0)
                {
                    firstDevice = allDevices[0];
                    firstDevice.ShowWindow(pictureBox1);
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

        private void closeWebcamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Device[] allDevices = DeviceManager.GetAllDevices();

                if (allDevices.Length > 0)
                {
                    Device firstDevice = allDevices[0];
                    firstDevice.Stop();
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
                        Color backgroundColor = background.GetPixel(i, j);
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
    }
}