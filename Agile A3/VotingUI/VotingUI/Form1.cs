using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingUI
{
    public partial class Form1 : Form
    {
        candidate selectedCandidate = new candidate();
        public Form1()
        {
            InitializeComponent();
        }


        private void addCandidateButton_Click(object sender, EventArgs e)
        {
            candidate newCandidate = new candidate();
            newCandidate.candidateName = nameBox.Text;
            

            candidateList.Items.Add(newCandidate);
            nameBox.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (selectedCandidate.preferenceOrder == 1)
            {

                selectedCandidate.firstPreference++;

            }
            try
            {
                if ((Convert.ToInt32(preferenceBox.Text)+1 < candidateList.Items.Count))
                {
                    selectedCandidate.preferenceOrder = Convert.ToInt32(preferenceBox.Text);
                }
                else
                    throw new Exception("Preference number cannot be bigger than the number of Candidates");
               

            }
            catch (Exception)
            {
                MessageBox.Show("Wrong number input or preference number");
            }
               
            
            
        }

        private void candidateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (candidateList.SelectedIndex != -1)
            {
                selectedCandidate = (candidate)candidateList.SelectedItem;
                preferenceBox.Text = selectedCandidate.preferenceOrder.ToString();
                
            }
            
        }
    }
}
