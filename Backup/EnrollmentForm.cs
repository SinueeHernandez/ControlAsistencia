using System;
using System.Collections.Generic;
using System.Text;

namespace Enrollment
{
	/* NOTE: This form is inherited from the CaptureForm,
		so the VisualStudio Form Designer may not load it properly
		(at least until you build the project).
		If you want to make changes in the form layout - do it in the base CaptureForm.
		All changes in the CaptureForm will be reflected in all derived forms 
		(i.e. in the EnrollmentForm and in the VerificationForm)
	*/
	public class EnrollmentForm : CaptureForm
	{
		public delegate void OnTemplateEventHandler(DPFP.Template template);

		public event OnTemplateEventHandler OnTemplate;

		protected override void Init()
		{
			base.Init();
			base.Text = "Fingerprint Enrollment";
			Enroller = new DPFP.Processing.Enrollment();			// Create an enrollment.
			UpdateStatus();
		}

		protected override void Process(DPFP.Sample Sample)
		{
			base.Process(Sample);

			// Process the sample and create a feature set for the enrollment purpose.
			DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

			// Check quality of the sample and add to enroller if it's good
			if (features != null) try
			{
				MakeReport("The fingerprint feature set was created.");
				Enroller.AddFeatures(features);		// Add feature set to template.
			}
			finally {
				UpdateStatus();

				// Check if template has been created.
				switch(Enroller.TemplateStatus)
				{
					case DPFP.Processing.Enrollment.Status.Ready:	// report success and stop capturing
						OnTemplate(Enroller.Template);
						SetPrompt("Click Close, and then click Fingerprint Verification.");
						Stop();
						break;

					case DPFP.Processing.Enrollment.Status.Failed:	// report failure and restart capturing
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
			// Show number of samples needed.
			SetStatus(String.Format("Fingerprint samples needed: {0}", Enroller.FeaturesNeeded));
		}

		private DPFP.Processing.Enrollment Enroller;
	}
}
