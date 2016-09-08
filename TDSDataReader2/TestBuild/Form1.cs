using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;

namespace TDSDataReader2
{
    

    public partial class Form1 : Form
    {
        //Global Variable Declarations
        string fileLocation;
        string folderLocation;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {


            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;

            openFileDialog1.Multiselect = true;

            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();


            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                // Open the selected file to read.
                System.IO.Stream fileStream = openFileDialog1.OpenFile();

                using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
                {
                    // Read the first line from the file and write it the textbox.
                    textBox1.Text = reader.ReadLine();


                    string filename = openFileDialog1.FileName;
                    
                    fileLocation = filename;

                    textBox2.Text = filename;

                    folderLocation = Path.GetDirectoryName(filename);
                }
                fileStream.Close();
                // Code that is going to fetch the tube count and other goodies!
                string line;
                int counter = 0;

                StreamReader reader2 = new StreamReader(fileLocation);


                while ((line = reader2.ReadLine()) != null)
                {
                    
                    counter++;
                }
                float finalTubeCount = ((counter - 18f) / 3f);
                Global.GlobalVar = finalTubeCount;
                Debug.WriteLine("Tube count:" + finalTubeCount);
                reader2.Close();
                //Getting an array of all of the file paths for the files in the directory with the selected file
                string[] dirs = Directory.GetFiles(folderLocation);
                dirs.ToList().ForEach(Console.WriteLine);
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        //Runs conversion on selected file
        private void button1_Click(object sender, EventArgs e)
        {
            

            string line;
            int counter = 0;

            StreamReader reader = new StreamReader(fileLocation);

            //Testing excel conversion
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not installed");
            }

            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Cells[1, 1] = "Boiler Data to Follow";

            //Prepping the counters for the excel conversion
            int leftCounter = 1;
            int centerCounter = 2;
            int rightcounter = 3;

            //variables for trimming process
            char[] charsToTrim = { '"','V' };
            while ((line = reader.ReadLine()) != null)
            {
                counter++;
                
                if (counter <=1 && counter <= 5)
                {
                    Debug.WriteLine("Left Readings");
                                     
                }
                //Printing left readings
                if (counter >= 6 && counter <= (Global.GlobalVar + 5 ))
                {
                    line = line.Trim(charsToTrim);
                    Debug.WriteLine(line);
                    xlWorkSheet.Cells[2,leftCounter] = line;
                    leftCounter = leftCounter + 3;
                    
                }
                if (counter == Global.GlobalVar + 11)
                {
                    Debug.WriteLine("Center Readings");                    
                }
                if (counter > (Global.GlobalVar + 11) && counter <= ((Global.GlobalVar * 2) +11 ))
                {
                    line = line.Trim(charsToTrim);
                    Debug.WriteLine(line);
                    xlWorkSheet.Cells[2, centerCounter] = line;
                    centerCounter = centerCounter + 3;
                }
                if (counter == (Global.GlobalVar * 2) + 17)
                {
                    Debug.WriteLine("Right Readings");
                }
                if (counter > ((Global.GlobalVar * 2)+ 17) && counter <= ((Global.GlobalVar * 3) + 17))
                {
                    line = line.Trim(charsToTrim);
                    Debug.WriteLine(line);
                    xlWorkSheet.Cells[2, rightcounter] = line;
                    rightcounter = rightcounter + 3;
                }

            }
            Debug.WriteLine("Total line count:" + counter);
            Debug.WriteLine("Tube count:" + Global.GlobalVar);
            reader.Close();

            Console.ReadLine();

            //Saving the Excel Fil
            xlWorkBook.SaveAs(@"E:\New folder\PlayingAround\ExcelFolder\test.xlsx", Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            MessageBox.Show("Conversion Complete");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Global.GlobalCounter = 2;
        }

        
    }

    //creating the class that will allow for global variable use.
    //this is for passing the tube count to the conversion routine
    static class Global
    {
        private static float _globalVar;
        private static int _globalCounter;

        public static float GlobalVar
        {
            get { return _globalVar; }
            set { _globalVar = value; }
            
        }
        public static int GlobalCounter
        {
            get { return _globalCounter; }
            set { _globalCounter = value; }
        }
    }

}

/*
 *  while ((line = reader.ReadLine()) != null)
            {
                Debug.WriteLine(line);
                counter++;

                if (counter == 5)
                {
                    Debug.WriteLine("Left Readings");
                }
               
                if (counter == Global.GlobalVar + 11)
                {
                    Debug.WriteLine("Center Readings");                    
                }

                if (counter == (Global.GlobalVar * 2) + 17)
                {
                    Debug.WriteLine("Right Readings");
                }
                
            }

    */

