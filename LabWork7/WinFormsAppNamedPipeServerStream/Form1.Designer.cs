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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
