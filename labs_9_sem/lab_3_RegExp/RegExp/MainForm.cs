using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RegExp
{
    public partial class MainForm : Form
    {
        RegProcessor RegProc;
        public List<StringBuilder> RegsList = new List<StringBuilder>();
        public List<StringBuilder> TestList = new List<StringBuilder>();

        public MainForm()
        {
            InitializeComponent();

            //понеслась душа в рай
            RegProc = new RegProcessor();
            RegsList = LoadFromFile("Regs.txt");
            TestList = LoadFromFile("Test.txt");
            cB.DataSource = LoadFromFile("RegsNames.txt");
            
            if (cB.DataSource != null && RegsList != null)
                cB.SelectedIndex = 0;
            else
                ErrorMessage();
        }

        //построчное чтение файла c разделителями
        public List<StringBuilder> LoadFromFile(string FileName)
        {
            List<StringBuilder> StringList = new List<StringBuilder>();
            string line;
            string[] sep = new[] { "; " };
            try
            {
                 var file = new System.IO.StreamReader(FileName);
                 while ((line = file.ReadLine()) != null)
                 {
                     string[] words = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                     var text = new StringBuilder();
                    foreach (string word in words)
                    {
                        if (words.Length == 1)
                            text.Append(word);
                        else
                            text.AppendLine(word);
                    }
                    StringList.Add(text);
                 }
                 file.Close();
                 return StringList;
            }
            catch (Exception)
                {return null;}
        }

        //изменение комбобокса
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB.DataSource != null && RegsList != null)
                tbRegExp.Text = RegsList[cB.SelectedIndex].ToString();
            if (TestList != null)
                tbInput.Text = TestList[cB.SelectedIndex].ToString();
                       
            RegExUpdate(cB.SelectedIndex);
        }
        
        //вывод ошибок
        public void ErrorMessage()
        {
            MessageBox.Show("Что-то пошло не так...", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            RegExUpdate(cB.SelectedIndex);
        }

        private void tbRegExp_TextChanged(object sender, EventArgs e)
        {
            RegExUpdate(cB.SelectedIndex);
        }

        private void RegExUpdate(int index)
        {
            if (index == 6)
               tbOutput.Text = RegProc.ProcessHref(tbInput.Text);
            else if (index == 7)
                tbOutput.Text = RegProc.Filter(tbInput.Text, tbRegExp.Text, chB.Checked, "$3$2$1");
            else
                tbOutput.Text = RegProc.Filter(tbInput.Text, tbRegExp.Text, chB.Checked);
        }

        private void chB_Click(object sender, EventArgs e)
        {
            RegExUpdate(cB.SelectedIndex);
        }
    }//
}//