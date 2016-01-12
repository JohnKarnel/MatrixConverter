using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MatrixConverter
{
    public partial class FormMain : Form
    {
        int _cols; //кількість колонок у вхідній матриці зв'язків
        int _rows; //кількість рядків у вхідній матриці зв'язків
        Random x = new Random();

        public FormMain()
        {
            InitializeComponent();
        }
        #region Ініціалізація першої таблиці
        private void FillFirstMatrix(DataGridView grid)
        {
            InitializeGridSize(grid, true);
            InitiaizeRowsFormat(grid);
            InitializeColsFormat(grid);
            GridVisualisation(grid);
        }
        private void InitializeGridSize(DataGridView grid, bool isInput)
        {
            grid.ColumnCount = _cols + 1;
            grid.RowCount = (isInput) ? _rows + 1 : _cols + 1;
            grid[0, 0].ReadOnly = true;
        }

        private void InitiaizeRowsFormat(DataGridView grid)
        {
            for (int i = 0; i < _cols; i++)
            {
                grid[i + 1, 0].ReadOnly = true;
                grid[i + 1, 0].Value = "v" + (i + 1);
            }
        }
        private void InitializeColsFormat(DataGridView grid)
        {
            for (int i = 0; i < _rows; i++)
            {
                grid[0, i + 1].ReadOnly = true;
                grid[0, i + 1].Value = "e" + (i + 1);
            }
        }

        private void GridVisualisation(DataGridView grid)
        {
            for (int i = 0; i < _cols; i++)
                for (int j = 0; j < _rows; j++)
                {
                    grid[i + 1, j + 1].Style.BackColor = Color.White;
                    grid[i + 1, j + 1].Value = 0;
                    grid[i + 1, j + 1].ReadOnly = false;
                }
        }
        #endregion

        #region Ініціалізація другої таблиці
        private void FillSecondMatrix(DataGridView grid)
        {
            InitializeGridSize(grid, false);
            SecondGridFormat();
            MakeZeroDiagonal();
        }

        private void SecondGridFormat()
        {
            for (int i = 0; i < _cols; i++)
                dataGridViewOutMatrix[i + 1, 0].Value = "v" + (i + 1);
            for (int i = 0; i < _cols; i++)
                dataGridViewOutMatrix[0, i + 1].Value = "v" + (i + 1);
        }

        private void MakeZeroDiagonal()
        {
            for (int i = 0; i < _cols; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    dataGridViewOutMatrix[i + 1, j + 1].Value = 0;
                }
            }
        }
        #endregion

        #region Заповнення рядка вхідної таблиці
        private void FillRow(int i) 
        {
            FillRowWithZeroes(i);
            FillRowWithOnes(i);
        }

        private void FillRowWithZeroes(int i)
        {
            for (int k = 0; k < _cols; k++)
                dataGridViewInMatrix[k + 1, i + 1].Value = 0;
        }

        private void FillRowWithOnes(int i)
        {
            int count = 0;
            for (int j = 0; j < _cols; j++)
            {
                if (count == 2) break;
                count = RandomFIllRowWithOnes(i, j, count, x);
                AdditionalFillingOfRow(i, x, count, j);
            }
        }

        private void AdditionalFillingOfRow(int i, Random x, int count, int j)
        {
            if (count == 1 && j == _cols - 1)
                FillRow(i);
        }

        private int RandomFIllRowWithOnes(int i, int j, int count, Random x)
        {
            dataGridViewInMatrix[j + 1, i + 1].Value = x.Next(0, 2);
            if (dataGridViewInMatrix[j + 1, i + 1].Value.Equals(1))
                count++;
            return count;
        }
        #endregion

        #region Перевірка правильності завповнення вхідної таблиці
        //функція, що перевіряє чи заповнений радок 2-ма одниницями
        private void RevisionCountOfOnesSymbols(DataGridViewCellCancelEventArgs e)
        {
            int count = 0;
            for (int j = 0; j < _cols; j++)
            {
                if (Convert.ToInt16(dataGridViewInMatrix[j + 1, e.RowIndex].Value) == 1)
                    count++;
            }
            if (count == 2 && Convert.ToInt16(dataGridViewInMatrix[e.ColumnIndex, e.RowIndex].Value) == 0)
                e.Cancel = true;
        }

        //функція, що перевіряє формат введення в клітинку
        private void FormatEditRevision(DataGridViewCellEventArgs e)
        {
            if (dataGridViewInMatrix[e.ColumnIndex, e.RowIndex].ReadOnly == false)
            {
                Convert.ToInt16(dataGridViewInMatrix[e.ColumnIndex, e.RowIndex].Value);
                dataGridViewInMatrix[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Black;
            }
        }

        //функція, що перевіряє, чи введене число не більше 1
        private void NumberEditRevision(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 && e.RowIndex != 0 && dataGridViewInMatrix[e.ColumnIndex, e.RowIndex].Value != null)
                if (Convert.ToInt16(dataGridViewInMatrix[e.ColumnIndex, e.RowIndex].Value) != 1)
                {
                    if (Convert.ToInt16(dataGridViewInMatrix[e.ColumnIndex, e.RowIndex].Value) == 0)
                    {
                        dataGridViewInMatrix[e.ColumnIndex, e.RowIndex].Value = 0;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Недопустиме число для вводу! Введіть значення ще раз", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dataGridViewInMatrix[e.ColumnIndex, e.RowIndex].Value = 0;
                        return;
                    }
                }
        }

        //функція перевірки кожного рядка вхідної матриці на те, щоб у рядку не було однієї одиниці
        private bool RevisionFirstMatrixOfOneCount()
        {
            for (int i = 1; i < dataGridViewInMatrix.RowCount; i++)
            {
                int count = 0;
                for (int j = 1; j < dataGridViewInMatrix.ColumnCount; j++)
                {
                    if (Convert.ToInt16(dataGridViewInMatrix[j, i].Value) == 1)
                        count++;
                }
                if (count == 1)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Перетворення вхідної матриці у вихідну
        private void ConvertInputMatrix()
        {
            FillSecondMatrix(dataGridViewOutMatrix);
            int index1 = 0; //номер рядка(стовбця) в вихідній матриці
            int index2 = 0; //норем стовбця(рядка) в вихідній матриці
            for (int i = 1; i < dataGridViewInMatrix.RowCount; i++)
                for (int j = 1; j < dataGridViewInMatrix.ColumnCount; j++)
                {
                    if (Convert.ToInt16(dataGridViewInMatrix[j, i].Value) == 1)
                        index1 = j;
                    else
                        continue;
                    for (int k = j + 1; k < dataGridViewInMatrix.ColumnCount; k++)
                        if (Convert.ToInt16(dataGridViewInMatrix[k, i].Value) == 1)
                        {
                            index2 = k;
                            break;
                        }
                    if (Convert.ToInt16(dataGridViewOutMatrix[index1, index2].Value) == 0)
                    {
                        dataGridViewOutMatrix[index1, index2].Value = 1;
                        dataGridViewOutMatrix[index2, index1].Value = 1;
                        break;
                    }
                    else
                    {
                        dataGridViewOutMatrix[index1, index2].Value = Convert.ToInt16(dataGridViewOutMatrix[index1, index2].Value) + 1;
                        dataGridViewOutMatrix[index2, index1].Value = Convert.ToInt16(dataGridViewOutMatrix[index2, index1].Value) + 1;
                        break;
                    }

                }
        }
        #endregion

        #region Події на натискання кнопок
        //подія, що виконується при введені значення у вхідну таблицю 
        private void dataGridViewInMatrix_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                RevisionCountOfOnesSymbols(e);
            }
            catch
            {
                return;
            }
        }

        //подія, що виконується при зміні значення у вхідній таблиці
        private void dataGridViewInMatrix_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormatEditRevision(e);
            }
            catch
            {
                MessageBox.Show("Невірний формат вводу! Введіть значення у числовому форматі", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridViewInMatrix[e.ColumnIndex, e.RowIndex].Value = 0;
                return;
            }
            NumberEditRevision(e);
         }
        
        //подія, що виконується при натисканні кнопки рандомного заповнення вхідної матриці 
        private void btnFill_Click(object sender, EventArgs e)
        {
            if (dataGridViewInMatrix.ColumnCount == 0)
            {
                MessageBox.Show("Створіть спочатку матрицю зв'язків!", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            for (int i = 0; i < _rows; i++)
            {
                FillRow(i);
            }
        }

        //подія, що виконується рпи натисканні кнопки закриття програми
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //подія, що виконується при натисканні кнопки створення пустої вхідної матриці 
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                _cols = Convert.ToInt16(textBox2.Text);
                _rows = Convert.ToInt16(textBox3.Text);
            }
            catch (FormatException)
            {
                if (textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Заповніть всі поля!", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show("Невірний формат вводу!", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Text = "";
                    textBox3.Text = "";
                    return;
                }
            }
            FillFirstMatrix(dataGridViewInMatrix);
        }

        //подія, що виконується при натисканні кнопки перетворення матриці зв'язків у матрицю з'єднань
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (dataGridViewInMatrix.ColumnCount == 0)
            {
                MessageBox.Show("Створіть та заповніть спочатку матрицю зв'язків!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            for (int i = 1; i < dataGridViewInMatrix.RowCount; i++)
                for (int j = 1; j < dataGridViewInMatrix.ColumnCount; j++)
                    if (dataGridViewInMatrix[j, i].Value == null)
                    {
                        MessageBox.Show("Заповніть матрицю зв'язків повністю!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
            if (RevisionFirstMatrixOfOneCount())
            {
                MessageBox.Show("Матрицю зв'язків заповнено неправильно!", "Помилка",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ConvertInputMatrix();
        }

        //подія, що виконується при натисканні пункту меню "Про програму"
        private void ToolStripMenuAboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   Програма створена для прямого переведеня матриці зв'язків(інцидентності)"+
                "у матрицю з'єднань(суміжності)\n\rдля довільного графа.\n\r   Для дористування програмою"+
                " зверніться до інструкції.", "Про програму", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        //подія, що виконується при натисканні пункту меню "Інструкція"
        private void ToolStripMenuInstruction_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Заповніть в правому лівому куту форми 2 поля.\n\r    Формат введеня - числа " +
                "від 0 до n, де n " + (char)(0x2208) + " N.\n\r"+
                "2. Натисніть на кнопку \"Створити пусту матрицю зв'язків\".\n\r"+
                "3. Якщо ви бажаете перевірити роботу програми в демо-режимі, \n\r    натисніть кнопку" +
                " \"Заповнити випадково матрицю зв'язків\".\n\r" +
                "4. Натисніть кнопку \"Перетворити матрицю зв'язків у матрицю \n\r    з'єднань\".\n\r" +
                "5. Якщо ви хочете ввести вхідні дані вручну, то після виконання\n\r    пункту 2, заповнінь" +
                " матрицю зв'язків одиницями власноруч.\n\r"+
                "6. Якщо ви вже заповнили матрицю і хочете її виправити, то\n\r   спочатку треба ввести нулі замість" +
                " одиниць, а потім вже вводити\n\r   одиниці", "Інструкція", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        #endregion
    }
}
