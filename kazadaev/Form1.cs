using Microsoft.EntityFrameworkCore;
using kazadaev.Models;
using System.Runtime.InteropServices;

namespace kazadaev
{
    public partial class Avtorisation : Form
    {
        public Avtorisation()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.textBox2.KeyDown += TextBox2_KeyDown;
        }

        private void TextBox2_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { button1.PerformClick(); }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Ispr2525KazadaevNvCursovoiContext context = new();
                User? user = context.Users
                    .Where(user => user.UsersName == textBox1.Text && user.Password == textBox2.Text)
                    .FirstOrDefault();
                if (user.Role == "Администратор")//
                {
                    //MessageBox.Show(user.Role);
                    lbRole.Text = user.Role;
                    await Task.Delay(3000);
                    Admin Admin = new Admin(this);
                    Admin.Show();
                }
                if (user.Role == "Зам директора")
                {
                    //MessageBox.Show(user.Role);
                    lbRole.Text = user.Role;
                    await Task.Delay(3000);
                    Deputy_Director form3 = new Deputy_Director(this);
                    form3.Show();
                }
                if (user.Role == "Директор")
                {
                    //MessageBox.Show(user.Role);
                    lbRole.Text = user.Role;
                    await Task.Delay(3000);
                    director form3 = new director(this);
                    form3.Show();
                }
                this.Hide();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неправильный логин или пароль:");
                LogException(ex);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
        public static void LogException(Exception ex)
        {
            string logDirectory = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "MyApp",
                "Logs"
            );

            string logPath = Path.Combine(logDirectory, "errors.log");

            try
            {
                Directory.CreateDirectory(logDirectory);

                File.AppendAllText(
                    logPath,
                    $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Исключение:\n{ex}\n\n"
                );
            }
            catch (Exception writeEx)
            {
                MessageBox.Show($"Ошибка записи лога: {writeEx.Message}");
            }
        }

        private void Avtorisation_Load(object sender, EventArgs e)
        {

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bt_max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void bt_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
