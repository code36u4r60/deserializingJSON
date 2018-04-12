using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace JsonSolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region UI events

        private void cmdDeserialise_Click(object sender, EventArgs e)
        {
            //debugOutput(txtInput.Text);
            deserialiseJSON(txtInput.Text);
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtDebugOutput.Text = string.Empty;

        }

        #endregion


        #region json functions

        private void deserialiseJSON(string strJSON)
        {
            try
            {
                //var jPerson = JsonConvert.DeserializeObject<dynamic>(strJSON);
                //debugOutput("Here's our JSON object: " + jPerson.ToString());
                //debugOutput("Fist Name: " + jPerson.firstname);
                //debugOutput("Street streeAddress: " + jPerson.streeAddress);


                var jPerson = JsonConvert.DeserializeObject<jsonPerson>(strJSON);

                debugOutput("Here's our JSON object: " + jPerson.ToString());
                debugOutput("Fist Name: " + jPerson.firstname.ToString());
                debugOutput("Street streeAddress: " + jPerson.address.streeAddress.ToString());
                debugOutput("Attempting to print phone numbers....");

                foreach (var num in jPerson.phoneNumbers)
                {
                    debugOutput(num.type.ToString() + " - " + num.number.ToString());
                }


            }
            catch (Exception ex)
            {
                debugOutput("We had a problem: " + ex.Message.ToString());
            }
        }

        #endregion


        #region Debug Output

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtDebugOutput.Text = txtDebugOutput.Text + strDebugText + Environment.NewLine;
                txtDebugOutput.SelectionStart = txtDebugOutput.TextLength;
                txtDebugOutput.ScrollToCaret();

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message.ToString() + Environment.NewLine);
            }
            
        }
        #endregion



    }
}
