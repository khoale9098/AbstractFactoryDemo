namespace AbstractFactory
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
            this.frameCreate = new System.Windows.Forms.GroupBox();
            this.lblPgrSeat = new System.Windows.Forms.Label();
            this.lblPgrEngine = new System.Windows.Forms.Label();
            this.lblPgrDoor = new System.Windows.Forms.Label();
            this.lblPgrFrame = new System.Windows.Forms.Label();
            this.lblPgrWheel = new System.Windows.Forms.Label();
            this.lblDoor = new System.Windows.Forms.Label();
            this.lblEngine = new System.Windows.Forms.Label();
            this.lblSeat = new System.Windows.Forms.Label();
            this.pgrDoor = new System.Windows.Forms.ProgressBar();
            this.pgrEngine = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFrame = new System.Windows.Forms.Label();
            this.pgrSeat = new System.Windows.Forms.ProgressBar();
            this.pgrWheel = new System.Windows.Forms.ProgressBar();
            this.lblWheel = new System.Windows.Forms.Label();
            this.pgrFrame = new System.Windows.Forms.ProgressBar();
            this.cmbCarTypes = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProduce = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picDoor = new System.Windows.Forms.PictureBox();
            this.picWheel = new System.Windows.Forms.PictureBox();
            this.picFrame = new System.Windows.Forms.PictureBox();
            this.picSeat = new System.Windows.Forms.PictureBox();
            this.picEngine = new System.Windows.Forms.PictureBox();
            this.frameCreate.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEngine)).BeginInit();
            this.SuspendLayout();
            // 
            // frameCreate
            // 
            this.frameCreate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.frameCreate.Controls.Add(this.panel6);
            this.frameCreate.Controls.Add(this.panel5);
            this.frameCreate.Controls.Add(this.panel4);
            this.frameCreate.Controls.Add(this.panel3);
            this.frameCreate.Controls.Add(this.panel2);
            this.frameCreate.Controls.Add(this.lblPgrSeat);
            this.frameCreate.Controls.Add(this.lblPgrEngine);
            this.frameCreate.Controls.Add(this.lblPgrDoor);
            this.frameCreate.Controls.Add(this.lblPgrFrame);
            this.frameCreate.Controls.Add(this.lblPgrWheel);
            this.frameCreate.Controls.Add(this.lblDoor);
            this.frameCreate.Controls.Add(this.lblEngine);
            this.frameCreate.Controls.Add(this.picDoor);
            this.frameCreate.Controls.Add(this.picWheel);
            this.frameCreate.Controls.Add(this.lblSeat);
            this.frameCreate.Controls.Add(this.pgrDoor);
            this.frameCreate.Controls.Add(this.picFrame);
            this.frameCreate.Controls.Add(this.pgrEngine);
            this.frameCreate.Controls.Add(this.label1);
            this.frameCreate.Controls.Add(this.lblFrame);
            this.frameCreate.Controls.Add(this.picSeat);
            this.frameCreate.Controls.Add(this.pgrSeat);
            this.frameCreate.Controls.Add(this.pgrWheel);
            this.frameCreate.Controls.Add(this.lblWheel);
            this.frameCreate.Controls.Add(this.pgrFrame);
            this.frameCreate.Controls.Add(this.picEngine);
            this.frameCreate.Location = new System.Drawing.Point(3, 94);
            this.frameCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frameCreate.Name = "frameCreate";
            this.frameCreate.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frameCreate.Size = new System.Drawing.Size(1201, 645);
            this.frameCreate.TabIndex = 11;
            this.frameCreate.TabStop = false;
            // 
            // lblPgrSeat
            // 
            this.lblPgrSeat.Location = new System.Drawing.Point(56, 494);
            this.lblPgrSeat.Name = "lblPgrSeat";
            this.lblPgrSeat.Size = new System.Drawing.Size(199, 27);
            this.lblPgrSeat.TabIndex = 10;
            this.lblPgrSeat.Text = "0 %";
            this.lblPgrSeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPgrEngine
            // 
            this.lblPgrEngine.Location = new System.Drawing.Point(945, 494);
            this.lblPgrEngine.Name = "lblPgrEngine";
            this.lblPgrEngine.Size = new System.Drawing.Size(199, 27);
            this.lblPgrEngine.TabIndex = 11;
            this.lblPgrEngine.Text = "0 %";
            this.lblPgrEngine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPgrDoor
            // 
            this.lblPgrDoor.Location = new System.Drawing.Point(53, 226);
            this.lblPgrDoor.Name = "lblPgrDoor";
            this.lblPgrDoor.Size = new System.Drawing.Size(203, 27);
            this.lblPgrDoor.TabIndex = 7;
            this.lblPgrDoor.Text = "0 %";
            this.lblPgrDoor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPgrFrame
            // 
            this.lblPgrFrame.Location = new System.Drawing.Point(945, 226);
            this.lblPgrFrame.Name = "lblPgrFrame";
            this.lblPgrFrame.Size = new System.Drawing.Size(200, 27);
            this.lblPgrFrame.TabIndex = 8;
            this.lblPgrFrame.Text = "0 %";
            this.lblPgrFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPgrWheel
            // 
            this.lblPgrWheel.Location = new System.Drawing.Point(507, 368);
            this.lblPgrWheel.Name = "lblPgrWheel";
            this.lblPgrWheel.Size = new System.Drawing.Size(203, 27);
            this.lblPgrWheel.TabIndex = 9;
            this.lblPgrWheel.Text = "0 %";
            this.lblPgrWheel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDoor
            // 
            this.lblDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoor.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblDoor.Location = new System.Drawing.Point(53, 30);
            this.lblDoor.Name = "lblDoor";
            this.lblDoor.Size = new System.Drawing.Size(203, 27);
            this.lblDoor.TabIndex = 6;
            this.lblDoor.Text = "Door";
            this.lblDoor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEngine
            // 
            this.lblEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngine.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblEngine.Location = new System.Drawing.Point(914, 299);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(263, 27);
            this.lblEngine.TabIndex = 6;
            this.lblEngine.Text = "Engine";
            this.lblEngine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat
            // 
            this.lblSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblSeat.Location = new System.Drawing.Point(53, 299);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(203, 27);
            this.lblSeat.TabIndex = 6;
            this.lblSeat.Text = "Seat";
            this.lblSeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgrDoor
            // 
            this.pgrDoor.Location = new System.Drawing.Point(56, 256);
            this.pgrDoor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pgrDoor.Name = "pgrDoor";
            this.pgrDoor.Size = new System.Drawing.Size(200, 23);
            this.pgrDoor.Step = 1;
            this.pgrDoor.TabIndex = 4;
            // 
            // pgrEngine
            // 
            this.pgrEngine.Location = new System.Drawing.Point(945, 534);
            this.pgrEngine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pgrEngine.Name = "pgrEngine";
            this.pgrEngine.Size = new System.Drawing.Size(200, 23);
            this.pgrEngine.Step = 1;
            this.pgrEngine.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // lblFrame
            // 
            this.lblFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrame.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblFrame.Location = new System.Drawing.Point(914, 30);
            this.lblFrame.Name = "lblFrame";
            this.lblFrame.Size = new System.Drawing.Size(263, 27);
            this.lblFrame.TabIndex = 6;
            this.lblFrame.Text = "Frame";
            this.lblFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgrSeat
            // 
            this.pgrSeat.Location = new System.Drawing.Point(56, 534);
            this.pgrSeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pgrSeat.Name = "pgrSeat";
            this.pgrSeat.Size = new System.Drawing.Size(200, 23);
            this.pgrSeat.Step = 1;
            this.pgrSeat.TabIndex = 4;
            // 
            // pgrWheel
            // 
            this.pgrWheel.ForeColor = System.Drawing.Color.Red;
            this.pgrWheel.Location = new System.Drawing.Point(510, 398);
            this.pgrWheel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pgrWheel.Name = "pgrWheel";
            this.pgrWheel.Size = new System.Drawing.Size(200, 23);
            this.pgrWheel.Step = 1;
            this.pgrWheel.TabIndex = 4;
            // 
            // lblWheel
            // 
            this.lblWheel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWheel.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblWheel.Location = new System.Drawing.Point(507, 172);
            this.lblWheel.Name = "lblWheel";
            this.lblWheel.Size = new System.Drawing.Size(203, 27);
            this.lblWheel.TabIndex = 6;
            this.lblWheel.Text = "Wheel";
            this.lblWheel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgrFrame
            // 
            this.pgrFrame.Location = new System.Drawing.Point(945, 256);
            this.pgrFrame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pgrFrame.Name = "pgrFrame";
            this.pgrFrame.Size = new System.Drawing.Size(200, 23);
            this.pgrFrame.Step = 1;
            this.pgrFrame.TabIndex = 4;
            // 
            // cmbCarTypes
            // 
            this.cmbCarTypes.BackColor = System.Drawing.Color.White;
            this.cmbCarTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarTypes.FormattingEnabled = true;
            this.cmbCarTypes.Location = new System.Drawing.Point(345, 28);
            this.cmbCarTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCarTypes.Name = "cmbCarTypes";
            this.cmbCarTypes.Size = new System.Drawing.Size(468, 24);
            this.cmbCarTypes.TabIndex = 9;
            this.cmbCarTypes.SelectedValueChanged += new System.EventHandler(this.cmbCarTypes_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmbCarTypes);
            this.panel1.Controls.Add(this.btnProduce);
            this.panel1.Location = new System.Drawing.Point(48, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 84);
            this.panel1.TabIndex = 12;
            // 
            // btnProduce
            // 
            this.btnProduce.BackColor = System.Drawing.Color.SeaGreen;
            this.btnProduce.Image = global::AbstractFactory.Properties.Resources.caidat;
            this.btnProduce.Location = new System.Drawing.Point(885, 10);
            this.btnProduce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProduce.Name = "btnProduce";
            this.btnProduce.Size = new System.Drawing.Size(112, 55);
            this.btnProduce.TabIndex = 8;
            this.btnProduce.UseVisualStyleBackColor = false;
            this.btnProduce.Click += new System.EventHandler(this.BtnProduce_Click);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::AbstractFactory.Properties.Resources.lift;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Location = new System.Drawing.Point(828, 106);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(89, 82);
            this.panel6.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::AbstractFactory.Properties.Resources.pistons;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(828, 375);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(89, 82);
            this.panel5.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::AbstractFactory.Properties.Resources.car_seat;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(285, 375);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(89, 82);
            this.panel4.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::AbstractFactory.Properties.Resources.car;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(285, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(89, 82);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::AbstractFactory.Properties.Resources.racing;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(560, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(89, 82);
            this.panel2.TabIndex = 12;
            // 
            // picDoor
            // 
            this.picDoor.Location = new System.Drawing.Point(56, 59);
            this.picDoor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picDoor.Name = "picDoor";
            this.picDoor.Size = new System.Drawing.Size(200, 160);
            this.picDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDoor.TabIndex = 2;
            this.picDoor.TabStop = false;
            // 
            // picWheel
            // 
            this.picWheel.Location = new System.Drawing.Point(510, 201);
            this.picWheel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picWheel.Name = "picWheel";
            this.picWheel.Size = new System.Drawing.Size(200, 160);
            this.picWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWheel.TabIndex = 2;
            this.picWheel.TabStop = false;
            // 
            // picFrame
            // 
            this.picFrame.Location = new System.Drawing.Point(945, 59);
            this.picFrame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picFrame.Name = "picFrame";
            this.picFrame.Size = new System.Drawing.Size(200, 160);
            this.picFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFrame.TabIndex = 2;
            this.picFrame.TabStop = false;
            // 
            // picSeat
            // 
            this.picSeat.Location = new System.Drawing.Point(56, 329);
            this.picSeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picSeat.Name = "picSeat";
            this.picSeat.Size = new System.Drawing.Size(200, 160);
            this.picSeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSeat.TabIndex = 2;
            this.picSeat.TabStop = false;
            // 
            // picEngine
            // 
            this.picEngine.Location = new System.Drawing.Point(945, 329);
            this.picEngine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picEngine.Name = "picEngine";
            this.picEngine.Size = new System.Drawing.Size(200, 160);
            this.picEngine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEngine.TabIndex = 2;
            this.picEngine.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1205, 750);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.frameCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Mô Phỏng Xe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.frameCreate.ResumeLayout(false);
            this.frameCreate.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEngine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox frameCreate;
        private System.Windows.Forms.Label lblPgrSeat;
        private System.Windows.Forms.Label lblPgrEngine;
        private System.Windows.Forms.Label lblPgrDoor;
        private System.Windows.Forms.Label lblPgrFrame;
        private System.Windows.Forms.Label lblPgrWheel;
        private System.Windows.Forms.Label lblDoor;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.PictureBox picDoor;
        private System.Windows.Forms.PictureBox picWheel;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.ProgressBar pgrDoor;
        private System.Windows.Forms.PictureBox picFrame;
        private System.Windows.Forms.ProgressBar pgrEngine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFrame;
        private System.Windows.Forms.PictureBox picSeat;
        private System.Windows.Forms.ProgressBar pgrSeat;
        private System.Windows.Forms.ProgressBar pgrWheel;
        private System.Windows.Forms.Label lblWheel;
        private System.Windows.Forms.ProgressBar pgrFrame;
        private System.Windows.Forms.PictureBox picEngine;
        private System.Windows.Forms.ComboBox cmbCarTypes;
        private System.Windows.Forms.Button btnProduce;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}

