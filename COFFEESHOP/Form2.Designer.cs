namespace COFFEESHOP
{
    partial class Form2
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
            DoneButton = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // DoneButton
            // 
            DoneButton.BackColor = SystemColors.ControlLightLight;
            DoneButton.Font = new Font("Bell MT", 12F, FontStyle.Italic);
            DoneButton.ForeColor = Color.Olive;
            DoneButton.Location = new Point(483, 430);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(75, 32);
            DoneButton.TabIndex = 1;
            DoneButton.Text = "Done";
            DoneButton.UseVisualStyleBackColor = false;
            DoneButton.Click += DoneButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOliveGreen;
            button2.Font = new Font("Bell MT", 12F, FontStyle.Italic);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(321, 430);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 2;
            button2.Text = "New";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2;
            ClientSize = new Size(862, 639);
            Controls.Add(button2);
            Controls.Add(DoneButton);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion
        private Button DoneButton;
        private Button button2;
    }
}