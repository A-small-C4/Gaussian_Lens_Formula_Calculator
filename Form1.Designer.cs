namespace Gaussian_Lens_Formula_Calculator
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
            this.focalLengthTextBox = new System.Windows.Forms.TextBox();
            this.imageDistanceTextBox = new System.Windows.Forms.TextBox();
            this.focalLengthLabel = new System.Windows.Forms.Label();
            this.mmLabelA = new System.Windows.Forms.Label();
            this.objectDistanceLabel = new System.Windows.Forms.Label();
            this.imageDistanceLabel = new System.Windows.Forms.Label();
            this.mmLabelB = new System.Windows.Forms.Label();
            this.mmLabelD = new System.Windows.Forms.Label();
            this.plusLabel = new System.Windows.Forms.Label();
            this.focalLengthResultLabel = new System.Windows.Forms.Label();
            this.magnificationLabel = new System.Windows.Forms.Label();
            this.magnificationSymbolLabel = new System.Windows.Forms.Label();
            this.magnificationResultLabel = new System.Windows.Forms.Label();
            this.focalDistanceLabel = new System.Windows.Forms.Label();
            this.mmLabelC = new System.Windows.Forms.Label();
            this.objectDistanceTextBox = new System.Windows.Forms.TextBox();
            this.focalDistanceTextBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // focalLengthTextBox
            // 
            this.focalLengthTextBox.Font = new System.Drawing.Font("Lato", 12F);
            this.focalLengthTextBox.Location = new System.Drawing.Point(225, 8);
            this.focalLengthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.focalLengthTextBox.Name = "focalLengthTextBox";
            this.focalLengthTextBox.Size = new System.Drawing.Size(90, 27);
            this.focalLengthTextBox.TabIndex = 0;
            this.focalLengthTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.objectDistanceTextBox_KeyDown);
            // 
            // imageDistanceTextBox
            // 
            this.imageDistanceTextBox.Font = new System.Drawing.Font("Lato", 12F);
            this.imageDistanceTextBox.Location = new System.Drawing.Point(225, 107);
            this.imageDistanceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.imageDistanceTextBox.Name = "imageDistanceTextBox";
            this.imageDistanceTextBox.Size = new System.Drawing.Size(90, 27);
            this.imageDistanceTextBox.TabIndex = 6;
            this.imageDistanceTextBox.Text = "0";
            this.imageDistanceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.imageDistanceTextBox_KeyDown);
            // 
            // focalLengthLabel
            // 
            this.focalLengthLabel.AutoSize = true;
            this.focalLengthLabel.Font = new System.Drawing.Font("Lato", 12F);
            this.focalLengthLabel.Location = new System.Drawing.Point(14, 11);
            this.focalLengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.focalLengthLabel.Name = "focalLengthLabel";
            this.focalLengthLabel.Size = new System.Drawing.Size(101, 19);
            this.focalLengthLabel.TabIndex = 1;
            this.focalLengthLabel.Text = "Focal Length:";
            // 
            // mmLabelA
            // 
            this.mmLabelA.AutoSize = true;
            this.mmLabelA.Font = new System.Drawing.Font("Lato", 12F);
            this.mmLabelA.Location = new System.Drawing.Point(323, 11);
            this.mmLabelA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mmLabelA.Name = "mmLabelA";
            this.mmLabelA.Size = new System.Drawing.Size(35, 19);
            this.mmLabelA.TabIndex = 2;
            this.mmLabelA.Text = "mm";
            // 
            // objectDistanceLabel
            // 
            this.objectDistanceLabel.AutoSize = true;
            this.objectDistanceLabel.Font = new System.Drawing.Font("Lato", 12F);
            this.objectDistanceLabel.Location = new System.Drawing.Point(14, 45);
            this.objectDistanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.objectDistanceLabel.Name = "objectDistanceLabel";
            this.objectDistanceLabel.Size = new System.Drawing.Size(127, 19);
            this.objectDistanceLabel.TabIndex = 3;
            this.objectDistanceLabel.Text = "Object Distance:";
            // 
            // imageDistanceLabel
            // 
            this.imageDistanceLabel.AutoSize = true;
            this.imageDistanceLabel.Font = new System.Drawing.Font("Lato", 12F);
            this.imageDistanceLabel.Location = new System.Drawing.Point(14, 111);
            this.imageDistanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imageDistanceLabel.Name = "imageDistanceLabel";
            this.imageDistanceLabel.Size = new System.Drawing.Size(120, 19);
            this.imageDistanceLabel.TabIndex = 4;
            this.imageDistanceLabel.Text = "Image Distance:";
            // 
            // mmLabelB
            // 
            this.mmLabelB.AutoSize = true;
            this.mmLabelB.Font = new System.Drawing.Font("Lato", 12F);
            this.mmLabelB.Location = new System.Drawing.Point(323, 45);
            this.mmLabelB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mmLabelB.Name = "mmLabelB";
            this.mmLabelB.Size = new System.Drawing.Size(35, 19);
            this.mmLabelB.TabIndex = 7;
            this.mmLabelB.Text = "mm";
            // 
            // mmLabelD
            // 
            this.mmLabelD.AutoSize = true;
            this.mmLabelD.Font = new System.Drawing.Font("Lato", 12F);
            this.mmLabelD.Location = new System.Drawing.Point(323, 111);
            this.mmLabelD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mmLabelD.Name = "mmLabelD";
            this.mmLabelD.Size = new System.Drawing.Size(35, 19);
            this.mmLabelD.TabIndex = 8;
            this.mmLabelD.Text = "mm";
            // 
            // plusLabel
            // 
            this.plusLabel.AutoSize = true;
            this.plusLabel.Font = new System.Drawing.Font("Lato", 12F);
            this.plusLabel.Location = new System.Drawing.Point(201, 111);
            this.plusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plusLabel.Name = "plusLabel";
            this.plusLabel.Size = new System.Drawing.Size(18, 19);
            this.plusLabel.TabIndex = 9;
            this.plusLabel.Text = "+";
            // 
            // focalLengthResultLabel
            // 
            this.focalLengthResultLabel.AutoSize = true;
            this.focalLengthResultLabel.Font = new System.Drawing.Font("Lato", 12F);
            this.focalLengthResultLabel.Location = new System.Drawing.Point(141, 111);
            this.focalLengthResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.focalLengthResultLabel.Name = "focalLengthResultLabel";
            this.focalLengthResultLabel.Size = new System.Drawing.Size(18, 19);
            this.focalLengthResultLabel.TabIndex = 10;
            this.focalLengthResultLabel.Text = "0";
            // 
            // magnificationLabel
            // 
            this.magnificationLabel.AutoSize = true;
            this.magnificationLabel.Font = new System.Drawing.Font("Lato", 12F);
            this.magnificationLabel.Location = new System.Drawing.Point(13, 145);
            this.magnificationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.magnificationLabel.Name = "magnificationLabel";
            this.magnificationLabel.Size = new System.Drawing.Size(110, 19);
            this.magnificationLabel.TabIndex = 11;
            this.magnificationLabel.Text = "Magnification:";
            // 
            // magnificationSymbolLabel
            // 
            this.magnificationSymbolLabel.AutoSize = true;
            this.magnificationSymbolLabel.Font = new System.Drawing.Font("Lato", 12F);
            this.magnificationSymbolLabel.Location = new System.Drawing.Point(323, 145);
            this.magnificationSymbolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.magnificationSymbolLabel.Name = "magnificationSymbolLabel";
            this.magnificationSymbolLabel.Size = new System.Drawing.Size(17, 19);
            this.magnificationSymbolLabel.TabIndex = 12;
            this.magnificationSymbolLabel.Text = "x";
            // 
            // magnificationResultLabel
            // 
            this.magnificationResultLabel.AutoSize = true;
            this.magnificationResultLabel.Font = new System.Drawing.Font("Lato", 12F);
            this.magnificationResultLabel.Location = new System.Drawing.Point(225, 145);
            this.magnificationResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.magnificationResultLabel.Name = "magnificationResultLabel";
            this.magnificationResultLabel.Size = new System.Drawing.Size(18, 19);
            this.magnificationResultLabel.TabIndex = 13;
            this.magnificationResultLabel.Text = "0";
            // 
            // focalDistanceLabel
            // 
            this.focalDistanceLabel.AutoSize = true;
            this.focalDistanceLabel.Font = new System.Drawing.Font("Lato", 12F);
            this.focalDistanceLabel.Location = new System.Drawing.Point(14, 78);
            this.focalDistanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.focalDistanceLabel.Name = "focalDistanceLabel";
            this.focalDistanceLabel.Size = new System.Drawing.Size(116, 19);
            this.focalDistanceLabel.TabIndex = 14;
            this.focalDistanceLabel.Text = "Focal Distance:";
            // 
            // mmLabelC
            // 
            this.mmLabelC.AutoSize = true;
            this.mmLabelC.Font = new System.Drawing.Font("Lato", 12F);
            this.mmLabelC.Location = new System.Drawing.Point(323, 78);
            this.mmLabelC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mmLabelC.Name = "mmLabelC";
            this.mmLabelC.Size = new System.Drawing.Size(35, 19);
            this.mmLabelC.TabIndex = 16;
            this.mmLabelC.Text = "mm";
            // 
            // objectDistanceTextBox
            // 
            this.objectDistanceTextBox.Font = new System.Drawing.Font("Lato", 12F);
            this.objectDistanceTextBox.Location = new System.Drawing.Point(225, 41);
            this.objectDistanceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.objectDistanceTextBox.Name = "objectDistanceTextBox";
            this.objectDistanceTextBox.Size = new System.Drawing.Size(90, 27);
            this.objectDistanceTextBox.TabIndex = 5;
            this.objectDistanceTextBox.Text = "∞";
            this.objectDistanceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.objectDistanceTextBox_KeyDown);
            // 
            // focalDistanceTextBox
            // 
            this.focalDistanceTextBox.AutoSize = true;
            this.focalDistanceTextBox.Font = new System.Drawing.Font("Lato", 12F);
            this.focalDistanceTextBox.Location = new System.Drawing.Point(225, 78);
            this.focalDistanceTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.focalDistanceTextBox.Name = "focalDistanceTextBox";
            this.focalDistanceTextBox.Size = new System.Drawing.Size(21, 19);
            this.focalDistanceTextBox.TabIndex = 17;
            this.focalDistanceTextBox.Text = "∞";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 6F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(168, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 10);
            this.label1.TabIndex = 18;
            this.label1.Text = "github.com/A-small-C4/Gaussian_Lens_Formula_Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 181);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.focalDistanceTextBox);
            this.Controls.Add(this.focalDistanceLabel);
            this.Controls.Add(this.magnificationResultLabel);
            this.Controls.Add(this.magnificationSymbolLabel);
            this.Controls.Add(this.magnificationLabel);
            this.Controls.Add(this.focalLengthResultLabel);
            this.Controls.Add(this.plusLabel);
            this.Controls.Add(this.imageDistanceTextBox);
            this.Controls.Add(this.objectDistanceTextBox);
            this.Controls.Add(this.imageDistanceLabel);
            this.Controls.Add(this.objectDistanceLabel);
            this.Controls.Add(this.focalLengthLabel);
            this.Controls.Add(this.focalLengthTextBox);
            this.Controls.Add(this.mmLabelA);
            this.Controls.Add(this.mmLabelB);
            this.Controls.Add(this.mmLabelC);
            this.Controls.Add(this.mmLabelD);
            this.Font = new System.Drawing.Font("Lato", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Gaussian Lens Formula Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox focalLengthTextBox;
        private System.Windows.Forms.TextBox imageDistanceTextBox;
        private System.Windows.Forms.Label focalLengthLabel;
        private System.Windows.Forms.Label objectDistanceLabel;
        private System.Windows.Forms.Label imageDistanceLabel;
        private System.Windows.Forms.Label plusLabel;
        private System.Windows.Forms.Label focalLengthResultLabel;
        private System.Windows.Forms.Label magnificationLabel;
        private System.Windows.Forms.Label magnificationSymbolLabel;
        private System.Windows.Forms.Label magnificationResultLabel;
        private System.Windows.Forms.Label focalDistanceLabel;
        private System.Windows.Forms.Label mmLabelA;
        private System.Windows.Forms.Label mmLabelB;
        private System.Windows.Forms.Label mmLabelD;
        private System.Windows.Forms.Label mmLabelC;
        private System.Windows.Forms.TextBox objectDistanceTextBox;
        private System.Windows.Forms.Label focalDistanceTextBox;
        private System.Windows.Forms.Label label1;
    }
}

