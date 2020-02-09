using System;
using System.IO;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SnakeGame
{
    public partial class HighScore : Form
    {
        static Label[] lbl;
        static string path;
        
        public HighScore()
        {
            InitializeComponent();
            lbl = new Label[] { lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8, lbl9, lbl10 };
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Ilan Oyunu_Yuksek Xal.txt";
        }

        public static void CreatePath()
        {
            if (!File.Exists(path))
            {
                StreamWriter sw;
                sw = File.CreateText(path);
                sw.Close();
            }
        }

        public static void Write(int score)
        {
                StreamWriter sw;
                sw = File.AppendText(path);
                sw.WriteLine(score);
                sw.Close();
        }

        public static void Read()
        {
            List<int> highscore = new List<int>();

            try
            {
                StreamReader sr = new StreamReader(path);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    try
                    {
                        if (int.Parse(line, CultureInfo.InvariantCulture.NumberFormat) >= 0 && int.Parse(line, CultureInfo.InvariantCulture.NumberFormat) <= 1000)
                            highscore.Add(int.Parse(line, CultureInfo.InvariantCulture.NumberFormat));
                        else
                        {
                            MessageBox.Show("\"" + path + "\" yoluna kənardan qeyri-real ədəd daxil edilmişdir. Bu yolu izləyin və mövcud mətn faylındakı uyğunsuz yazını silin.", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            Application.Exit();
                            break;
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("\"" + path + "\"  yoluna kənardan düzgün olmayan yazı daxil edilmişdir. Bu yolu izləyin və mövcud mətn faylındakı uyğunsuz yazını silin.", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        Application.Exit();
                        break;
                    }

                    catch (OverflowException)//int max value: 2147483647, int min value: -2147483648
                    {
                        MessageBox.Show("\"" + path + "\" yoluna kənardan qeyri-real ədəd daxil edilmişdir. Bu yolu izləyin və mövcud mətn faylındakı uyğunsuz yazını silin.", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        Application.Exit();
                        break;
                    }
                }
                sr.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("\"" + path + "\"  yolu mövcud deyil. Oyunun yenidən başladılacaqdır.", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                Application.Restart();
            }

            int[] arr = highscore.ToArray();
            Array.Sort(arr);
            Array.Reverse(arr);

            if(lbl.Length < arr.Length)
                for (int i = 0; i < lbl.Length; i++)
                    lbl[i].Text = Convert.ToString(arr[i], CultureInfo.InvariantCulture.NumberFormat);
            else
                for (int i = 0; i < arr.Length; i++)
                    lbl[i].Text = Convert.ToString(arr[i], CultureInfo.InvariantCulture.NumberFormat);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            File.Delete(path);

            for (int i = 0; i < lbl.Length; i++)
            {
                lbl[i].Text = "...";
            }

            CreatePath();
        }
    }
}