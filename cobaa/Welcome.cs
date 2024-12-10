using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Projectsms;

namespace cobaa
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcome()); // Ganti "Welcome" dengan form utama Anda
        }
    }
    public partial class Welcome : Form
    {
        datalayer dl;
        public Welcome()
        {
            dl = new datalayer();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=Aurelius_22;Database=Jagad";
            string qry = "SELECT i_id FROM public.welcome WHERE username = @username AND password = @password";

            //string loginUsername = "+ login_username.Text +";
            //string loginPassword = "+ login_password.Text+";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open(); // Buka koneksi

                    using (NpgsqlCommand cmd = new NpgsqlCommand(qry, conn))
                    {
                        // Tambahkan parameter untuk mencegah SQL Injection
                        cmd.Parameters.AddWithValue("@username", login_username.Text);
                        cmd.Parameters.AddWithValue("@password", login_password.Text);

                        // Eksekusi query dan baca hasil
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string s_id = reader["i_id"].ToString();
                                Console.WriteLine("ID ditemukan: " + s_id);
                                Editprofile sd = new Editprofile();
                                sd.Show();
                            }
                            else
                            {
                                Console.WriteLine("Username atau password salah.");
                                MessageBox.Show("Username or Password doesnt match, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Regis sForm = new Regis();
            sForm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
