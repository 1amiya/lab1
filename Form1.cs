using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private object input;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // Опис що відбуваються після завантаження форми
        {
            label_result2.Text = "";
            button_XY.Text = "Ok";
            label_result_2a.Text = "";
            label_result_4a.Text = "";
            label_result_32.Text = "";
            label_result_4.Text = "";
            button_day.Text = "ok";
            label_day.Text = "result";
            label_day_r.Text = "";
        }
        private void btok_Click(object sender, EventArgs e) // Опис дій, що відбуваються після натискання кнопки в першій формі
        {
            double x = Convert.ToDouble(textBox_x.Text); // Введення даних від користувача
            double y = Convert.ToDouble(textBox_y.Text);
            double result = Math.Pow(1-Math.Tan(x),1/Math.Tan(x))+Math.Cos(x-y); // Розрахунок відповіднох до формули в завданні
            label_result2.Text = result.ToString(); // Виведення даних
        }

       

        private void button_A_Click(object sender, EventArgs e)// Опис дій, що відбуваються після натискання кнопки в другій формі
        {
            double a = Convert.ToDouble(textBox_a2.Text); // Введення даних від користувача
            double a2 = a * a; // 1-ша Операція
            double a4 = a2 * a2; // 2-га оперія
            double result = a4 * a4; // 3-ья операція 
            double result2 = result * a2; // 4-а для отримання a^10
            label_result_2a.Text = result.ToString(); // Виведення a^8
            label_result_4a.Text = result2.ToString(); // Виведення a^10

        }

        private void button_3_Click(object sender, EventArgs e)// Опис дій, що відбуваються після натискання кнопки в третій формі
        {
            double a = Convert.ToDouble(textBox_a3.Text);// Введення даних 
            double b = Convert.ToDouble(textBox_b3.Text);
            double c = Convert.ToDouble(textBox_c3.Text);
            bool y = false; 
            if (a+b==0) { y = true; } // Пошук взаємопротилеєних, за логікою що їх сума дорівнює 0
            if (a  + c == 0) { y = true; }
            if (c + b == 0) { y = true; }
            if (y == true) { label_result_32.Text = "+"; } else label_result_32.Text = "-"; // Якщо під час пошуку булівська змінна набула значення true, то виводиться +, інакше -
        }

        private void button1_Click(object sender, EventArgs e) // Опис дій, що відбуваються після натискання кнопки в четвертій формі
        {
            double a1 = Convert.ToDouble(textBox1.Text); // Введення даних 
            double a2 = Convert.ToDouble(textBox2.Text);
            double a3 = Convert.ToDouble(textBox3.Text);
            double a4 = Convert.ToDouble(textBox4.Text);
            double result = 0;
            if (a1 != a4) { if (a1 != a2) { result = 1; } else { result = 4; } } // Пошук відмінної змінної, порівнюючи спочатку дві змінні, потім третью
            if (a2!=a3) { if (a2!=a1) { result = 2; } else { result = 3; } }
            label_result_4.Text = result.ToString();
        }

        private void button_day_Click(object sender, EventArgs e) // Опис дій, що відбуваються після натискання кнопки в пятій формі
        {
            double dayOfYear = Convert.ToDouble(TextBox_Day.Text); // 
            DateTime date = new DateTime(DateTime.Now.Year, 1, 1).AddDays(dayOfYear - 1);// Знаходимо місяць і число, використовуючи стандартну бібліотеку C#
            int month = date.Month;
            int day = date.Day;           
            label_day_r.Text =  day.ToString() + " " +  GetMonthName(month).ToString();// Виведденя даних 
        }

        private object GetMonthName(int month) // Використовуючи оператор switch виводимо місяць відповідно до його порядкового номеру
        {
            switch (month)
            {
                case 1: return "січня";
                case 2: return "лютого";
                case 3: return "березня";
                case 4: return "квітня";
                case 5: return "травня";
                case 6: return "червня";
                case 7: return "липня";
                case 8: return "серпня";
                case 9: return "вересня";
                case 10: return "жовтня";
                case 11: return "листопада";
                case 12: return "грудня";
                default: return "";
            }
        }

        private void button_array_Click(object sender, EventArgs e) // шоста
        {
            string String = textBox_array.Text; // Створення змінної String для зберігання рядка (масиву чисел) введеного користувачем
            string[] inputArray = String.Split(' '); // Розділення рядку, на масив Рядків, за допомогою функції Split. Розділ відбувається залежно від пробілу між числами
            int[] array = new int[inputArray.Length]; // Створення масиву цілих чисел
            int min=0; int max=0; int mult=0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                array[i] = int.Parse(inputArray[i]); // Перетворення чисел з string в int 
                if (i == 0) { min = array[i]; max = array[i]; }
                if (min > array[i]) { min = array[i]; } // пошук мінімального елемента в массиві 
                if (max < array[i]) { max = array[i]; } // пошук максимального
            }
            if (array[0] >= 0) { mult = min * min; } else { mult = max * max; } // залежно від того чи послідовність додатня чи від'ємна змінна набуває різних значень
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * mult;
            }
            String = string.Join(" ", array); // перетворення массиву в тип string 
            label_array_result.Text = String;
        }
        private void button_string_Click(object sender, EventArgs e) // 7-а
        {
            string String = textBox_string.Text; // Введення даних 
            string NewString = ""; // Створення пустого массиву для майбутнього введення даних
            foreach (char letter in String) // Кожен елемент що не буду * буде дублюватися в массив NewString
            {
                if (letter != '*')
                {
                    NewString += new string(letter, 2);
                }
            }
            label_string_result.Text = NewString;
        }

        
    }
}
