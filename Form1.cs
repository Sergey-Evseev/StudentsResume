/*Lesson 3. Task 1.Вывести на экран свое (краткое !!!) резюме с помощью
последовательности MessageBox'ов (числом не менее трех).
Причем на заголовке последнего должно отобразиться среднее число символов на странице 
(общее количество символов в резюме / количество MessageBox'ов).*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_s_Resume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();                        
        }
        //обработчик события загрузка формы
        private void Form1_Load(object sender, EventArgs e)
        {            
            string[] array = { "Student: Sergey Evseev", "Course: Windows Forms", "Group: CT PV111" };
            int symbolsNumber = 0; //количество символов
            string caption; //строка заголовка бокса
            

            for (int i = 0; i < array.Length; i++)
            {
                symbolsNumber += array[i].Length; //суммируем кол-во симоволов в каждом сообщении


                caption = (array.Length - 1 == i) ? //по достижению конца массива
                    //показывается номер бокса и среднее количество символов:
                    $"MessageBox {i + 1}. " + $"Average symbols quantity: {symbolsNumber / array.Length}                " 
                    //если конец массива не достигнут, то просто номер бокса:
                    : $"MessageBox {i + 1}";
                
                MessageBox.Show(array[i], caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }
    }    
}
