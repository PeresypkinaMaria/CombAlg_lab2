using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombAlg_lab2
{
    public partial class Form1 : Form
    {
        double N, M, V; //размер пустыни, бака и канистры

        string overcome = "Машина проехала расстояние ";
        string leave_canister = " и оставила канистру";
        //string take_canister = "Машина взяла оставленную канистру";
        string return_to_base = "Машина вернулась на базу";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("18. «Переезд пустыни». Дана пустыня – N км. В начале располагается автомобиль с баком – M л," +
                "который может перевозить с собой 2 канистры - по V (N > M > V) л каждая. Считая, что в начале пути имеется" +
                "достаточное количество топлива, необходимо определить кол-во используемого топлива и последовательность" +
                "передвижения автомобиля по пустыни для пересечения пустыни с минимальными затратами. Расход топлива считать равным 1л/км." +
                "Подсказка: использовать метод динамического программирования и рассмотреть задачу с финиша.");
        }

        //проверка ввода чисел
        private bool CheckVal()
        {
            if (!Double.TryParse(tbDesertSize.Text, out N))
            {
                MessageBox.Show("Введите число в поле 'Размер пустыни'!");
                return false;
            }
            if (!Double.TryParse(tbTankSize.Text, out M))
            {
                MessageBox.Show("Введите число в поле 'Размер бака'!");
                return false;
            }
            if (!Double.TryParse(tbCanisterSize.Text, out V))
            {
                MessageBox.Show("Введите число в поле 'Размер канистры'!");
                return false;
            }
            return true;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            tbResult.Text = "";
            Task();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbDesertSize.Text = "";
            tbTankSize.Text = "";
            tbCanisterSize.Text = "";
            tbResult.Text = "";
        }

        //проверка на соответствие условию N > M > V
        private bool CheckInequality()
        {
            if (!CheckVal())
                return false;
            if (N < M || N < V || M < V)
            {
                MessageBox.Show("Значения не соответствуют условию 'Размер пустыни > Размер бака > Размер канистры'!");
                return false;
            }
            return true;
        }

        void Task()
        {
            if (!CheckInequality())
                MessageBox.Show("Исправьте необходимые значения!");
            else
            {
                string result_str = "";
                if ((M + 2 * V) >= N)
                    result_str = "Количество использованного топлива: " + N + "\r\nМашина пересекла пустыню.";
                else
                {
                    double need_track = (N - (M + 2 * V));
                    double track = 0.0;
                    double cnt_fuel = 0.0;
                    double[] val_of_departure = new double[20];
                    for (int i = 1; track < need_track; i++)
                    {
                        track = (M / 2 + i * V / 2);
                        cnt_fuel += (M + i * V + V);
                        val_of_departure[i] = cnt_fuel;
                        result_str += overcome + track.ToString() + leave_canister + "\r\n" + return_to_base + "\r\n";                        
                        for (int j = 1; j < i; j ++)
                        {
                            result_str += "Машина повторяет предыдущие поездки\r\n";
                            cnt_fuel += val_of_departure[j];
                        }
                    }
                    cnt_fuel += N - track;
                    result_str += overcome + (N - track).ToString() + "\r\n" + "Количество использованного топлива: " + cnt_fuel.ToString() + "\r\nМашина пересекла пустыню.";
                }
                tbResult.Text = result_str;
            }
        }
    }
}
