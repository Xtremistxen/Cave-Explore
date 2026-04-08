namespace CaveExplorerTracker
{
    partial class CaveExplore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaveExplore));
            titleLabel = new Label();
            instructionsLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            exploredCheckBox = new CheckBox();
            caveNameTextBox = new TextBox();
            locationTextBox = new TextBox();
            depthTextBox = new TextBox();
            lengthTextBox = new TextBox();
            dangerLevelComboBox = new ComboBox();
            addCaveButton = new Button();
            clearButton = new Button();
            cavesListBox = new ListBox();
            caveInfoGroupBox = new GroupBox();
            label8 = new Label();
            label6 = new Label();
            extraCheckBox = new CheckBox();
            extraTextBox2 = new TextBox();
            extraTextBox1 = new TextBox();
            label7 = new Label();
            caveTypeComboBox = new ComboBox();
            giftShopCheckBox = new CheckBox();
            displayGroupBox = new GroupBox();
            caveInfoGroupBox.SuspendLayout();
            displayGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Silver;
            titleLabel.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.FromArgb(0, 0, 192);
            titleLabel.Location = new Point(429, 23);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(368, 37);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Cave Explorer Tracker";
            // 
            // instructionsLabel
            // 
            instructionsLabel.AutoSize = true;
            instructionsLabel.BackColor = Color.Silver;
            instructionsLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instructionsLabel.ForeColor = Color.Blue;
            instructionsLabel.Location = new Point(12, 5);
            instructionsLabel.Name = "instructionsLabel";
            instructionsLabel.Size = new Size(243, 18);
            instructionsLabel.TabIndex = 1;
            instructionsLabel.Text = "Enter Cave Information below";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 2;
            label1.Text = "Cave Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(119, 19);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 3;
            label2.Text = "Cave location";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(11, 63);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 4;
            label3.Text = "Depth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(119, 63);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 5;
            label4.Text = "Length";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 112);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 7;
            label5.Text = "Danger level";
            // 
            // exploredCheckBox
            // 
            exploredCheckBox.AutoSize = true;
            exploredCheckBox.BackColor = Color.White;
            exploredCheckBox.Location = new Point(10, 174);
            exploredCheckBox.Name = "exploredCheckBox";
            exploredCheckBox.Size = new Size(71, 19);
            exploredCheckBox.TabIndex = 8;
            exploredCheckBox.Text = "Explored";
            exploredCheckBox.UseVisualStyleBackColor = false;
            // 
            // caveNameTextBox
            // 
            caveNameTextBox.Location = new Point(10, 37);
            caveNameTextBox.Name = "caveNameTextBox";
            caveNameTextBox.Size = new Size(100, 23);
            caveNameTextBox.TabIndex = 9;
            // 
            // locationTextBox
            // 
            locationTextBox.Location = new Point(116, 37);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(100, 23);
            locationTextBox.TabIndex = 10;
            // 
            // depthTextBox
            // 
            depthTextBox.Location = new Point(10, 81);
            depthTextBox.Name = "depthTextBox";
            depthTextBox.Size = new Size(100, 23);
            depthTextBox.TabIndex = 11;
            // 
            // lengthTextBox
            // 
            lengthTextBox.Location = new Point(116, 81);
            lengthTextBox.Name = "lengthTextBox";
            lengthTextBox.Size = new Size(100, 23);
            lengthTextBox.TabIndex = 12;
            // 
            // dangerLevelComboBox
            // 
            dangerLevelComboBox.FormattingEnabled = true;
            dangerLevelComboBox.Location = new Point(10, 130);
            dangerLevelComboBox.Name = "dangerLevelComboBox";
            dangerLevelComboBox.Size = new Size(121, 23);
            dangerLevelComboBox.TabIndex = 13;
            // 
            // addCaveButton
            // 
            addCaveButton.Location = new Point(6, 223);
            addCaveButton.Name = "addCaveButton";
            addCaveButton.Size = new Size(75, 23);
            addCaveButton.TabIndex = 14;
            addCaveButton.Text = "Add Cave";
            addCaveButton.UseVisualStyleBackColor = true;
            addCaveButton.Click += addCaveButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(87, 223);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 15;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // cavesListBox
            // 
            cavesListBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cavesListBox.FormattingEnabled = true;
            cavesListBox.ItemHeight = 13;
            cavesListBox.Location = new Point(6, 26);
            cavesListBox.Name = "cavesListBox";
            cavesListBox.Size = new Size(770, 134);
            cavesListBox.TabIndex = 17;
            // 
            // caveInfoGroupBox
            // 
            caveInfoGroupBox.BackColor = Color.Peru;
            caveInfoGroupBox.Controls.Add(label8);
            caveInfoGroupBox.Controls.Add(label6);
            caveInfoGroupBox.Controls.Add(extraCheckBox);
            caveInfoGroupBox.Controls.Add(extraTextBox2);
            caveInfoGroupBox.Controls.Add(extraTextBox1);
            caveInfoGroupBox.Controls.Add(label7);
            caveInfoGroupBox.Controls.Add(caveTypeComboBox);
            caveInfoGroupBox.Controls.Add(giftShopCheckBox);
            caveInfoGroupBox.Controls.Add(caveNameTextBox);
            caveInfoGroupBox.Controls.Add(locationTextBox);
            caveInfoGroupBox.Controls.Add(label5);
            caveInfoGroupBox.Controls.Add(depthTextBox);
            caveInfoGroupBox.Controls.Add(label4);
            caveInfoGroupBox.Controls.Add(clearButton);
            caveInfoGroupBox.Controls.Add(label3);
            caveInfoGroupBox.Controls.Add(lengthTextBox);
            caveInfoGroupBox.Controls.Add(label2);
            caveInfoGroupBox.Controls.Add(addCaveButton);
            caveInfoGroupBox.Controls.Add(label1);
            caveInfoGroupBox.Controls.Add(exploredCheckBox);
            caveInfoGroupBox.Controls.Add(dangerLevelComboBox);
            caveInfoGroupBox.Location = new Point(12, 26);
            caveInfoGroupBox.Name = "caveInfoGroupBox";
            caveInfoGroupBox.Size = new Size(371, 252);
            caveInfoGroupBox.TabIndex = 18;
            caveInfoGroupBox.TabStop = false;
            caveInfoGroupBox.Text = "Information";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(222, 63);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 25;
            label8.Text = "Difficulty";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(140, 107);
            label6.Name = "label6";
            label6.Size = new Size(141, 15);
            label6.TabIndex = 24;
            label6.Text = "Price or Wildlife type";
            // 
            // extraCheckBox
            // 
            extraCheckBox.AutoSize = true;
            extraCheckBox.BackColor = Color.White;
            extraCheckBox.Location = new Point(212, 174);
            extraCheckBox.Name = "extraCheckBox";
            extraCheckBox.Size = new Size(140, 19);
            extraCheckBox.TabIndex = 23;
            extraCheckBox.Text = "Has gift Shop or River";
            extraCheckBox.UseVisualStyleBackColor = false;
            // 
            // extraTextBox2
            // 
            extraTextBox2.Location = new Point(222, 81);
            extraTextBox2.Name = "extraTextBox2";
            extraTextBox2.Size = new Size(100, 23);
            extraTextBox2.TabIndex = 22;
            // 
            // extraTextBox1
            // 
            extraTextBox1.Location = new Point(143, 130);
            extraTextBox1.Name = "extraTextBox1";
            extraTextBox1.Size = new Size(100, 23);
            extraTextBox1.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(224, 19);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 19;
            label7.Text = "Cave type";
            // 
            // caveTypeComboBox
            // 
            caveTypeComboBox.FormattingEnabled = true;
            caveTypeComboBox.Location = new Point(224, 37);
            caveTypeComboBox.Name = "caveTypeComboBox";
            caveTypeComboBox.Size = new Size(121, 23);
            caveTypeComboBox.TabIndex = 18;
            // 
            // giftShopCheckBox
            // 
            giftShopCheckBox.AutoSize = true;
            giftShopCheckBox.BackColor = Color.White;
            giftShopCheckBox.ForeColor = SystemColors.ControlText;
            giftShopCheckBox.Location = new Point(87, 174);
            giftShopCheckBox.Name = "giftShopCheckBox";
            giftShopCheckBox.Size = new Size(119, 19);
            giftShopCheckBox.TabIndex = 17;
            giftShopCheckBox.Text = "Has Guided Tours";
            giftShopCheckBox.UseVisualStyleBackColor = false;
            // 
            // displayGroupBox
            // 
            displayGroupBox.BackColor = Color.Peru;
            displayGroupBox.Controls.Add(cavesListBox);
            displayGroupBox.Location = new Point(12, 284);
            displayGroupBox.Name = "displayGroupBox";
            displayGroupBox.Size = new Size(785, 166);
            displayGroupBox.TabIndex = 19;
            displayGroupBox.TabStop = false;
            displayGroupBox.Text = "Cave List";
            // 
            // CaveExplore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(displayGroupBox);
            Controls.Add(caveInfoGroupBox);
            Controls.Add(instructionsLabel);
            Controls.Add(titleLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CaveExplore";
            Text = "Cave Explorers ";
            Load += CaveExplore_Load;
            caveInfoGroupBox.ResumeLayout(false);
            caveInfoGroupBox.PerformLayout();
            displayGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label instructionsLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox exploredCheckBox;
        private TextBox caveNameTextBox;
        private TextBox locationTextBox;
        private TextBox depthTextBox;
        private TextBox lengthTextBox;
        private ComboBox dangerLevelComboBox;
        private Button addCaveButton;
        private Button clearButton;
        private ListBox cavesListBox;
        private GroupBox caveInfoGroupBox;
        private GroupBox displayGroupBox;
        private CheckBox giftShopCheckBox;
        private ComboBox caveTypeComboBox;
        private Label label7;
        private TextBox extraTextBox2;
        private TextBox extraTextBox1;
        private CheckBox extraCheckBox;
        private Label label8;
        private Label label6;
    }
}
