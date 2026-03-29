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
            label6 = new Label();
            label5 = new Label();
            exploredCheckBox = new CheckBox();
            caveNameTextBox = new TextBox();
            locationTextBox = new TextBox();
            depthTextBox = new TextBox();
            lengthTextBox = new TextBox();
            dangerLevelComboBox = new ComboBox();
            addCaveButton = new Button();
            clearButton = new Button();
            loadSampleDataButton = new Button();
            cavesListBox = new ListBox();
            caveInfoGroupBox = new GroupBox();
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
            titleLabel.Location = new Point(329, 5);
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
            label1.Location = new Point(10, 22);
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
            label2.Location = new Point(119, 22);
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
            label3.Location = new Point(10, 75);
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
            label4.Location = new Point(119, 75);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 5;
            label4.Text = "Length";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(137, 137);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 6;
            label6.Text = "Explored";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 135);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 7;
            label5.Text = "Danger Level";
            // 
            // exploredCheckBox
            // 
            exploredCheckBox.AutoSize = true;
            exploredCheckBox.BackColor = Color.White;
            exploredCheckBox.Location = new Point(137, 155);
            exploredCheckBox.Name = "exploredCheckBox";
            exploredCheckBox.Size = new Size(82, 19);
            exploredCheckBox.TabIndex = 8;
            exploredCheckBox.Text = "checkBox1";
            exploredCheckBox.UseVisualStyleBackColor = false;
            // 
            // caveNameTextBox
            // 
            caveNameTextBox.Location = new Point(10, 43);
            caveNameTextBox.Name = "caveNameTextBox";
            caveNameTextBox.Size = new Size(100, 23);
            caveNameTextBox.TabIndex = 9;
            // 
            // locationTextBox
            // 
            locationTextBox.Location = new Point(119, 43);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(100, 23);
            locationTextBox.TabIndex = 10;
            // 
            // depthTextBox
            // 
            depthTextBox.Location = new Point(10, 93);
            depthTextBox.Name = "depthTextBox";
            depthTextBox.Size = new Size(100, 23);
            depthTextBox.TabIndex = 11;
            // 
            // lengthTextBox
            // 
            lengthTextBox.Location = new Point(119, 93);
            lengthTextBox.Name = "lengthTextBox";
            lengthTextBox.Size = new Size(100, 23);
            lengthTextBox.TabIndex = 12;
            // 
            // dangerLevelComboBox
            // 
            dangerLevelComboBox.FormattingEnabled = true;
            dangerLevelComboBox.Location = new Point(10, 153);
            dangerLevelComboBox.Name = "dangerLevelComboBox";
            dangerLevelComboBox.Size = new Size(121, 23);
            dangerLevelComboBox.TabIndex = 13;
            // 
            // addCaveButton
            // 
            addCaveButton.Location = new Point(28, 194);
            addCaveButton.Name = "addCaveButton";
            addCaveButton.Size = new Size(75, 23);
            addCaveButton.TabIndex = 14;
            addCaveButton.Text = "Add Cave";
            addCaveButton.UseVisualStyleBackColor = true;
            addCaveButton.Click += addCaveButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(119, 194);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 15;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // loadSampleDataButton
            // 
            loadSampleDataButton.Location = new Point(48, 223);
            loadSampleDataButton.Name = "loadSampleDataButton";
            loadSampleDataButton.Size = new Size(113, 23);
            loadSampleDataButton.TabIndex = 16;
            loadSampleDataButton.Text = "Test Sample Data";
            loadSampleDataButton.UseVisualStyleBackColor = true;
            loadSampleDataButton.Click += loadSampleDataButton_Click;
            // 
            // cavesListBox
            // 
            cavesListBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cavesListBox.FormattingEnabled = true;
            cavesListBox.ItemHeight = 13;
            cavesListBox.Location = new Point(0, 22);
            cavesListBox.Name = "cavesListBox";
            cavesListBox.Size = new Size(632, 134);
            cavesListBox.TabIndex = 17;
            // 
            // caveInfoGroupBox
            // 
            caveInfoGroupBox.BackColor = Color.Peru;
            caveInfoGroupBox.Controls.Add(caveNameTextBox);
            caveInfoGroupBox.Controls.Add(locationTextBox);
            caveInfoGroupBox.Controls.Add(label5);
            caveInfoGroupBox.Controls.Add(loadSampleDataButton);
            caveInfoGroupBox.Controls.Add(label6);
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
            caveInfoGroupBox.Size = new Size(225, 252);
            caveInfoGroupBox.TabIndex = 18;
            caveInfoGroupBox.TabStop = false;
            caveInfoGroupBox.Text = "Information";
            // 
            // displayGroupBox
            // 
            displayGroupBox.BackColor = Color.Peru;
            displayGroupBox.Controls.Add(cavesListBox);
            displayGroupBox.Location = new Point(12, 284);
            displayGroupBox.Name = "displayGroupBox";
            displayGroupBox.Size = new Size(638, 166);
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
        private Label label6;
        private Label label5;
        private CheckBox exploredCheckBox;
        private TextBox caveNameTextBox;
        private TextBox locationTextBox;
        private TextBox depthTextBox;
        private TextBox lengthTextBox;
        private ComboBox dangerLevelComboBox;
        private Button addCaveButton;
        private Button clearButton;
        private Button loadSampleDataButton;
        private ListBox cavesListBox;
        private GroupBox caveInfoGroupBox;
        private GroupBox displayGroupBox;
    }
}
