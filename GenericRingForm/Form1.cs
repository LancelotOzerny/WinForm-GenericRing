using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericRingForm
{
    public partial class Form1 : Form
    { 
        // Создаем массив с 20 количеством элементов
        GenericRing<string> ring = new GenericRing<string>(20);

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            string value = input_addItem.Text;

            if (value == string.Empty)
            {
                MessageBox.Show("не оставляйте пустым значение поля!");
                return;
            }

            if (ring.Count >= ring.MaxCount)
            {
                MessageBox.Show("Количество элементов превышает максимальное!");
                return;
            }

            ring.Push(value);
            UpdateItems();
        }

        /// <summary>
        /// Метод, который обновляет список предметовв Listbox
        /// </summary>
        private void UpdateItems()
        {
            dataValues.Items.Clear();

            foreach (string item in ring)
            {
                dataValues.Items.Add(item);
            }

            label_ItemCounts.Text = $"Количество элементов: {ring.Count}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ring.Count > 0)
            {
                ring.Next(); // Находим следующий элемент, если их больше 0

                string value = ring.Head();

                // И если значние не пустое то выводим
                if (value != string.Empty)
                {
                    input_CurrentElement.Text = value;
                }
            }
            else
            {
                // Приколюшка. Если не понравится - уберешь. Но преподов забавляет)
                // Разряжает обстановку.
                MessageBox.Show(@"Кольцо пустое! Попробуйте вставить элементы или просто позаимствуйте у Фродо.");
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            int index = -1;

            // Пытаемся спарсить вводимое с поля значение
            if (int.TryParse(input_findedIndex.Text, out index))
            {
                try
                {
                    // Если получается - выводим его
                    string value = ring.Get(index);
                    input_findedResult.Text = value;
                }
                catch (Exception)
                {
                    // А нет - выводим ошибку
                    MessageBox.Show("Убедитесь в количестве элементов!");
                }

            }
            else
            {
                // Если не поулчился парсинг - скорее всего там не только цифры
                MessageBox.Show("Проверьте правильность индекса!");
            }
        }
    }
}
