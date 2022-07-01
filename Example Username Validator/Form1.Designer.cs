namespace Example_Username_Validator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputText = new System.Windows.Forms.TextBox();
            this.regEx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.InputTextLabel = new System.Windows.Forms.Label();
            this.RegExLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.circularButton1 = new Example_Username_Validator.CircularButton();
            this.circularButton3 = new Example_Username_Validator.CircularButton();
            this.circularButton2 = new Example_Username_Validator.CircularButton();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.BackColor = System.Drawing.Color.LavenderBlush;
            this.inputText.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputText.Location = new System.Drawing.Point(136, 49);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(800, 89);
            this.inputText.TabIndex = 0;
            this.inputText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // regEx
            // 
            this.regEx.BackColor = System.Drawing.Color.LavenderBlush;
            this.regEx.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regEx.Location = new System.Drawing.Point(136, 180);
            this.regEx.Name = "regEx";
            this.regEx.Size = new System.Drawing.Size(800, 89);
            this.regEx.TabIndex = 0;
            this.regEx.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.regEx.Enter += new System.EventHandler(this.regEx_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Gabriola", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(203, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 90);
            this.button1.TabIndex = 2;
            this.button1.Text = "See if it works!";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputTextLabel
            // 
            this.InputTextLabel.AutoSize = true;
            this.InputTextLabel.Font = new System.Drawing.Font("Gabriola", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTextLabel.Location = new System.Drawing.Point(21, 59);
            this.InputTextLabel.Name = "InputTextLabel";
            this.InputTextLabel.Size = new System.Drawing.Size(93, 79);
            this.InputTextLabel.TabIndex = 3;
            this.InputTextLabel.Text = "Text";
            this.InputTextLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // RegExLabel
            // 
            this.RegExLabel.AutoSize = true;
            this.RegExLabel.Font = new System.Drawing.Font("Gabriola", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegExLabel.Location = new System.Drawing.Point(7, 189);
            this.RegExLabel.Name = "RegExLabel";
            this.RegExLabel.Size = new System.Drawing.Size(123, 79);
            this.RegExLabel.TabIndex = 4;
            this.RegExLabel.Text = "RegEx";
            this.RegExLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Honeydew;
            this.textBox1.Location = new System.Drawing.Point(57, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // circularButton1
            // 
            this.circularButton1.BackColor = System.Drawing.Color.OrangeRed;
            this.circularButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton1.ForeColor = System.Drawing.Color.Maroon;
            this.circularButton1.Location = new System.Drawing.Point(580, 307);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(172, 161);
            this.circularButton1.TabIndex = 6;
            this.circularButton1.Text = "Do Not Press";
            this.circularButton1.UseVisualStyleBackColor = false;
            this.circularButton1.Click += new System.EventHandler(this.circularButton1_Click);
            // 
            // circularButton3
            // 
            this.circularButton3.BackColor = System.Drawing.Color.Black;
            this.circularButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton3.Location = new System.Drawing.Point(568, 298);
            this.circularButton3.Name = "circularButton3";
            this.circularButton3.Size = new System.Drawing.Size(197, 182);
            this.circularButton3.TabIndex = 8;
            this.circularButton3.Text = "circularButton3";
            this.circularButton3.UseVisualStyleBackColor = false;
            // 
            // circularButton2
            // 
            this.circularButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton2.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton2.ForeColor = System.Drawing.Color.Lime;
            this.circularButton2.Image = ((System.Drawing.Image)(resources.GetObject("circularButton2.Image")));
            this.circularButton2.Location = new System.Drawing.Point(837, 369);
            this.circularButton2.Name = "circularButton2";
            this.circularButton2.Size = new System.Drawing.Size(148, 143);
            this.circularButton2.TabIndex = 7;
            this.circularButton2.Text = "DonutPress";
            this.circularButton2.UseVisualStyleBackColor = true;
            this.circularButton2.Click += new System.EventHandler(this.circularButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.circularButton1);
            this.Controls.Add(this.circularButton3);
            this.Controls.Add(this.circularButton2);
            this.Controls.Add(this.RegExLabel);
            this.Controls.Add(this.InputTextLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.regEx);
            this.Controls.Add(this.inputText);
            this.Name = "Form1";
            this.Text = "RegEx Validator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.TextBox regEx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label InputTextLabel;
        private System.Windows.Forms.Label RegExLabel;
        private System.Windows.Forms.TextBox textBox1;
        private CircularButton circularButton1;
        private CircularButton circularButton2;
        private CircularButton circularButton3;
    }
}

