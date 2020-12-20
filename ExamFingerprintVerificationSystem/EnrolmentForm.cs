using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;


namespace ExamFingerprintVerificationSystem
{
    /* TODO: This form is inherited from the Api
		If you want to make changes in the form layout - do it in the Api Designer.
		All changes in the Api will be reflected here
	*/
public class EnrolmentForm : Api
 {
  public delegate void OnTemplateEventHandler(DPFP.Template template);
  private DPFP.Processing.Enrollment Enroller;
  public event OnTemplateEventHandler OnTemplate;

  protected override void Init()
  {
    base.Init();
    base.Text = "Fingerprint Enrolment Session";
    //TODO: Create enrollment.
    Enroller = new DPFP.Processing.Enrollment();      
    UpdateStatus();
  }

  protected override void Process(DPFP.Sample Sample) {
    base.Process(Sample);

  // Process the sample and create a feature set for the enrollment purpose.
    DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

    // Check quality of the sample and add to enroller if it's good
     if (features != null)
      try
      {
        MakeReport("The Fingerprint Feature Set was Created.");
        Enroller.AddFeatures(features);     
      }
      finally
      {
       UpdateStatus();
        // Check if template has been created.
       switch (Enroller.TemplateStatus)
        {
        // report success and stop capturing
        case DPFP.Processing.Enrollment.Status.Ready:
         byte[] serializedTemplate = null;
         DateTime cur_date = DateTime.Now;
         Enroller.Template.Serialize(ref serializedTemplate);

         if (serializedTemplate != null)
          {
          string result = Encoding.UTF8.GetString(serializedTemplate);
          Console.Write(result);

           if (txtMatric.Text != "" & txtName.Text != "" & txtLevel.Text != "" & txtDept.Text != "")
           {

             MySqlConnection cnn = new MySqlConnection();
              //connection to database
             cnn.ConnectionString = "Server=localhost;Database=fpExam;Uid=root;Pwd=;"; ;
             cnn.Open();
             MySqlCommand cmd = new MySqlCommand();
             MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM tbStudFP WHERE Matric_No='" + txtMatric.Text + "'", cnn);
             DataTable dt = new DataTable();
             adp.Fill(dt);
             try
             {
               string mat = dt.Columns[0].ToString();
               if (txtMatric.Text != mat)
               {
               cmd = cnn.CreateCommand();
                // Store Student Data and FpTemplate as byte
               cmd.CommandText = "INSERT INTO tbStudFP(Matric_No,Full_Name,Level,Department,FpTemplate) VALUES (@matric_no,@full_name,@level,@dept,@serializedTemplate)";
               cmd.Parameters.AddWithValue("@matric_no", txtMatric.Text);
               cmd.Parameters.AddWithValue("@full_name", txtName.Text);
               cmd.Parameters.AddWithValue("@level", txtLevel.Text);
               cmd.Parameters.AddWithValue("@dept", txtDept.Text);
               cmd.Parameters.AddWithValue("@serializedTemplate", serializedTemplate);
               cmd.ExecuteNonQuery();
                                                                             }
                else
                {
                 MakeReport("Matric No: '" + txtMatric.Text + "' is already Registered");
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
                    }
                     else
                     {
                      SetPrompt("Please Enter all Fields");
                      }
                     }
                   OnTemplate(Enroller.Template);
                   SetPrompt("Fingerprint Enrolment was Successful.");
                   Stop();
                   break;

                     // report failure and restart capturing
                    case DPFP.Processing.Enrollment.Status.Failed:  
                    Enroller.Clear();
                    Stop();
                    UpdateStatus();
                    OnTemplate(null);
                    Start();
                    break;
                    }
                }
        }

        private void UpdateStatus()
        {
            //TODO: Show number of samples needed.
            SetStatus(String.Format("Fingerprint Samples needed: {0}", Enroller.FeaturesNeeded));
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // EnrolmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(895, 415);
            this.MaximizeBox = false;
            this.Name = "EnrolmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
