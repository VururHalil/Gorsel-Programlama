using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               var str = EncryptToBase64(textBox1.Text);
                textBox1.Text = str;
        }
        public static string EncryptToBase64(string text)
{
    byte[] EncryptAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(text);
    string value = System.Convert.ToBase64String(EncryptAsBytes);
    return value;
}
        public static string DecryptToBase64(string text)
{
    byte[] DecryptAsBytes = System.Convert.FromBase64String(text);
    string value = System.Text.ASCIIEncoding.ASCII.GetString(DecryptAsBytes);
    return value;
}

        private void button2_Click(object sender, EventArgs e)
        {
            var str = DecryptToBase64(textBox1.Text);
            MessageBox.Show(str);
        }
    }
}