using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppNamedPipeServerStream
{
    public partial class Form1 : Form
    {
        ScriptingHost scriptingHost = new();
        public Form1()
        {
            InitializeComponent();
            Task.Run(async () =>
            {
               await scriptingHost.Run();
            });
        }

        private void ScriptButton_Click(object sender, EventArgs e)
        {
            scriptingHost.ExecuteAsync(ScriptTextBox.Text);
        }

        private void ScriptOpenButton_Click(object sender, EventArgs e)
        {
            if (ScriptOpenFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = ScriptOpenFileDialog.FileName;
            string fileText = File.ReadAllText(filename);
            scriptingHost.ExecuteAsync(fileText);
        }
    }
}
