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
            this.label8 = new System.Windows.Forms.Label();
            this.frameCreate = new System.Windows.Forms.GroupBox();
            this.lblPgrSeat = new System.Windows.Forms.Label();
            this.lblPgrEngine = new System.Windows.Forms.Label();
            this.lblPgrDoor = new System.Windows.Forms.Label();
            this.lblPgrFrame = new System.Windows.Forms.Label();
            this.lblPgrWheel = new System.Windows.Forms.Label();
            this.lblDoor = new System.Windows.Forms.Label();
            this.lblEngine = new System.Windows.Forms.Label();
            this.picDoor = new System.Windows.Forms.PictureBox();
            this.picWheel = new System.Windows.Forms.PictureBox();
            this.lblSeat = new System.Windows.Forms.Label();
            this.pgrDoor = new System.Windows.Forms.ProgressBar();
            this.picFrame = new System.Windows.Forms.PictureBox();
            this.pgrEngine = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFrame = new System.Windows.Forms.Label();
            this.picSeat = new System.Windows.Forms.PictureBox();
            this.pgrSeat = new System.Windows.Forms.ProgressBar();
            this.pgrWheel = new System.Windows.Forms.ProgressBar();
            this.lblWheel = new System.Windows.Forms.Label();
            this.pgrFrame = new System.Windows.Forms.ProgressBar();
            this.picEngine = new System.Windows.Forms.PictureBox();
            this.cmbCarTypes = new System.Windows.Forms.ComboBox();
            this.btnProduce = new System.Windows.Forms.Button();
            this.frameCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEngine)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(233, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 27);
            this.label8.TabIndex = 10;
            this.label8.Text = "Chọn loại xe";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frameCreate
            // 
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
            this.frameCreate.Location = new System.Drawing.Point(16, 59);
            this.frameCreate.Name = "frameCreate";
            this.frameCreate.Size = new System.Drawing.Size(1190, 573);
            this.frameCreate.TabIndex = 11;
            this.frameCreate.TabStop = false;
            this.frameCreate.Text = "Chế tạo";
            // 
            // lblPgrSeat
            // 
            this.lblPgrSeat.Location = new System.Drawing.Point(135, 494);
            this.lblPgrSeat.Name = "lblPgrSeat";
            this.lblPgrSeat.Size = new System.Drawing.Size(199, 27);
            this.lblPgrSeat.TabIndex = 10;
            this.lblPgrSeat.Text = "0 %";
            this.lblPgrSeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPgrEngine
            // 
            this.lblPgrEngine.Location = new System.Drawing.Point(904, 494);
            this.lblPgrEngine.Name = "lblPgrEngine";
            this.lblPgrEngine.Size = new System.Drawing.Size(199, 27);
            this.lblPgrEngine.TabIndex = 11;
            this.lblPgrEngine.Text = "0 %";
            this.lblPgrEngine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPgrDoor
            // 
            this.lblPgrDoor.Location = new System.Drawing.Point(132, 226);
            this.lblPgrDoor.Name = "lblPgrDoor";
            this.lblPgrDoor.Size = new System.Drawing.Size(203, 27);
            this.lblPgrDoor.TabIndex = 7;
            this.lblPgrDoor.Text = "0 %";
            this.lblPgrDoor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPgrFrame
            // 
            this.lblPgrFrame.Location = new System.Drawing.Point(904, 226);
            this.lblPgrFrame.Name = "lblPgrFrame";
            this.lblPgrFrame.Size = new System.Drawing.Size(200, 27);
            this.lblPgrFrame.TabIndex = 8;
            this.lblPgrFrame.Text = "0 %";
            this.lblPgrFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPgrWheel
            // 
            this.lblPgrWheel.Location = new System.Drawing.Point(509, 226);
            this.lblPgrWheel.Name = "lblPgrWheel";
            this.lblPgrWheel.Size = new System.Drawing.Size(203, 27);
            this.lblPgrWheel.TabIndex = 9;
            this.lblPgrWheel.Text = "0 %";
            this.lblPgrWheel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDoor
            // 
            this.lblDoor.Location = new System.Drawing.Point(132, 29);
            this.lblDoor.Name = "lblDoor";
            this.lblDoor.Size = new System.Drawing.Size(203, 27);
            this.lblDoor.TabIndex = 6;
            this.lblDoor.Text = "Cửa";
            this.lblDoor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEngine
            // 
            this.lblEngine.Location = new System.Drawing.Point(873, 299);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(263, 27);
            this.lblEngine.TabIndex = 6;
            this.lblEngine.Text = "Động cơ";
            this.lblEngine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picDoor
            // 
            this.picDoor.Location = new System.Drawing.Point(135, 59);
            this.picDoor.Name = "picDoor";
            this.picDoor.Size = new System.Drawing.Size(200, 160);
            this.picDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDoor.TabIndex = 2;
            this.picDoor.TabStop = false;
            // 
            // picWheel
            // 
            this.picWheel.Location = new System.Drawing.Point(512, 59);
            this.picWheel.Name = "picWheel";
            this.picWheel.Size = new System.Drawing.Size(200, 160);
            this.picWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWheel.TabIndex = 2;
            this.picWheel.TabStop = false;
            // 
            // lblSeat
            // 
            this.lblSeat.Location = new System.Drawing.Point(132, 299);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(203, 27);
            this.lblSeat.TabIndex = 6;
            this.lblSeat.Text = "Ghế";
            this.lblSeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgrDoor
            // 
            this.pgrDoor.Location = new System.Drawing.Point(135, 256);
            this.pgrDoor.Name = "pgrDoor";
            this.pgrDoor.Size = new System.Drawing.Size(200, 23);
            this.pgrDoor.Step = 1;
            this.pgrDoor.TabIndex = 4;
            // 
            // picFrame
            // 
            this.picFrame.Location = new System.Drawing.Point(904, 59);
            this.picFrame.Name = "picFrame";
            this.picFrame.Size = new System.Drawing.Size(200, 160);
            this.picFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFrame.TabIndex = 2;
            this.picFrame.TabStop = false;
            // 
            // pgrEngine
            // 
            this.pgrEngine.Location = new System.Drawing.Point(904, 534);
            this.pgrEngine.Name = "pgrEngine";
            this.pgrEngine.Size = new System.Drawing.Size(200, 23);
            this.pgrEngine.Step = 1;
            this.pgrEngine.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // lblFrame
            // 
            this.lblFrame.Location = new System.Drawing.Point(873, 29);
            this.lblFrame.Name = "lblFrame";
            this.lblFrame.Size = new System.Drawing.Size(263, 27);
            this.lblFrame.TabIndex = 6;
            this.lblFrame.Text = "Khung thân";
            this.lblFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picSeat
            // 
            this.picSeat.Location = new System.Drawing.Point(135, 329);
            this.picSeat.Name = "picSeat";
            this.picSeat.Size = new System.Drawing.Size(200, 160);
            this.picSeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSeat.TabIndex = 2;
            this.picSeat.TabStop = false;
            // 
            // pgrSeat
            // 
            this.pgrSeat.Location = new System.Drawing.Point(135, 534);
            this.pgrSeat.Name = "pgrSeat";
            this.pgrSeat.Size = new System.Drawing.Size(200, 23);
            this.pgrSeat.Step = 1;
            this.pgrSeat.TabIndex = 4;
            // 
            // pgrWheel
            // 
            this.pgrWheel.Location = new System.Drawing.Point(512, 256);
            this.pgrWheel.Name = "pgrWheel";
            this.pgrWheel.Size = new System.Drawing.Size(200, 23);
            this.pgrWheel.Step = 1;
            this.pgrWheel.TabIndex = 4;
            // 
            // lblWheel
            // 
            this.lblWheel.Location = new System.Drawing.Point(509, 29);
            this.lblWheel.Name = "lblWheel";
            this.lblWheel.Size = new System.Drawing.Size(203, 27);
            this.lblWheel.TabIndex = 6;
            this.lblWheel.Text = "Bánh xe";
            this.lblWheel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgrFrame
            // 
            this.pgrFrame.Location = new System.Drawing.Point(904, 256);
            this.pgrFrame.Name = "pgrFrame";
            this.pgrFrame.Size = new System.Drawing.Size(200, 23);
            this.pgrFrame.Step = 1;
            this.pgrFrame.TabIndex = 4;
            // 
            // picEngine
            // 
            this.picEngine.Location = new System.Drawing.Point(904, 329);
            this.picEngine.Name = "picEngine";
            this.picEngine.Size = new System.Drawing.Size(200, 160);
            this.picEngine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEngine.TabIndex = 2;
            this.picEngine.TabStop = false;
            // 
            // cmbCarTypes
            // 
            this.cmbCarTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarTypes.FormattingEnabled = true;
            this.cmbCarTypes.Location = new System.Drawing.Point(468, 25);
            this.cmbCarTypes.Name = "cmbCarTypes";
            this.cmbCarTypes.Size = new System.Drawing.Size(289, 24);
            this.cmbCarTypes.TabIndex = 9;
            // 
            // btnProduce
            // 
            this.btnProduce.Location = new System.Drawing.Point(855, 19);
            this.btnProduce.Name = "btnProduce";
            this.btnProduce.Size = new System.Drawing.Size(75, 34);
            this.btnProduce.TabIndex = 8;
            this.btnProduce.Text = "Chế tạo";
            this.btnProduce.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 657);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.frameCreate);
            this.Controls.Add(this.cmbCarTypes);
            this.Controls.Add(this.btnProduce);
            this.Name = "Form1";
            this.Text = "Mô Phỏng Xe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.frameCreate.ResumeLayout(false);
            this.frameCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEngine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
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
    }
}

