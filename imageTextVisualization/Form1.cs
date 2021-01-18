using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace imageTextVisualization
{
    public partial class Form1 : Form
    {

        //public String[] path;
        public String[] originalLines;
        public String[] translateLines;

        public String imgPath = "";
        public String txtPath = "";
        public String outputTxtPath = "";

        public int len = 0;
        public int currentIndex = 0;


        public void setEnableWorkspace(bool val)
        {
            save.Enabled = val;
            next.Enabled = val;
            back.Enabled = val;

            original.Enabled = val;
            translate.Enabled = val;
            index.Enabled = val;
        }

        public Form1()
        {
            InitializeComponent();

            setEnableWorkspace(false);
        }

        private void sel_img_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    imgPath = fbd.SelectedPath;
                    tb_sel_img.Text = imgPath;
                    loadFile();
                }
            }
        }

        private void sel_txt_Click(object sender, EventArgs e)
        {
            using (var file = new OpenFileDialog())
            {
                DialogResult result = file.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(file.FileName))
                {
                    txtPath = file.FileName;
                    tb_sel_txt.Text = txtPath;
                    loadFile();
                }
            }
        }

        public void errorDialog(String txt)
        {
            DialogResult res = MessageBox.Show(txt, "โปรดตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void loadFile()
        {
            if (!string.IsNullOrWhiteSpace(txtPath) && !string.IsNullOrWhiteSpace(imgPath))
            {

                try
                {

                    //String fileName = txtPath.Replace(".txt","_output.txt");


                    originalLines = System.IO.File.ReadAllLines(txtPath);
                    originalLines = originalLines.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                    len = originalLines.Length;


                    //Console.WriteLine("trans line total = " + translateLines.Length);

                    Console.WriteLine("text length = " + len);
                    index_label.Text = "Total : " + len;

                    if(File.Exists(txtPath.Replace(".txt", "_output.txt")))
                    {
                        Console.WriteLine("FOUND SAVE");
                        translateLines = System.IO.File.ReadAllLines(txtPath.Replace(".txt", "_output.txt"));

                        if (translateLines.Length != originalLines.Length)
                        {
                            Console.WriteLine("length problem.. discard save");
                            translateLines = new string[len];
                        }
                        else
                        {
                            try
                            {
                                for(int i = 0; i < translateLines.Length; i++)
                                {
                                    translateLines[i] = translateLines[i].Substring(translateLines[i].IndexOf(',') + 1);
                                }
                            }
                            catch
                            {
                                Console.WriteLine("length problem.. discard save");
                                translateLines = new string[len];
                            }
                        }
                    }
                    else
                    {
                        translateLines = new string[len];
                    }

                    //verify
                    bool valid = originalLines[0].Split(',')[0].Split('/')[0] == ".." ? true : false;
                    if (valid)
                    {
                        updateWorkspace(0);
                        setEnableWorkspace(true);
                    }
                    else
                    {
                        setEnableWorkspace(false);
                        errorDialog("ไฟล์อาจผิดพลาด โปรดตรวจสอบ");
                    }
 
                }
                catch
                {
                    setEnableWorkspace(false);
                    errorDialog("ไฟล์อาจผิดพลาด โปรดตรวจสอบ");
                }
            }
        }

        public void updateWorkspace(int position)
        {
            currentIndex = position;

            index.Text = currentIndex+1 + "";
            String currentLine = originalLines[currentIndex].Substring(originalLines[currentIndex].IndexOf(',') + 1);

            original.Text = currentLine;
            translate.Text = translateLines[currentIndex];
            if ((String.IsNullOrEmpty(translateLines[currentIndex])?"": translateLines[currentIndex]).Equals(currentLine))
            {
                translate.Text = "";
            }

            String currentImage = imgPath+ "\\" + originalLines[currentIndex].Split(',')[0].Split('/')[originalLines[currentIndex].Split(',')[0].Split('/').Length - 1];
            Console.WriteLine("File Image Path = " + currentImage);
            pictureBox1.Image = Image.FromFile(currentImage);
        }

        private void back_Click(object sender, EventArgs e)
        {
            save_Click(sender,e);

            if (currentIndex > 0)
            {
                currentIndex -= 1;
            }
            else if (currentIndex == 0)
            {
                currentIndex = len-1;
            }
            updateWorkspace(currentIndex);
        }

        private void next_Click(object sender, EventArgs e)
        {
            save_Click(sender, e);

            if (currentIndex < len-1)
            {
                currentIndex += 1;
            }
            else if (currentIndex == len-1)
            {
                currentIndex = 0;
            }
            updateWorkspace(currentIndex);
        }

        private void copy_original_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(original.Text);
        }

        private void paste_translate_Click(object sender, EventArgs e)
        {
            translate.Text = Clipboard.GetText();
        }

        private void save_Click(object sender, EventArgs e)
        {
            translateLines[currentIndex] = translate.Text;

            saveFile();
        }

        public void saveFile()
        {
            String fileName = txtPath.Replace(".txt","_output.txt");
            String fileName_backup = "c:/backup_translate.txt";
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file    
                    //fs.Write(translateLines);

                    String output = "";

                    for (int i = 0; i < translateLines.Length; i++)
                    {
                        if(!String.IsNullOrEmpty(translateLines[i]))
                        output += originalLines[i].Split(',')[0] + "," + translateLines[i].Trim() + "\n";
                        else
                         output += originalLines[i].Split(',')[0] + "," + originalLines[i].Substring(originalLines[i].IndexOf(',')+1) + "\n";

                    }

                    output = output.Substring(0, output.Length - 2);

                    byte[] bytes = Encoding.UTF8.GetBytes(output);

                    fs.Write(bytes, 0, bytes.Length);
                }

            }
            catch
            {
                errorDialog("ไม่สามารถบันทึกไฟล์ โปรดตรวจสอบ...");
                errorDialog("ระบบจะสร้าง Backup ไว้ที่ c:/backup_translate.txt");

                try
                {
                    // Check if file already exists. If yes, delete it.     
                    if (File.Exists(fileName_backup))
                    {
                        File.Delete(fileName_backup);
                    }

                    // Create a new file     
                    using (FileStream fs = File.Create(fileName_backup))
                    {
                        // Add some text to file    
                        //fs.Write(translateLines);

                        String output = "";

                        for(int i = 0; i < translateLines.Length; i++)
                        {
                            output += originalLines[i].Split(',')[0] + "," + translateLines[i] + "\n";
                        }

                        byte[] bytes = Encoding.UTF8.GetBytes(output);

                        fs.Write(bytes,0,0);
                    }

                }
                catch
                {
                    errorDialog("ไม่สามารถบันทึกไฟล์ โปรดตรวจสอบ...");
                }
            }
        }

        private void index_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Console.WriteLine("enter");

                int index_get = 0;

                if (int.TryParse(index.Text, out index_get))
                {
                    if(index_get>=1 && index_get <= len)
                    {

                        currentIndex = index_get - 1;

                        updateWorkspace(currentIndex);

                    }
                    else
                    {
                        index.Text = (currentIndex + 1).ToString();
                    }
                }
                else
                {
                    index.Text = (currentIndex + 1).ToString();
                }
            }
        }
    }
}
