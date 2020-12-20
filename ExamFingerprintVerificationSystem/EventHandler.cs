using System;
using DPFP;
using DPFP.Capture;

namespace ExamFingerprintVerificationSystem
{
    public interface EventHandler
    {
        void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample);
        void OnFingerGone(object Capture, string ReaderSerialNumber);
        void OnFingerTouch(object Capture, string ReaderSerialNumber);
        void OnReaderConnect(object Capture, string ReaderSerialNumber);
        void OnReaderDisconnect(object Capture, string ReaderSerialNumber);
        void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback);
    }
}
