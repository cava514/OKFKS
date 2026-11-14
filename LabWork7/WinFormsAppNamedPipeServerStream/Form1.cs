using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppNamedPipeServerStream
{
    public partial class Form1 : Form
    {
        ScriptingHost scriptingHost = new();
        BindingList<Event> Events1 = new()
        {
            new() { Name = "Несчастливый день", DateTime = DateTime.Now, Description = "Я всё ..." },
            new() { Name = "Счастливый день", DateTime = DateTime.Now, Description = "За моё счастье" },
            new() { Name = "Подъем", DateTime = DateTime.Now, Description = "ВАААААААААААГХ" },
            new() { Name = "Размышления", DateTime = DateTime.Now, Description = "Я всего лишь хочу быть. СЧАСТЛИВЫМ!" },
        };
        public Form1()
        {
            InitializeComponent();

            EventsListBox.Items.Clear();
            EventsListBox.DataSource = Events1;

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

        private void EventButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Equals(null) && EventDateTimePicker.Value.Equals(null) && DescriptionTextBox.Text.Equals(null))
                MessageBox.Show("Не все данные заполнены", "Ошибка");
            else
            {
                Event event1 = new() { Name = NameTextBox.Text, DateTime = EventDateTimePicker.Value, Description = DescriptionTextBox.Text };
                Events1.Add(event1);
            }
        }

        public class Event
        {
            public string Name { get; set; }
            public DateTime DateTime { get; set; }
            public string Description { get; set; }
        }
    }
}
