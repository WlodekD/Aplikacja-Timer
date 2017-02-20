using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ExcelLibrary.SpreadSheet;
using ExcelLibrary.CompoundDocumentFormat;

namespace Timer3._0
{
    public partial class Form1 : Form
    {
        int s, m, h;
        int sP, mP, hP;

        private void buttonRaportExcel_Click(object sender, EventArgs e)
        {
            //tworzenie pliku xls
            string file = "ExcelRaport.xls";
            Workbook workbook = new Workbook();
            Worksheet worksheet = new Worksheet("Raport1");
            worksheet.Cells[0, 0] = new Cell(label1.Text);  // lable "Nazwa projektu"
            worksheet.Cells[0, 2] = new Cell(textBox1.Text); // textBox nazwa projektu
            worksheet.Cells[0, 3] = new Cell(label5.Text);   // sekundy
            worksheet.Cells[0, 4] = new Cell(label4.Text);   // minuty
            worksheet.Cells[0, 5] = new Cell(label3.Text);   // godziny
            worksheet.Cells[2, 0] = new Cell(label2.Text);   // Przewidywany czas projektu
            worksheet.Cells[4, 0] = new Cell(labelCzasTrwaniaProjektu.Text);  // Czas trwania projektu
            worksheet.Cells[2, 3] = new Cell(textBoxHours.Text); // godziny : Przewidywany czas projektu
            worksheet.Cells[2, 4] = new Cell(textBoxMinutes.Text); // minuty  : Przewidywany czas projektu
            worksheet.Cells[2, 5] = new Cell(textBoxSeconds.Text); // sekundy : Przewidywany czas projektu
            worksheet.Cells[4, 3] = new Cell(labelHP.Text);  // godziny : Czas trwania projektu
            worksheet.Cells[4, 4] = new Cell(labelMP.Text);  // minuty  : Czas trwania projektu
            worksheet.Cells[4, 5] = new Cell(labelSP.Text);  // sekundy : Czas trwania projektu

            worksheet.Cells.ColumnWidth[0, 1] = 3000;
            workbook.Worksheets.Add(worksheet);
            workbook.Save(file);

            //otwieranie pliku
            Workbook book = Workbook.Load(file);
            Worksheet sheet = book.Worksheets[0];

            for (int rowIndex = sheet.Cells.FirstRowIndex;
                rowIndex <= sheet.Cells.LastRowIndex; rowIndex++)
            {
                Row row = sheet.Cells.GetRow(rowIndex);
                for (int colIndex = row.FirstColIndex;
                    colIndex <= row.LastColIndex; colIndex++)
                {
                    Cell cell = row.GetCell(colIndex);
                }
            }

            MessageBox.Show("Raport zapisany.");
        }

        private void buttonResetuj_Click(object sender, EventArgs e)
        {
            sP = 0;
            mP = 0;
            hP = 00;
            labelSP.Text = "00";
            labelMP.Text = "00";
            labelHP.Text = "00";
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // odlliczanie --
            s--;

            if (s == -1)
            {
                m--;
                s = 59;
            }
            if (m == -1)
            {
                h--;
                m = 59;
            }
//================================================//
            //odliczanie ++
            sP++;

            if (sP == 60)
            {
                mP++;
                sP = 00;
            }
            if (mP == 60)
            {
                hP++;
                mP = 00;
            }
//================================================//
            if (s == 00 && m == 00 && h == 00)
            {
                timer1.Stop();
                MessageBox.Show("Koniec pracy. Czas na przerwę!");
            }
            
            string ss = Convert.ToString(s);
            string mm = Convert.ToString(m);
            string hh = Convert.ToString(h);

            string sPP = Convert.ToString(sP);
            string mPP = Convert.ToString(mP);
            string hPP = Convert.ToString(hP);
            
            LabelSec.Text = ss;
            LabelMin.Text = mm;
            LabelHours.Text = hh;

            labelSP.Text = sPP;
            labelMP.Text = mPP;
            labelHP.Text = hPP;


            if (h < 0)
            {
                timer1.Stop();
                MessageBox.Show("Podaj poprawny czas.");
                ss = "00";
                mm = "00";
                hh = "00";
                sP = 0;
                labelSP.Text = "00";
                labelMP.Text = "00";
                labelHP.Text = "00";
                if (LabelHours.Text == "-1")
                {
                    LabelHours.Text = "00";
                }
                if (LabelMin.Text == "59")
                {
                    LabelMin.Text = "00";
                }
                if (LabelSec.Text == "59")
                {
                    LabelSec.Text = "00";
                }
            }

        }
        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            

            if (textBoxSeconds.Text == "")
            {
                textBoxSeconds.Text = "00";
            }
            if (textBoxMinutes.Text == "")
            {
                textBoxMinutes.Text = "00";
            }
            if (textBoxHours.Text == "")
            {
                textBoxHours.Text = "00";
            }

            s = Convert.ToInt32(textBoxSeconds.Text);
            m = Convert.ToInt32(textBoxMinutes.Text);
            h = Convert.ToInt32(textBoxHours.Text);

            timer1.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        public Form1()
        {
            InitializeComponent();
        }
        
    }
}
