namespace Lights
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
            this.lightOffPictureBox = new System.Windows.Forms.PictureBox();
            this.lightOnPictureBox = new System.Windows.Forms.PictureBox();
            this.lightStateLabel = new System.Windows.Forms.Label();
            this.switchButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lightOffPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightOnPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lightOffPictureBox
            // 
            this.lightOffPictureBox.Image = global::Lights.Properties.Resources.LightOff;
            this.lightOffPictureBox.Location = new System.Drawing.Point(18, 17);
            this.lightOffPictureBox.Name = "lightOffPictureBox";
            this.lightOffPictureBox.Size = new System.Drawing.Size(160, 200);
            this.lightOffPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lightOffPictureBox.TabIndex = 1;
            this.lightOffPictureBox.TabStop = false;
            this.lightOffPictureBox.Visible = false;
            // 
            // lightOnPictureBox
            // 
            this.lightOnPictureBox.Image = global::Lights.Properties.Resources.LightOn;
            this.lightOnPictureBox.Location = new System.Drawing.Point(18, 17);
            this.lightOnPictureBox.Name = "lightOnPictureBox";
            this.lightOnPictureBox.Size = new System.Drawing.Size(160, 200);
            this.lightOnPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lightOnPictureBox.TabIndex = 0;
            this.lightOnPictureBox.TabStop = false;
            // 
            // lightStateLabel
            // 
            this.lightStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightStateLabel.Location = new System.Drawing.Point(48, 230);
            this.lightStateLabel.Name = "lightStateLabel";
            this.lightStateLabel.Size = new System.Drawing.Size(100, 23);
            this.lightStateLabel.TabIndex = 2;
            this.lightStateLabel.Text = "ON";
            this.lightStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // switchButton
            // 
            this.switchButton.Location = new System.Drawing.Point(20, 271);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(75, 23);
            this.switchButton.TabIndex = 3;
            this.switchButton.Text = "Switch Light";
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(101, 271);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 308);
            this.Controls.Add(this.lightOnPictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.lightStateLabel);
            this.Controls.Add(this.lightOffPictureBox);
            this.Name = "Form1";
            this.Text = "Lights";
            ((System.ComponentModel.ISupportInitialize)(this.lightOffPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightOnPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lightOnPictureBox;
        private System.Windows.Forms.PictureBox lightOffPictureBox;
        private System.Windows.Forms.Label lightStateLabel;
        private System.Windows.Forms.Button switchButton;
        private System.Windows.Forms.Button exitButton;
    }
}

