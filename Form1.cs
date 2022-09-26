using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaferPilotBrothersForm
{

    public partial class FormGame : Form
    {
        //сообщение, которое выводится, когда игра пройдена
        string message = "Сейф открылся.\n" +
                    "Перезапустить игру?";
        string titleMsg = "Сделай выбор";
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;

        //рандом, для присваивания изображений к кнопкам в случайном порядке
        Random random = new Random();

        //объект таблицы на форме
        TableLayoutPanel playing_field = new TableLayoutPanel();

        //лист изображений
        List<Image> test = new List<Image>()
        {
            Properties.Resources.Gorizontal,
            Properties.Resources.Vertical
        };

        //звуки игры
        SoundPlayer klick = new SoundPlayer(Properties.Resources.buttonKlick1);
        SoundPlayer open = new SoundPlayer(Properties.Resources.open1);

        public FormGame()
        {
            InitializeComponent();
            numSize.Controls[0].Visible = false;

        }

        //метод для игры
        private void Game(int size)
        {

            //расположение таблицы, относительно формы (левый верхний угол)
            playing_field.Location = new Point(0, 0);
            playing_field.AutoSize = false;
            playing_field.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            playing_field.Dock = DockStyle.Fill;

            //процентное соотношение кнопок(чтобы все кнопки были равные по размеру между собой)
            float percent = 100 / size;

            //цикл добавления кнопок в таблицу
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Button button = new Button();
                    button.Dock = DockStyle.Fill;
                    button.BackColor = Color.Turquoise;
                    button.Click += btn_click;
                    playing_field.Controls.Add(button, i, j);
                    playing_field.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, percent));
                    playing_field.RowStyles.Add(new RowStyle(SizeType.Percent, percent));
                    button.BackgroundImage = test[random.Next(0, 2)];
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }

            Controls.Add(playing_field);
        }

        //событие по нажатию кнопки
        private void btn_click(object sender, EventArgs e)
        {

            klick.Play();
            //счетчики, необхожимый для определения, что игра пройдена
            int countTrue = 0;
            int countFalse = 0;

            //меняем кнопку
            if (((Button)sender).BackgroundImage == test[0])
            {
                ((Button)sender).BackgroundImage = test[1];
            }
            else
            {
                ((Button)sender).BackgroundImage = test[0];
            }

            //цикл подмены кнопок по гормзонтали и вертикали 
            foreach (Control control in playing_field.Controls.OfType<Button>())
            {
                if (playing_field.GetRow(control) == playing_field.GetPositionFromControl((Button)sender).Row)
                {
                    if (control.BackgroundImage == test[0])
                        control.BackgroundImage = test[1];
                    else
                        control.BackgroundImage = test[0];
                }
                if (playing_field.GetColumn(control) == playing_field.GetPositionFromControl((Button)sender).Column)
                {
                    if (control.BackgroundImage == test[0])
                        control.BackgroundImage = test[1];
                    else
                        control.BackgroundImage = test[0];
                }
            }


            //проверка всех кнопок
            foreach (Control control in playing_field.Controls.OfType<Button>())
            {
                if (control.BackgroundImage == test[0])
                    countTrue++;
                else if (control.BackgroundImage == test[1])
                    countFalse++;

            }
            if (countFalse == (playing_field.ColumnCount * playing_field.RowCount))
            {
                open.Play();

                DialogResult result = MessageBox.Show(message, titleMsg, buttons);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();

                }
                else
                {
                    this.Close();
                }

            }
            if (countTrue == (playing_field.ColumnCount * playing_field.RowCount))
            {
                open.Play();

                DialogResult result = MessageBox.Show(message, titleMsg, buttons);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();

                }
                else
                {
                    this.Close();
                }

            }
            countFalse = 0;
            countTrue = 0;

        }

        private void numSize_ValueChanged(object sender, EventArgs e)
        {
            
            if (numSize.Value <= 1)
            {
                MessageBox.Show("Нельзя вводить число меньше или равное 1");
                numSize.Value = 2;
            }
            if (numSize.Value % 2 != 0)
            {
                numSize.Value++;
            }
        }

        private void butStartGame_Click(object sender, EventArgs e)
        {
            GameName.Visible = false;
            rules.Visible = false;
            numSize.Visible = false;
            butStartGame.Visible = false;
            pictureBox1.Visible = false;
            Game((int)numSize.Value);
        }
    }
}

