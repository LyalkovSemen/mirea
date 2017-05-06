using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RegExp
{
    public partial class MainForm : Form
    {
        public List<string> RegsList = new List<string>();
        public List<string> TestList = new List<string>();
        public MainForm()
        {
            InitializeComponent();
            
            //понеслась душа в рай
            RegsList = LoadFromFile("Regs.txt");
            TestList = LoadFromFile("Test.txt");
            comboBox.DataSource = LoadFromFile("RegsNames.txt");
            


            if (comboBox.DataSource != null && RegsList != null)
                comboBox.SelectedIndex = 0;
            else
                ErrorMessage();
        }

        //построчное чтение файла
        public List<string> LoadFromFile(string FileName)
        {
            List<string> StringList = new List<string>();
            string line;
            try
            {
                var file = new System.IO.StreamReader(FileName);
                while ((line = file.ReadLine()) != null)
                {
                    StringList.Add(line);
                }
                file.Close();
                return StringList;
            }
            catch (Exception)
            {return null;}
            
        }

        //изменение комбобокса
        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.DataSource != null && RegsList != null)
                tbRegExp.Text = RegsList[comboBox.SelectedIndex];
            if (TestList != null)
                tbInput.Text = TestList[comboBox.SelectedIndex];
        }
        
        //вывод ошибок
        public void ErrorMessage()
        {
            MessageBox.Show("Что-то пошло не так...", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
    }//
}//