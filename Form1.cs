using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gaussian_Lens_Formula_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string infinity = "∞";
        string zero = "0";

        private void objectDistanceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                focalLengthResultLabel.Text = focalLengthTextBox.Text;
                if (objectDistanceTextBox.Text == infinity)
                {
                    imageDistanceTextBox.Text = zero;
                    focalDistanceTextBox.Text = zero;
                    magnificationResultLabel.Text = zero;
                }
                else
                {
                    float focalLength;
                    float objectDistance;
                    float focalDistance;
                    float imageDistance = 0;
                    float magnification;
                    if (float.TryParse(focalLengthTextBox.Text, out focalLength) && float.TryParse(objectDistanceTextBox.Text, out objectDistance))
                    {
                        float temp = objectDistance - focalLength;
                        if (temp != 0)
                        {
                            imageDistance = (focalLength * objectDistance) / (objectDistance - focalLength) - focalLength;
                            imageDistanceTextBox.Text = imageDistance.ToString();
                        }
                        else
                            imageDistanceTextBox.Text = zero;
                        if (objectDistance == 0)
                            imageDistanceTextBox.Text = infinity;
                        else
                        {
                            magnification = (imageDistance + focalLength) / objectDistance;
                            magnificationResultLabel.Text = magnification.ToString();
                        }
                        focalDistance = objectDistance + imageDistance + focalLength;
                        focalDistanceTextBox.Text = focalDistance.ToString();
                    }
                }
            }
        }

        private void imageDistanceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                focalLengthResultLabel.Text = focalLengthTextBox.Text;
                float focalLength;
                float objectDistance = 0;
                float focalDistance = 0;
                float imageDistance;
                float magnification;
                if (float.TryParse(focalLengthTextBox.Text, out focalLength) && float.TryParse(imageDistanceTextBox.Text, out imageDistance))
                {
                    if (imageDistance != 0)
                    {
                        objectDistance = (focalLength * (imageDistance + focalLength)) / imageDistance;
                        focalDistance = objectDistance + imageDistance + focalLength;
                        objectDistanceTextBox.Text = objectDistance.ToString();
                        focalDistanceTextBox.Text = focalDistance.ToString();
                    }
                    else
                    {
                        objectDistanceTextBox.Text = infinity;
                        focalDistanceTextBox.Text = infinity;
                    }
                    if (objectDistance == 0)
                        imageDistanceTextBox.Text = infinity;
                    else
                    {
                        magnification = (imageDistance + focalLength) / objectDistance;
                        magnificationResultLabel.Text = magnification.ToString();
                    }
                }
            }
        }
    }
}
