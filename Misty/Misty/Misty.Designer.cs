namespace Misty
{
    partial class Misty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Misty));
            this.launch = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.reduce = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.directory = new System.Windows.Forms.FolderBrowserDialog();
            this.uncompress = new System.Windows.Forms.Button();
            this.file_mist = new System.Windows.Forms.OpenFileDialog();
            this.bar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // launch
            // 
            this.launch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launch.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launch.ForeColor = System.Drawing.Color.DarkViolet;
            this.launch.Location = new System.Drawing.Point(99, 91);
            this.launch.Name = "launch";
            this.launch.Size = new System.Drawing.Size(233, 28);
            this.launch.TabIndex = 10;
            this.launch.Text = "Compress";
            this.launch.UseVisualStyleBackColor = true;
            this.launch.Click += new System.EventHandler(this.launch_Click);
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.DarkViolet;
            this.status.Location = new System.Drawing.Point(12, 178);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(400, 23);
            this.status.TabIndex = 13;
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reduce
            // 
            this.reduce.BackgroundImage = global::Misty.Properties.Resources.minimize;
            this.reduce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reduce.FlatAppearance.BorderSize = 0;
            this.reduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reduce.Location = new System.Drawing.Point(376, 13);
            this.reduce.Name = "reduce";
            this.reduce.Size = new System.Drawing.Size(15, 15);
            this.reduce.TabIndex = 12;
            this.reduce.UseVisualStyleBackColor = true;
            this.reduce.Click += new System.EventHandler(this.reduce_Click);
            // 
            // exit
            // 
            this.exit.BackgroundImage = global::Misty.Properties.Resources.exit;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(397, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(15, 15);
            this.exit.TabIndex = 9;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Released by Neo";
            // 
            // uncompress
            // 
            this.uncompress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uncompress.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uncompress.ForeColor = System.Drawing.Color.DarkViolet;
            this.uncompress.Location = new System.Drawing.Point(99, 136);
            this.uncompress.Name = "uncompress";
            this.uncompress.Size = new System.Drawing.Size(233, 28);
            this.uncompress.TabIndex = 15;
            this.uncompress.Text = "Uncompress";
            this.uncompress.UseVisualStyleBackColor = true;
            this.uncompress.Click += new System.EventHandler(this.uncompress_Click);
            // 
            // file_mist
            // 
            this.file_mist.Filter = ".mis|";
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.DarkViolet;
            this.bar.Location = new System.Drawing.Point(0, 215);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(0, 10);
            this.bar.TabIndex = 16;
            // 
            // Misty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(424, 225);
            this.ControlBox = false;
            this.Controls.Add(this.bar);
            this.Controls.Add(this.uncompress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.reduce);
            this.Controls.Add(this.launch);
            this.Controls.Add(this.exit);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Misty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button launch;
        private System.Windows.Forms.Button reduce;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog directory;
        private System.Windows.Forms.Button uncompress;
        private System.Windows.Forms.OpenFileDialog file_mist;
        private System.Windows.Forms.Panel bar;
    }
}

