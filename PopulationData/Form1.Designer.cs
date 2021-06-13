namespace PopulationData
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.avgChangeText = new System.Windows.Forms.Label();
            this.biggestIncreaseText = new System.Windows.Forms.Label();
            this.smallestIncreaseText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Population File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Population Calculation";
            // 
            // avgChangeText
            // 
            this.avgChangeText.AutoSize = true;
            this.avgChangeText.Location = new System.Drawing.Point(511, 169);
            this.avgChangeText.Name = "avgChangeText";
            this.avgChangeText.Size = new System.Drawing.Size(35, 13);
            this.avgChangeText.TabIndex = 2;
            this.avgChangeText.Text = "label2";
            this.avgChangeText.Visible = false;
            // 
            // biggestIncreaseText
            // 
            this.biggestIncreaseText.AutoSize = true;
            this.biggestIncreaseText.Location = new System.Drawing.Point(511, 197);
            this.biggestIncreaseText.Name = "biggestIncreaseText";
            this.biggestIncreaseText.Size = new System.Drawing.Size(35, 13);
            this.biggestIncreaseText.TabIndex = 3;
            this.biggestIncreaseText.Text = "label3";
            this.biggestIncreaseText.Visible = false;
            // 
            // smallestIncreaseText
            // 
            this.smallestIncreaseText.AutoSize = true;
            this.smallestIncreaseText.Location = new System.Drawing.Point(511, 225);
            this.smallestIncreaseText.Name = "smallestIncreaseText";
            this.smallestIncreaseText.Size = new System.Drawing.Size(35, 13);
            this.smallestIncreaseText.TabIndex = 4;
            this.smallestIncreaseText.Text = "label4";
            this.smallestIncreaseText.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Average annual increase:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Year with greatest increase:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Year with least increase:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.smallestIncreaseText);
            this.Controls.Add(this.biggestIncreaseText);
            this.Controls.Add(this.avgChangeText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label avgChangeText;
        private System.Windows.Forms.Label biggestIncreaseText;
        private System.Windows.Forms.Label smallestIncreaseText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

