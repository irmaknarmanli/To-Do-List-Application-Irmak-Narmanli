using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Speech.Synthesis.TtsEngine;

namespace To_Do_List_Application
{
    public partial class frmToDoList : Form
    {
        private string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "save.txt");
        public frmToDoList()
        {
            InitializeComponent();
            LoadFile();
        }
        SpeechRecognitionEngine recognizer;
        ColorDialog cdg = new ColorDialog();
        List<Color> itemColors = new List<Color>(); //i've defined a color list to check and store the colors of the items
        List<Color> itemBackgroundColors = new List<Color>(); //i've defined a color list to check and store the backcolors of the items

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (recognizer != null)
            {
                recognizer.RecognizeAsyncStop();
            }
            lstTasks.Items.Add(txtTask.Text);
            txtTask.Text = "";
            lblTotalTasks.Text = "Total Tasks: " + lstTasks.Items.Count;

            itemColors.Add(Color.Black); 
            itemBackgroundColors.Add(Color.White); 

            lstTasks.Invalidate();
            // it will increment the amount of tasks when the button is clicked and will show it with lblTotalTaks.
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex == -1)
            {
                MessageBox.Show("Choose a Task to Delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } // if there are no tasks added or no tasks selected, it will show an error.


            else
            {
                int index = lstTasks.SelectedIndex;
                lstTasks.Items.RemoveAt(index);
                itemColors.RemoveAt(index); // also deletes from the color list
                itemBackgroundColors.RemoveAt(index);
                lblTotalTasks.Text = "Total Tasks: " + lstTasks.Items.Count;
            } // deletes the selected item and updates the lblTotalTasks
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex == -1)
            {
                MessageBox.Show("Choose a Task to Edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } // if there are no tasks added or no tasks selected, it will show an error.


            else
            {
                int index = lstTasks.SelectedIndex;

                if (!string.IsNullOrWhiteSpace(txtTask.Text))
                {
                    lstTasks.Items[index] = txtTask.Text;
                    txtTask.Text = "";
                }
                else
                {
                    MessageBox.Show("Please Enter a Valid Task Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnMarkComplete_Click(object sender, EventArgs e)
        {
            int index = lstTasks.SelectedIndex;

            if (lstTasks.SelectedIndex == -1)

            {
                MessageBox.Show("Choose a Task to Mark Completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (lstTasks.SelectedItem.ToString().StartsWith("✔"))
            {
                lstTasks.Items[index] = lstTasks.SelectedItem.ToString().Substring(1);
            }
            else
            {
                lstTasks.Items[index] = "✔" + lstTasks.SelectedItem.ToString();
            }
        }

        private void LoadFile()
        {
            if (File.Exists(filePath))
            {
                string[] satirlar = File.ReadAllLines(filePath); // reads all lines
                lstTasks.Items.AddRange(satirlar); // adds to lstTasks
            }
        }

        private void frmToDoList_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllLines(filePath, lstTasks.Items.Cast<string>());
        }

        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDarkMode.Checked)
            {
                BackColor = Color.MidnightBlue;
                btnAdd.BackColor = Color.Black;
                btnAdd.ForeColor = Color.White;
                btnDelete.BackColor = Color.Black;
                btnEdit.BackColor = Color.Black;
                btnMarkComplete.BackColor = Color.Black;
                lblTitle.ForeColor = Color.White;
                lblTotalTasks.ForeColor = Color.White;
                txtTask.ForeColor = Color.White;
                txtTask.BackColor = Color.Black;
                lstTasks.BackColor = Color.Black;
                lstTasks.ForeColor = Color.White;
                btnBackColor.BackColor = Color.Black;
                btnSpeech.BackColor = Color.Black;
                btnLowPriority.ForeColor = Color.YellowGreen;
                btnHighPriority.ForeColor = Color.Tomato;
                btnMedPriority.ForeColor = Color.SkyBlue;
            }
            else
            {
                BackColor = Color.LightSteelBlue;
                btnAdd.BackColor = Color.White;
                btnAdd.ForeColor = Color.Black;
                btnDelete.BackColor = Color.White;
                btnEdit.BackColor = Color.White;
                btnMarkComplete.BackColor = Color.White;
                lblTitle.ForeColor = Color.Black;
                lblTotalTasks.ForeColor = Color.Black;
                txtTask.ForeColor = Color.Black;
                txtTask.BackColor = Color.White;
                lstTasks.BackColor = Color.White;
                lstTasks.ForeColor = Color.Black;
                btnBackColor.BackColor = Color.White;
                btnSpeech.BackColor = Color.White;
                btnLowPriority.ForeColor = Color.DarkGreen;
                btnHighPriority.ForeColor = Color.DarkRed;
                btnMedPriority.ForeColor = Color.DarkBlue;
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            if (cdg.ShowDialog() == DialogResult.OK)
            {
                BackColor = cdg.Color;
            }
        }

        private void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            txtTask.Text += e.Result.Text + "\r\n";
        }

        private void frmToDoList_Load(object sender, EventArgs e)
        {
            lblTotalTasks.Text = "Total Tasks: " + lstTasks.Items.Count;

            lstTasks.DrawMode = DrawMode.OwnerDrawFixed;

            itemColors = new List<Color>(); 
            itemBackgroundColors = new List<Color>();

            for (int i = 0; i < lstTasks.Items.Count; i++)
            {
                itemColors.Add(Color.Black); // default text color is black
                itemBackgroundColors.Add(Color.White); // default back color is white
            }

            btnHighPriority.Click += PriorityChecked;
            btnMedPriority.Click += PriorityChecked;
            btnLowPriority.Click += PriorityChecked;

            lstTasks.DrawItem += lstTasks_DrawItem;
        }
        private void btnSpeech_Click(object sender, EventArgs e)
        {
            try
            {
                if (recognizer == null)
                {
                    recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
                    recognizer.SetInputToDefaultAudioDevice();
                    recognizer.LoadGrammar(new DictationGrammar());
                    recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);
                }
                else
                {
                    if (recognizer.AudioState != AudioState.Stopped)
                    {
                        recognizer.RecognizeAsyncStop();
                        while (recognizer.AudioState != AudioState.Stopped)
                        {
                            Application.DoEvents();
                        }
                    }
                    recognizer.RecognizeAsync(RecognizeMode.Multiple);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occured. " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lstTasks_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            string itemText = lstTasks.Items[e.Index].ToString();
            Font font = new Font("Segoe UI", 12);
            SolidBrush textBrush;
            SolidBrush backgroundBrush;

            Color textColor = (e.Index < itemColors.Count) ? itemColors[e.Index] : Color.Black; 
            Color backgroundColor = (e.Index < itemBackgroundColors.Count) ? itemBackgroundColors[e.Index] : Color.White;

            textBrush = new SolidBrush(textColor);


            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                backgroundBrush = new SolidBrush(Color.LightBlue);
            } //if an item is selected, make the background of the item light blue
            else
            {
                backgroundBrush = new SolidBrush(backgroundColor);
            }

            e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
            e.Graphics.DrawString(itemText, font, textBrush, e.Bounds.Left, e.Bounds.Top);
            e.DrawFocusRectangle();
        }
        private void PriorityChecked(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                int selectedIndex = lstTasks.SelectedIndex;

                if (sender == btnHighPriority)
                    itemColors[selectedIndex] = Color.Red;
                else if (sender == btnMedPriority)
                    itemColors[selectedIndex] = Color.Blue;
                else if (sender == btnLowPriority)
                    itemColors[selectedIndex] = Color.Green;

                lstTasks.Invalidate();
            }

        }
        private void dtpDueDate_ValueChanged(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                DateTime selectedDate = dtpDueDate.Value;
                TimeSpan difference = selectedDate - DateTime.Now;

                int selectedIndex = lstTasks.SelectedIndex;

                if (difference.TotalDays < 2 && difference.TotalDays >= 0)
                {
                    itemBackgroundColors[selectedIndex] = Color.Yellow;
                }  //if there are less than 2 days and more than 0 days left to the selected date, it will change the itemcolor to yellow
                else 
                {
                    itemBackgroundColors[selectedIndex] = Color.White;
                }
                lstTasks.Invalidate();

            }
        }
    }
}
