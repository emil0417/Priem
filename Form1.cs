using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Приемка_2._0
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckBox[] a = new CheckBox[24] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8, checkBox9, checkBox10, checkBox11, checkBox12, checkBox13, checkBox14, checkBox15, checkBox16, checkBox17,
            checkBox18, checkBox19, checkBox20, checkBox21,checkBox22, checkBox23, checkBox24};
            string[] b = new string[24];

            b[0] = "Ваше заявление было проверено оператором. Все недочеты были исправлены.";
            b[1] = "Просим вас заполнить СНИЛС во вкладке \"Основная информация\".";
            b[2] = "Вам необходимо заполнить вкладку \" Проживание\". После этого не забудьте нажать зеленую кнопку \" Сохранить\" на этой вкладке.";
            b[3] = "Учебное заведение должно быть заполнено как в аттестате. (Было изменено оператором)";
            b[4] = "У вас отсутсвуют баллы ЕГЭ во вкладке \"Вступительные испытания\". Пожалйуста, проставьте их и после этого не забудьте нажать зеленую кнопку \"Сохранить\" на этой вкладке. ";
            b[5] = "Если у вас имеются индивидуальные достижения, проставьте их во вкладке \"Индивидуальные достижения\".";
            b[6] = "У вас отсутсвует прописка. Просим вас прикрепить прописку к паспорту. ";
            b[7] = "У вас отсутсвует приложение к аттестату. Просим вас прикрепить его.";
            b[8] = "\"Согласие на обработку ПД\", \"Заявление\", \"Согласие на зачисление\" заполняются автоматически в зависимости от той информации, которую вы указали в предыдущих вкладках. Вам остается поставить только подписи и расшифровки синей ручкой. Просим вас заново скачать документы, поставить подписи, прикрепить их и отправить заявление в ВУЗ. ";
            b[9] = "\"Согласие на обработку ПД\" заполняется автоматически. Вам необходимо поставить лишь подпись и расшифровку синей ручкой.";
            b[10] = "\"Заявление\" заполняется автоматически. Вам необходимо поставить лишь подпись и расшифровку синей ручкой";
            b[11] = "У вас отсутствует подпись на первой странице\"Заявления\". ";
            b[12] = "У вас отсутствует подпись на второй странице\"Заявления\".";
            b[13] = "\"Согласие на зачисление\" заполняется автоматически. Вам необходимо поставить лишь подпись и расшифровку синей ручкой.";
            b[14] = "В договоре присутсвуют ошибки. Образец заполнения договора будет отправлен вам на электронную почту.";
            b[15] = "В договоре дату на первой странице ставить не нужно. ";
            b[16] = "В пункте 1.1 имеется ошибка. ";
            b[17] = "В пункте 1.1 не записана форма получения образования. ";
            b[18] = "Срок обучения по индивидульному плану в пункте 1.2 не записывается. ";
            b[19] = "Вы не вычеркнули лишнее в пункте 1.3 . ";
            b[20] = "В пункте 3.1, 3.2 неправильно указана стоимость обучения. ";
            b[21] = "В пункте 8.2/8.3 отсутствует дата выдачи. ";
            b[22] = "В пункте 8.2/8.3 отсутствует подпись.";
            b[23] = "Просим вас еще раз прикрепить сканы документов, так как операторы не могут проверить данные по ним. ";

            richTextBox1.Text = "";
            switch (listBox1.SelectedItem)
            {
                case ("10:00-12:00"):
                    richTextBox1.Text = "Доброе утро! ";
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i].Checked == true)
                        {
                            richTextBox1.Text += b[i] + "\n";
                        }
                    }
                    break;
                case ("12:00-15:00"):
                    richTextBox1.Text = "Добрый день! ";
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i].Checked == true)
                        {
                            richTextBox1.Text += b[i] + "\n";
                        }
                    }
                    break;
                case ("15:00-17:00"):
                    richTextBox1.Text = "Добрый вечер! ";
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i].Checked == true)
                        {
                            richTextBox1.Text += b[i] + "\n";
                        }
                    }
                    break;
                case ("17:00-24:00"):
                    richTextBox1.Text = "Извините, но рабочий день Приемной комиссии окончен. ";
                    break;
                default:
                    MessageBox.Show("Выберите время", "Ошибка");
                    break;
            }

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                string vremya = DateTime.Now.ToShortTimeString();
                textBox1.Text = vremya;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckBox[] a = new CheckBox[24] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8, checkBox9, checkBox10, checkBox11, checkBox12, checkBox13, checkBox14, checkBox15, checkBox16, checkBox17,
            checkBox18, checkBox19, checkBox20, checkBox21,checkBox22, checkBox23, checkBox24};

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Checked == true)
                {
                    a[i].Checked = false; 
                }
            }

            richTextBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
