using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExamFingerprintVerificationSystem
{
    //TODO: A Simple Delegate for Marshalling Calls from event handlers to the GUI thread
    delegate void Function();

    public partial class MainForm : Form
    {
        private DPFP.Template Template;
        public MainForm() => InitializeComponent();
        
        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }


        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                if (Template != null)
                    MessageBox.Show("The Fingerprint was Captured Successfully.", "Fingerprint Enrolment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Please Repeat Enrollment Process, All Fields are Required!", "Fingerprint Enrolment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }));
        }

        private void btn_enrol_Click(object sender, EventArgs e)
        {
            EnrolmentForm enf = new EnrolmentForm();
            enf.OnTemplate += this.OnTemplate;
            enf.ShowDialog();
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            VerificationForm ver = new VerificationForm();
            ver.Verify(Template);
        }
    }
}
