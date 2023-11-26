namespace COFFEESHOP
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
            Insert = new Button();
            UNtextbox = new TextBox();
            Ptextbox = new TextBox();
            UCcombobox = new ComboBox();
            UQcombobox = new ComboBox();
            UScombobox = new ComboBox();
            ClearButton = new Button();
            dataGridView1 = new DataGridView();
            userName = new DataGridViewTextBoxColumn();
            userChoice = new DataGridViewTextBoxColumn();
            userSize = new DataGridViewTextBoxColumn();
            userQuantity = new DataGridViewTextBoxColumn();
            userPayment = new DataGridViewTextBoxColumn();
            UndoButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Insert
            // 
            Insert.FlatStyle = FlatStyle.Flat;
            Insert.Font = new Font("Bell MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Insert.ForeColor = SystemColors.ControlLightLight;
            Insert.Location = new Point(237, 608);
            Insert.Name = "Insert";
            Insert.Size = new Size(63, 34);
            Insert.TabIndex = 5;
            Insert.Text = "Insert";
            Insert.UseVisualStyleBackColor = true;
            Insert.Click += Insert_Click;
            // 
            // UNtextbox
            // 
            UNtextbox.BackColor = Color.DarkKhaki;
            UNtextbox.ForeColor = SystemColors.ControlLightLight;
            UNtextbox.Location = new Point(135, 454);
            UNtextbox.Name = "UNtextbox";
            UNtextbox.Size = new Size(165, 23);
            UNtextbox.TabIndex = 7;
            UNtextbox.TextChanged += UNtextbox_TextChanged;
            // 
            // Ptextbox
            // 
            Ptextbox.BackColor = Color.DarkKhaki;
            Ptextbox.Location = new Point(135, 570);
            Ptextbox.Name = "Ptextbox";
            Ptextbox.Size = new Size(165, 23);
            Ptextbox.TabIndex = 8;
            Ptextbox.TextChanged += Ptextbox_TextChanged;
            // 
            // UCcombobox
            // 
            UCcombobox.BackColor = Color.DarkKhaki;
            UCcombobox.FormattingEnabled = true;
            UCcombobox.Items.AddRange(new object[] { "Ice Macha Tea Latte", "Ice Caramel Macchiato", "Vanila Ice Coffee" });
            UCcombobox.Location = new Point(135, 483);
            UCcombobox.Name = "UCcombobox";
            UCcombobox.Size = new Size(165, 23);
            UCcombobox.TabIndex = 9;
            UCcombobox.SelectedIndexChanged += UCcombobox_SelectedIndexChanged;
            // 
            // UQcombobox
            // 
            UQcombobox.BackColor = Color.DarkKhaki;
            UQcombobox.FormattingEnabled = true;
            UQcombobox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            UQcombobox.Location = new Point(135, 541);
            UQcombobox.Name = "UQcombobox";
            UQcombobox.Size = new Size(165, 23);
            UQcombobox.TabIndex = 10;
            UQcombobox.SelectedIndexChanged += UQcombobox_SelectedIndexChanged;
            // 
            // UScombobox
            // 
            UScombobox.BackColor = Color.DarkKhaki;
            UScombobox.FormattingEnabled = true;
            UScombobox.Items.AddRange(new object[] { "Tall(12 fl oz)", "Grande(16 fl oz)", "Verti(24 fl oz)" });
            UScombobox.Location = new Point(135, 512);
            UScombobox.Name = "UScombobox";
            UScombobox.Size = new Size(165, 23);
            UScombobox.TabIndex = 11;
            UScombobox.SelectedIndexChanged += UScombobox_SelectedIndexChanged;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = SystemColors.ControlLightLight;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.Font = new Font("Bell MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ClearButton.ForeColor = Color.Olive;
            ClearButton.Location = new Point(135, 608);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(63, 34);
            ClearButton.TabIndex = 12;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { userName, userChoice, userSize, userQuantity, userPayment });
            dataGridView1.Location = new Point(336, 454);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(517, 139);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // userName
            // 
            userName.HeaderText = "Name";
            userName.Name = "userName";
            // 
            // userChoice
            // 
            userChoice.HeaderText = "Choice";
            userChoice.Name = "userChoice";
            // 
            // userSize
            // 
            userSize.HeaderText = "Size";
            userSize.Name = "userSize";
            // 
            // userQuantity
            // 
            userQuantity.HeaderText = "Quantity";
            userQuantity.Name = "userQuantity";
            // 
            // userPayment
            // 
            userPayment.HeaderText = "Payment";
            userPayment.Name = "userPayment";
            // 
            // UndoButton
            // 
            UndoButton.BackColor = SystemColors.ControlLightLight;
            UndoButton.BackgroundImageLayout = ImageLayout.None;
            UndoButton.FlatStyle = FlatStyle.Flat;
            UndoButton.Font = new Font("Bell MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            UndoButton.ForeColor = Color.Olive;
            UndoButton.Location = new Point(790, 608);
            UndoButton.Name = "UndoButton";
            UndoButton.Size = new Size(63, 34);
            UndoButton.TabIndex = 14;
            UndoButton.Text = "Undo";
            UndoButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Bell MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Olive;
            label1.Location = new Point(28, 454);
            label1.Name = "label1";
            label1.Size = new Size(44, 18);
            label1.TabIndex = 15;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Bell MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Olive;
            label2.Location = new Point(28, 483);
            label2.Name = "label2";
            label2.Size = new Size(48, 18);
            label2.TabIndex = 16;
            label2.Text = "Choice";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Bell MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Olive;
            label3.Location = new Point(28, 512);
            label3.Name = "label3";
            label3.Size = new Size(36, 18);
            label3.TabIndex = 17;
            label3.Text = "Size";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Bell MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Olive;
            label4.Location = new Point(28, 541);
            label4.Name = "label4";
            label4.Size = new Size(63, 18);
            label4.TabIndex = 18;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLightLight;
            label5.Font = new Font("Bell MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Olive;
            label5.Location = new Point(28, 573);
            label5.Name = "label5";
            label5.Size = new Size(61, 18);
            label5.TabIndex = 19;
            label5.Text = "Payment";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            BackgroundImage = Properties.Resources.Vanilla_Ice_Coffee;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(887, 693);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UndoButton);
            Controls.Add(dataGridView1);
            Controls.Add(ClearButton);
            Controls.Add(UScombobox);
            Controls.Add(UQcombobox);
            Controls.Add(UCcombobox);
            Controls.Add(Ptextbox);
            Controls.Add(UNtextbox);
            Controls.Add(Insert);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Insert;
        private TextBox UNtextbox;
        private TextBox Ptextbox;
        private ComboBox UCcombobox;
        private ComboBox UQcombobox;
        private ComboBox UScombobox;
        private Button ClearButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn userChoice;
        private DataGridViewTextBoxColumn userSize;
        private DataGridViewTextBoxColumn userQuantity;
        private DataGridViewTextBoxColumn userPayment;
        private Button UndoButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
