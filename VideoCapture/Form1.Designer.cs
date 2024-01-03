namespace VideoCapture
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
            comboBoxWebCamList = new ComboBox();
            start = new Button();
            capture = new Button();
            SaveImage = new Button();
            Exit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBoxWebCamList
            // 
            comboBoxWebCamList.FormattingEnabled = true;
            comboBoxWebCamList.Location = new Point(23, 42);
            comboBoxWebCamList.Name = "comboBoxWebCamList";
            comboBoxWebCamList.Size = new Size(395, 40);
            comboBoxWebCamList.TabIndex = 0;
            // 
            // start
            // 
            start.Location = new Point(424, 33);
            start.Name = "start";
            start.Size = new Size(186, 49);
            start.TabIndex = 1;
            start.Text = "Start";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // capture
            // 
            capture.Location = new Point(616, 33);
            capture.Name = "capture";
            capture.Size = new Size(186, 49);
            capture.TabIndex = 2;
            capture.Text = "Capture";
            capture.UseVisualStyleBackColor = true;
            capture.Click += capture_Click;
            // 
            // SaveImage
            // 
            SaveImage.Location = new Point(808, 33);
            SaveImage.Name = "SaveImage";
            SaveImage.Size = new Size(186, 49);
            SaveImage.TabIndex = 3;
            SaveImage.Text = "Save Image";
            SaveImage.UseVisualStyleBackColor = true;
            SaveImage.Click += SaveImage_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(1146, 33);
            Exit.Name = "Exit";
            Exit.Size = new Size(186, 49);
            Exit.TabIndex = 4;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(23, 97);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1309, 688);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(648, 682);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(657, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(649, 682);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 806);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Exit);
            Controls.Add(SaveImage);
            Controls.Add(capture);
            Controls.Add(start);
            Controls.Add(comboBoxWebCamList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxWebCamList;
        private Button start;
        private Button capture;
        private Button SaveImage;
        private Button Exit;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}