namespace _29._02_anketa
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
            countryComboBox = new ComboBox();
            cityComboBox = new ComboBox();
            checkedListBox1 = new CheckedListBox();
            TimeLabel = new Label();
            morningRadioButton = new RadioButton();
            afternoonRadioButton = new RadioButton();
            eveningRadioButton = new RadioButton();
            selectedHobbiesListBox = new ListBox();
            chosenHobbiesOfSelectedHobbiesListBox = new ListBox();
            SuspendLayout();
            // 
            // countryComboBox
            // 
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Items.AddRange(new object[] { "Bulgaria", "Germany", "Italy" });
            countryComboBox.Location = new Point(98, 89);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(329, 33);
            countryComboBox.TabIndex = 0;
            countryComboBox.Text = "Select Country";
            // 
            // cityComboBox
            // 
            cityComboBox.FormattingEnabled = true;
            cityComboBox.Location = new Point(98, 421);
            cityComboBox.Name = "cityComboBox";
            cityComboBox.Size = new Size(329, 33);
            cityComboBox.TabIndex = 1;
            cityComboBox.Text = "Select City";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Hobby 1", "Hobby 2", "Hobby 3", "Hobby 4", "Hobby 5", "Hobby 6" });
            checkedListBox1.Location = new Point(835, 93);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(299, 228);
            checkedListBox1.TabIndex = 2;
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Location = new Point(1296, 74);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(50, 25);
            TimeLabel.TabIndex = 3;
            TimeLabel.Text = "Time";
            // 
            // morningRadioButton
            // 
            morningRadioButton.AutoSize = true;
            morningRadioButton.Location = new Point(1295, 129);
            morningRadioButton.Name = "morningRadioButton";
            morningRadioButton.Size = new Size(105, 29);
            morningRadioButton.TabIndex = 4;
            morningRadioButton.TabStop = true;
            morningRadioButton.Text = "Morning";
            morningRadioButton.UseVisualStyleBackColor = true;
            // 
            // afternoonRadioButton
            // 
            afternoonRadioButton.AutoSize = true;
            afternoonRadioButton.Location = new Point(1296, 178);
            afternoonRadioButton.Name = "afternoonRadioButton";
            afternoonRadioButton.Size = new Size(118, 29);
            afternoonRadioButton.TabIndex = 5;
            afternoonRadioButton.TabStop = true;
            afternoonRadioButton.Text = "Afternoon";
            afternoonRadioButton.UseVisualStyleBackColor = true;
            // 
            // eveningRadioButton
            // 
            eveningRadioButton.AutoSize = true;
            eveningRadioButton.Location = new Point(1296, 227);
            eveningRadioButton.Name = "eveningRadioButton";
            eveningRadioButton.Size = new Size(99, 29);
            eveningRadioButton.TabIndex = 6;
            eveningRadioButton.TabStop = true;
            eveningRadioButton.Text = "Evening";
            eveningRadioButton.UseVisualStyleBackColor = true;
            // 
            // selectedHobbiesListBox
            // 
            selectedHobbiesListBox.FormattingEnabled = true;
            selectedHobbiesListBox.ItemHeight = 25;
            selectedHobbiesListBox.Location = new Point(836, 466);
            selectedHobbiesListBox.Name = "selectedHobbiesListBox";
            selectedHobbiesListBox.Size = new Size(299, 304);
            selectedHobbiesListBox.TabIndex = 7;
            // 
            // chosenHobbiesOfSelectedHobbiesListBox
            // 
            chosenHobbiesOfSelectedHobbiesListBox.FormattingEnabled = true;
            chosenHobbiesOfSelectedHobbiesListBox.ItemHeight = 25;
            chosenHobbiesOfSelectedHobbiesListBox.Location = new Point(1307, 491);
            chosenHobbiesOfSelectedHobbiesListBox.Name = "chosenHobbiesOfSelectedHobbiesListBox";
            chosenHobbiesOfSelectedHobbiesListBox.Size = new Size(286, 279);
            chosenHobbiesOfSelectedHobbiesListBox.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1792, 981);
            Controls.Add(chosenHobbiesOfSelectedHobbiesListBox);
            Controls.Add(selectedHobbiesListBox);
            Controls.Add(eveningRadioButton);
            Controls.Add(afternoonRadioButton);
            Controls.Add(morningRadioButton);
            Controls.Add(TimeLabel);
            Controls.Add(checkedListBox1);
            Controls.Add(cityComboBox);
            Controls.Add(countryComboBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox countryComboBox;
        private ComboBox cityComboBox;
        private CheckedListBox checkedListBox1;
        private Label TimeLabel;
        private RadioButton morningRadioButton;
        private RadioButton afternoonRadioButton;
        private RadioButton eveningRadioButton;
        private ListBox selectedHobbiesListBox;
        private ListBox chosenHobbiesOfSelectedHobbiesListBox;
    }
}