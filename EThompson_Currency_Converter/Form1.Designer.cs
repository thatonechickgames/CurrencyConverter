namespace EThompson_Currency_Converter
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
            this.toLabel = new System.Windows.Forms.Label();
            this.fromList = new System.Windows.Forms.ComboBox();
            this.toList = new System.Windows.Forms.ComboBox();
            this.fromValue = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.toValue = new System.Windows.Forms.TextBox();
            this.dollarOne = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flagTwo = new System.Windows.Forms.PictureBox();
            this.flagOne = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flagTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flagOne)).BeginInit();
            this.SuspendLayout();
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toLabel.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(201, 209);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(52, 34);
            this.toLabel.TabIndex = 2;
            this.toLabel.Text = "TO";
            this.toLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // fromList
            // 
            this.fromList.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromList.FormattingEnabled = true;
            this.fromList.Items.AddRange(new object[] {
            "U.S. Dollar",
            "Euro",
            "Canadian Dollar",
            "Japanese Yen",
            "Argentine Peso"});
            this.fromList.Location = new System.Drawing.Point(237, 67);
            this.fromList.Name = "fromList";
            this.fromList.Size = new System.Drawing.Size(176, 30);
            this.fromList.TabIndex = 3;
            this.fromList.SelectedIndexChanged += new System.EventHandler(this.fromList_SelectedIndexChanged);
            // 
            // toList
            // 
            this.toList.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toList.FormattingEnabled = true;
            this.toList.Items.AddRange(new object[] {
            "U.S. Dollar",
            "Euro",
            "Canadian Dollar",
            "Japanese Yen",
            "Argentine Peso"});
            this.toList.Location = new System.Drawing.Point(237, 283);
            this.toList.Name = "toList";
            this.toList.Size = new System.Drawing.Size(176, 30);
            this.toList.TabIndex = 4;
            this.toList.SelectedIndexChanged += new System.EventHandler(this.toList_SelectedIndexChanged);
            // 
            // fromValue
            // 
            this.fromValue.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromValue.Location = new System.Drawing.Point(273, 126);
            this.fromValue.MaxLength = 1000;
            this.fromValue.Name = "fromValue";
            this.fromValue.Size = new System.Drawing.Size(140, 33);
            this.fromValue.TabIndex = 1;
            // 
            // goButton
            // 
            this.goButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.goButton.FlatAppearance.BorderSize = 2;
            this.goButton.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.Location = new System.Drawing.Point(273, 393);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(94, 45);
            this.goButton.TabIndex = 7;
            this.goButton.Text = "GO!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // toValue
            // 
            this.toValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.toValue.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toValue.Location = new System.Drawing.Point(273, 343);
            this.toValue.MaxLength = 500;
            this.toValue.Name = "toValue";
            this.toValue.ReadOnly = true;
            this.toValue.Size = new System.Drawing.Size(140, 33);
            this.toValue.TabIndex = 2;
            this.toValue.TextChanged += new System.EventHandler(this.toValue_TextChanged);
            // 
            // dollarOne
            // 
            this.dollarOne.AllowDrop = true;
            this.dollarOne.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollarOne.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dollarOne.Location = new System.Drawing.Point(250, 343);
            this.dollarOne.Margin = new System.Windows.Forms.Padding(0);
            this.dollarOne.Name = "dollarOne";
            this.dollarOne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dollarOne.Size = new System.Drawing.Size(20, 32);
            this.dollarOne.TabIndex = 8;
            this.dollarOne.Text = "$";
            this.dollarOne.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(250, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(20, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "$";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flagTwo
            // 
            this.flagTwo.InitialImage = null;
            this.flagTwo.Location = new System.Drawing.Point(11, 257);
            this.flagTwo.Name = "flagTwo";
            this.flagTwo.Size = new System.Drawing.Size(220, 150);
            this.flagTwo.TabIndex = 1;
            this.flagTwo.TabStop = false;
            this.flagTwo.Click += new System.EventHandler(this.flagTwo_Click);
            // 
            // flagOne
            // 
            this.flagOne.Location = new System.Drawing.Point(12, 40);
            this.flagOne.Name = "flagOne";
            this.flagOne.Size = new System.Drawing.Size(220, 150);
            this.flagOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.flagOne.TabIndex = 0;
            this.flagOne.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dollarOne);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.toValue);
            this.Controls.Add(this.fromValue);
            this.Controls.Add(this.toList);
            this.Controls.Add(this.fromList);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.flagTwo);
            this.Controls.Add(this.flagOne);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter";
            ((System.ComponentModel.ISupportInitialize)(this.flagTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flagOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flagOne;
        private System.Windows.Forms.PictureBox flagTwo;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.ComboBox fromList;
        private System.Windows.Forms.ComboBox toList;
        private System.Windows.Forms.TextBox fromValue;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox toValue;
        private System.Windows.Forms.Label dollarOne;
        private System.Windows.Forms.Label label1;
    }
}

