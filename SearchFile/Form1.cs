using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchFile
{

    // TODO:
    // DONE 1. Реализовать поиск файлов по директории, шаблону имени и тексту внутри файла
    // DONE 2. Прикрутить БД, чтобы не терять данные из TextBox при закрытии программы
    // DONE 3. Отобразить в реальном времени какой файл обрабатывается, сколько уже обработано и сколько времени прошло
    // DONE 4. Реализовать остановку и продолжение поиска
    // DONE 5. Реализовать нормальную перезапись textBox-ов при закрытии


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Search search;
        Stopwatch stopWatch;
        static ManualResetEvent pause;
        bool flagForPauseAndResume = true;


        private async void buttonExecute_Click(object sender, EventArgs e)
        {
            BaseSettings();

            search = new Search();
            stopWatch = new Stopwatch();

            stopWatch.Start();

            await Task.Factory.StartNew(() =>
            {
                try
                {
                    foreach (var node in search.Searching(textBoxFullPath.Text, textBoxPattern.Text, textBoxText.Text))
                    {
                        pause.WaitOne();

                        labelFileBeingProcessing.Invoke(new Action(() =>
                        {
                            labelFileBeingProcessing.Text = "FileBeingProcessing: " + node.ToString();
                        }));

                        // "Вызови от своего имени" treeViewMain.Nodes.Add(node)
                        // Подумать, как можно сделать не так топорно
                        treeViewMain.Invoke(new Action(() =>
                        {
                            treeViewMain.Nodes.Add(node);
                        }));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;

            labelTime.Text += ts.ToString();
            labelCountProcessed.Text += search.count;

            buttonSearch.Text = "Search";
            buttonSearch.Enabled = true;
        }

        private void BaseSettings()
        {
            pause = new ManualResetEvent(true);
            flagForPauseAndResume = true;
            labelPauseResume.Visible = false;
            buttonSearch.Text = "Search";
            buttonSearch.Enabled = false;


            treeViewMain.Nodes.Clear();
            labelFileBeingProcessing.Text = "FileBeingProcessing: ";
            labelCountProcessed.Text = "CountProcessed: ";
            labelTime.Text = "Time: ";

            labelCountProcessed.Visible = true;
            labelFileBeingProcessing.Visible = true;
            labelTime.Visible = true;
        }

        private void buttonStopSearch_Click(object sender, EventArgs e)
        {
            if (flagForPauseAndResume)
            {
                pause.Reset();
                flagForPauseAndResume = !flagForPauseAndResume;

                labelPauseResume.Visible = true;
                buttonStopSearch.Text = "Resume";
                buttonSearch.Text = "New Search";
                buttonSearch.Enabled = true;

            }
            else
            {
                labelPauseResume.Visible = false;
                buttonStopSearch.Text = "Stop Search";
                buttonSearch.Text = "Search";

                pause.Set();
                flagForPauseAndResume = !flagForPauseAndResume;
            }
        }

        private void buttonCleanTextBox_Click(object sender, EventArgs e)
        {
            textBoxFullPath.Text = textBoxPattern.Text = textBoxText.Text = String.Empty;

            labelCountProcessed.Text = labelFileBeingProcessing.Text = labelTime.Text = String.Empty;

            treeViewMain.Nodes.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string sqlCommand = "SELECT * FROM [Table]";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\New learn C#\\SearchFile\\SearchFile\\Database.mdf\";Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlCommand, con);

                SqlDataReader reader = command.ExecuteReader();

                List<string> data = new List<string>();

                while (reader.Read())
                {
                    // переделать этот рабочий бред
                    textBoxFullPath.Text = reader.GetValue(0).ToString();
                    textBoxPattern.Text = reader.GetValue(1).ToString();
                    textBoxText.Text = reader.GetValue(2).ToString();
                }
                reader.Close();
            }
        }

        private void AddData(string path, string pattern, string text)
        {
            string sqlCommand = string.Format($"Update [Table] Set InputPath = '{path}', InputPattern = '{pattern}', InputText = '{text}'");

            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\New learn C#\\SearchFile\\SearchFile\\Database.mdf\";Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sqlCommand, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void textBoxFullPath_TextChanged(object sender, EventArgs e)
        {
            AddData(textBoxFullPath.Text, textBoxPattern.Text, textBoxText.Text);
        }

        private void textBoxPattern_TextChanged(object sender, EventArgs e)
        {
            AddData(textBoxFullPath.Text, textBoxPattern.Text, textBoxText.Text);
        }

        private void textBoxText_TextChanged(object sender, EventArgs e)
        {
            AddData(textBoxFullPath.Text, textBoxPattern.Text, textBoxText.Text);
        }
    }
}
