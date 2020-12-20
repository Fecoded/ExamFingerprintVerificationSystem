using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using DPFP;
using DPFP.Capture;

namespace ExamFingerprintVerificationSystem
{

    /* TODO: This form is inherited from the Api
       If you want to make changes in the form layout - do it in the Api.
       All changes in the Api will be reflected in all derived forms 
       (i.e. in the EnrolmentForm and VerificationForm)
   */

    public partial class Api : Form, DPFP.Capture.EventHandler
    {
        private OleDbConnection cnn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        public Api()
        {
            InitializeComponent();
            
        }

        protected virtual void Init()
        {
            try
            {
                //TODO: Create a capture operation.
                Capturer = new Capture();

                if (null != Capturer)
                    //TODO: Subscribe for capturing events.
                    Capturer.EventHandler = this;
                else
                    SetPrompt("Can't initiate capture operation!");
            }
            catch
            {
                MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    SetPrompt("Fingerprint Reader, Scan your Fingerprint!");
                }
                catch
                {
                    SetPrompt("Can't initiate Capture!");
                }
            }
        }

        protected void Stop()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    SetPrompt("Can't terminate capture!");
                }
            }
        }

        #region Form Event Handlers:

        private void Api_Load(object sender, EventArgs e)
        {
            Init();
            //TODO: Start Capturing Operation
            Start();
        }

        private void Api_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stop();
        }
        #endregion

        protected void SetPrompt(string prompt)
        {
            this.Invoke(new Function(delegate () {
                Prompt.Text = prompt;
            }));
        }

        protected void SetStatus(string status)
        {
            this.Invoke(new Function(delegate () {
                StatusLine.Text = status;
            }));
        }

        protected void MakeReport(string message)
        {
            this.Invoke(new Function(delegate () {
                StatusText.AppendText(message + "\r\n");
            }));
        }

        protected void TxtFullname(string name)
        {
            this.Invoke(new Function(delegate () {
                txtName.Text = name;
            }));
        }

        protected void TxtLevel(string level)
        {
            this.Invoke(new Function(delegate () {
                txtLevel.Text = level;
            }));
        }

        protected void TxtDept(string dept)
        {
            this.Invoke(new Function(delegate () {
                txtDept.Text = dept;
            }));
        }





        protected Bitmap ConvertSampleToBitmap(Sample Sample)
        {
            /* TODO: Create a Convertor which will return a bitmap no matter the size  */
            SampleConversion Convertor = new SampleConversion();
            Bitmap bitmap = null;
            Convertor.ConvertToPicture(Sample, ref bitmap);
            return bitmap;
        }

        protected virtual void Process(Sample Sample)
        {
            //TODO: Draw fingerprint sample image.
            DrawPicture(ConvertSampleToBitmap(Sample));
        }

        protected FeatureSet ExtractFeatures(Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            // TODO: Create a feature extractor
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();
            CaptureFeedback feedback = CaptureFeedback.None;
            FeatureSet features = new FeatureSet();
            // TODO: return features as a result?
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);
            if (feedback == CaptureFeedback.Good)
                return features;
            else
                return null;
        }


        private void DrawPicture(Bitmap bitmap)
        {
            this.Invoke(new Function(delegate () {
                //TODO: Fit the image into the picture box
                Picture.Image = new Bitmap(bitmap, Picture.Size);
            }));
        }


        #region EventHandler Members:

        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            MakeReport("The Fingerprint Sample was Captured.");
            SetPrompt("Scan the same Fingerprint again.");
            Process(Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The Finger was removed from the Fingerprint Reader.");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The Fingerprint Reader was Touched.");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The Fingerprint Reader is Connected.");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber) => MakeReport("The Fingerprint Reader was Disconnected.");

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == CaptureFeedback.Good)
                MakeReport("The Quality of the Fingerprint Sample is Good.");
            else
                MakeReport("The Quality of the Fingerprint Sample is Poor.");
        }

        #endregion

        private Capture Capturer;

        private void btnClose_Click(object sender, EventArgs e) => StatusText.Clear();
   



    }
}
