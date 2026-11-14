namespace WinFormsAppNamedPipeServerStream
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
            ScriptButton = new Button();
            ScriptTextBox = new TextBox();
            ScriptOpenFileDialog = new OpenFileDialog();
            ScriptOpenButton = new Button();
            EventsListBox = new ListBox();
            EventButton = new Button();
            DescriptionTextBox = new TextBox();
            NameTextBox = new TextBox();
            EventDateTimePicker = new DateTimePicker();
            ScriptEventTextBox = new TextBox();
            SuspendLayout();
            // 
            // ScriptButton
            // 
            ScriptButton.Location = new Point(12, 41);
            ScriptButton.Name = "ScriptButton";
            ScriptButton.Size = new Size(75, 23);
            ScriptButton.TabIndex = 0;
            ScriptButton.Text = "Выполнить";
            ScriptButton.UseVisualStyleBackColor = true;
            ScriptButton.Click += ScriptButton_Click;
            // 
            // ScriptTextBox
            // 
            ScriptTextBox.Location = new Point(12, 12);
            ScriptTextBox.Name = "ScriptTextBox";
            ScriptTextBox.Size = new Size(100, 23);
            ScriptTextBox.TabIndex = 1;
            // 
            // ScriptOpenFileDialog
            // 
            ScriptOpenFileDialog.FileName = "openFileDialog1";
            // 
            // ScriptOpenButton
            // 
            ScriptOpenButton.Location = new Point(12, 70);
            ScriptOpenButton.Name = "ScriptOpenButton";
            ScriptOpenButton.Size = new Size(75, 23);
            ScriptOpenButton.TabIndex = 2;
            ScriptOpenButton.Text = "Открыть";
            ScriptOpenButton.UseVisualStyleBackColor = true;
            ScriptOpenButton.Click += ScriptOpenButton_Click;
            // 
            // EventsListBox
            // 
            EventsListBox.FormattingEnabled = true;
            EventsListBox.Location = new Point(224, 99);
            EventsListBox.Name = "EventsListBox";
            EventsListBox.Size = new Size(393, 184);
            EventsListBox.TabIndex = 3;
            // 
            // EventButton
            // 
            EventButton.Location = new Point(12, 186);
            EventButton.Name = "EventButton";
            EventButton.Size = new Size(75, 23);
            EventButton.TabIndex = 4;
            EventButton.Text = "Добавить";
            EventButton.UseVisualStyleBackColor = true;
            EventButton.Click += EventButton_Click;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(118, 99);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(100, 23);
            DescriptionTextBox.TabIndex = 5;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(12, 99);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 6;
            // 
            // EventDateTimePicker
            // 
            EventDateTimePicker.Location = new Point(12, 128);
            EventDateTimePicker.Name = "EventDateTimePicker";
            EventDateTimePicker.Size = new Size(200, 23);
            EventDateTimePicker.TabIndex = 8;
            // 
            // ScriptEventTextBox
            // 
            ScriptEventTextBox.Location = new Point(12, 157);
            ScriptEventTextBox.Name = "ScriptEventTextBox";
            ScriptEventTextBox.Size = new Size(100, 23);
            ScriptEventTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ScriptEventTextBox);
            Controls.Add(EventDateTimePicker);
            Controls.Add(NameTextBox);
            Controls.Add(DescriptionTextBox);
            Controls.Add(EventButton);
            Controls.Add(EventsListBox);
            Controls.Add(ScriptOpenButton);
            Controls.Add(ScriptTextBox);
            Controls.Add(ScriptButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ScriptButton;
        private TextBox ScriptTextBox;
        private OpenFileDialog ScriptOpenFileDialog;
        private Button ScriptOpenButton;
        private ListBox EventsListBox;
        private Button EventButton;
        private TextBox DescriptionTextBox;
        private TextBox NameTextBox;
        private DateTimePicker EventDateTimePicker;
        private TextBox ScriptEventTextBox;
    }
}
