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
            this.label8.Location = new System.Drawing.Point(175, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 22);
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
            this.frameCreate.Location = new System.Drawing.Point(12, 48);
            this.frameCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.frameCreate.Name = "frameCreate";
            this.frameCreate.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.frameCreate.Size = new System.Drawing.Size(892, 466);
            this.frameCreate.TabIndex = 11;
            this.frameCreate.TabStop = false;
            this.frameCreate.Text = "Chế tạo";
            // 
            // lblPgrSeat
            // 
            this.lblPgrSeat.Location = new System.Drawing.Point(101, 401);
            this.lblPgrSeat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPgrSeat.Name = "lblPgrSeat";
            this.lblPgrSeat.Size = new System.Drawing.Size(149, 22);
            this.lblPgrSeat.TabIndex = 10;
            this.lblPgrSeat.Text = "0 %";
            this.lblPgrSeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPgrEngine
            // 
            this.lblPgrEngine.Location = new System.Drawing.Point(678, 401);
            this.lblPgrEngine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPgrEngine.Name = "lblPgrEngine";
            this.lblPgrEngine.Size = new System.Drawing.Size(149, 22);
            this.lblPgrEngine.TabIndex = 11;
            this.lblPgrEngine.Text = "0 %";
            this.lblPgrEngine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPgrDoor
            // 
            this.lblPgrDoor.Location = new System.Drawing.Point(99, 184);
            this.lblPgrDoor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPgrDoor.Name = "lblPgrDoor";
            this.lblPgrDoor.Size = new System.Drawing.Size(152, 22);
            this.lblPgrDoor.TabIndex = 7;
            this.lblPgrDoor.Text = "0 %";
            this.lblPgrDoor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPgrFrame
            // 
            this.lblPgrFrame.Location = new System.Drawing.Point(678, 184);
            this.lblPgrFrame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPgrFrame.Name = "lblPgrFrame";
            this.lblPgrFrame.Size = new System.Drawing.Size(150, 22);
            this.lblPgrFrame.TabIndex = 8;
            this.lblPgrFrame.Text = "0 %";
            this.lblPgrFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPgrWheel
            // 
            this.lblPgrWheel.Location = new System.Drawing.Point(382, 184);
            this.lblPgrWheel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPgrWheel.Name = "lblPgrWheel";
            this.lblPgrWheel.Size = new System.Drawing.Size(152, 22);
            this.lblPgrWheel.TabIndex = 9;
            this.lblPgrWheel.Text = "0 %";
            this.lblPgrWheel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDoor
            // 
            this.lblDoor.Location = new System.Drawing.Point(99, 24);
            this.lblDoor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoor.Name = "lblDoor";
            this.lblDoor.Size = new System.Drawing.Size(152, 22);
            this.lblDoor.TabIndex = 6;
            this.lblDoor.Text = "Cửa";
            this.lblDoor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEngine
            // 
            this.lblEngine.Location = new System.Drawing.Point(655, 243);
            this.lblEngine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(197, 22);
            this.lblEngine.TabIndex = 6;
            this.lblEngine.Text = "Động cơ";
            this.lblEngine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picDoor
            // 
            this.picDoor.Location = new System.Drawing.Point(101, 48);
            this.picDoor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picDoor.Name = "picDoor";
            this.picDoor.Size = new System.Drawing.Size(150, 130);
            this.picDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDoor.TabIndex = 2;
            this.picDoor.TabStop = false;
            // 
            // picWheel
            // 
            this.picWheel.Location = new System.Drawing.Point(384, 48);
            this.picWheel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picWheel.Name = "picWheel";
            this.picWheel.Size = new System.Drawing.Size(150, 130);
            this.picWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWheel.TabIndex = 2;
            this.picWheel.TabStop = false;
            // 
            // lblSeat
            // 
            this.lblSeat.Location = new System.Drawing.Point(99, 243);
            this.lblSeat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(152, 22);
            this.lblSeat.TabIndex = 6;
            this.lblSeat.Text = "Ghế";
            this.lblSeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgrDoor
            // 
            this.pgrDoor.Location = new System.Drawing.Point(101, 208);
            this.pgrDoor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pgrDoor.Name = "pgrDoor";
            this.pgrDoor.Size = new System.Drawing.Size(150, 19);
            this.pgrDoor.Step = 1;
            this.pgrDoor.TabIndex = 4;
            // 
            // picFrame
            // 
            this.picFrame.Location = new System.Drawing.Point(678, 48);
            this.picFrame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picFrame.Name = "picFrame";
            this.picFrame.Size = new System.Drawing.Size(150, 130);
            this.picFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFrame.TabIndex = 2;
            this.picFrame.TabStop = false;
            // 
            // pgrEngine
            // 
            this.pgrEngine.Location = new System.Drawing.Point(678, 434);
            this.pgrEngine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pgrEngine.Name = "pgrEngine";
            this.pgrEngine.Size = new System.Drawing.Size(150, 19);
            this.pgrEngine.Step = 1;
            this.pgrEngine.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // lblFrame
            // 
            this.lblFrame.Location = new System.Drawing.Point(655, 24);
            this.lblFrame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrame.Name = "lblFrame";
            this.lblFrame.Size = new System.Drawing.Size(197, 22);
            this.lblFrame.TabIndex = 6;
            this.lblFrame.Text = "Khung thân";
            this.lblFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picSeat
            // 
            this.picSeat.Location = new System.Drawing.Point(101, 267);
            this.picSeat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picSeat.Name = "picSeat";
            this.picSeat.Size = new System.Drawing.Size(150, 130);
            this.picSeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSeat.TabIndex = 2;
            this.picSeat.TabStop = false;
            // 
            // pgrSeat
            // 
            this.pgrSeat.Location = new System.Drawing.Point(101, 434);
            this.pgrSeat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pgrSeat.Name = "pgrSeat";
            this.pgrSeat.Size = new System.Drawing.Size(150, 19);
            this.pgrSeat.Step = 1;
            this.pgrSeat.TabIndex = 4;
            // 
            // pgrWheel
            // 
            this.pgrWheel.Location = new System.Drawing.Point(384, 208);
            this.pgrWheel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pgrWheel.Name = "pgrWheel";
            this.pgrWheel.Size = new System.Drawing.Size(150, 19);
            this.pgrWheel.Step = 1;
            this.pgrWheel.TabIndex = 4;
            // 
            // lblWheel
            // 
            this.lblWheel.Location = new System.Drawing.Point(382, 24);
            this.lblWheel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWheel.Name = "lblWheel";
            this.lblWheel.Size = new System.Drawing.Size(152, 22);
            this.lblWheel.TabIndex = 6;
            this.lblWheel.Text = "Bánh xe";
            this.lblWheel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgrFrame
            // 
            this.pgrFrame.Location = new System.Drawing.Point(678, 208);
            this.pgrFrame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pgrFrame.Name = "pgrFrame";
            this.pgrFrame.Size = new System.Drawing.Size(150, 19);
            this.pgrFrame.Step = 1;
            this.pgrFrame.TabIndex = 4;
            // 
            // picEngine
            // 
            this.picEngine.Location = new System.Drawing.Point(678, 267);
            this.picEngine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picEngine.Name = "picEngine";
            this.picEngine.Size = new System.Drawing.Size(150, 130);
            this.picEngine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEngine.TabIndex = 2;
            this.picEngine.TabStop = false;
            // 
            // cmbCarTypes
            // 
            this.cmbCarTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarTypes.FormattingEnabled = true;
            this.cmbCarTypes.Location = new System.Drawing.Point(351, 20);
            this.cmbCarTypes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCarTypes.Name = "cmbCarTypes";
            this.cmbCarTypes.Size = new System.Drawing.Size(218, 21);
            this.cmbCarTypes.TabIndex = 9;
            this.cmbCarTypes.SelectedValueChanged += new System.EventHandler(this.cmbCarTypes_SelectedValueChanged);
            // 
            // btnProduce
            // 
            this.btnProduce.Location = new System.Drawing.Point(641, 15);
            this.btnProduce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProduce.Name = "btnProduce";
            this.btnProduce.Size = new System.Drawing.Size(56, 28);
            this.btnProduce.TabIndex = 8;
            this.btnProduce.Text = "Chế tạo";
            this.btnProduce.UseVisualStyleBackColor = true;
            this.btnProduce.Click += new System.EventHandler(this.BtnProduce_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 534);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.frameCreate);
            this.Controls.Add(this.cmbCarTypes);
            this.Controls.Add(this.btnProduce);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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

