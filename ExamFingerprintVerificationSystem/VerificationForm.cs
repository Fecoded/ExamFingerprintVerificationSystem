using System;
using MySql.Data.MySqlClient;
using System.IO;

namespace ExamFingerprintVerificationSystem
{
    /* TODO: This form is inherited from the Api
       If you want to make changes in the form layout - do it in the Api Designer.
       All changes in the Api will be reflected in here.
   */

    class VerificationForm : Api
    {
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        Api api = new Api();
        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }

        protected override void Init()
        {
            base.Init();
            base.Text = "Fingerprint Verification Session";
            //TODO: Create a Fingerprint Template Verificator
            Verificator = new DPFP.Verification.Verification();     
            UpdateStatus(0);
        }


        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);

            // Process the sample and create a feature set for the enrolment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                MySqlConnection cnn = new MySqlConnection();
                //connection to database
                cnn.ConnectionString = "Server=localhost;Database=fpExam;Uid=root;Pwd=;";; 
                cnn.Open();
                try
                {

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbStudFP WHERE Matric_No='" + txtMatric.Text + "'", cnn);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        byte[] fpbyte = (byte[])dr["FpTemplate"];
                        MemoryStream stream = new MemoryStream(fpbyte);
                        Template = new DPFP.Template(stream);
                        // Compare the feature set with our template
                        DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                        Verificator.Verify(features, Template, ref result);
                        UpdateStatus(result.FARAchieved);
                        if (result.Verified)
                        {
                            MakeReport("The Fingerprint was VERIFIED SUCCESSFULLY");
                            TxtFullname(dr["Full_Name"].ToString());
                            TxtLevel(dr["Level"].ToString());
                            TxtDept(dr["Department"].ToString());
                        }
                        else
                        {

                           MakeReport("The Fingerprint NOT FOUND!.");
                        }
                        
                    }
         
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cnn.Close();
                }
               
            } else
            {
                MakeReport("Fingerprint does not Exist");
            }
        }

        private void UpdateStatus(int FAR)
        {
            // Show "False accept rate" value
            SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR));
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // VerificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(895, 415);
            this.MaximizeBox = false;
            this.Name = "VerificationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
