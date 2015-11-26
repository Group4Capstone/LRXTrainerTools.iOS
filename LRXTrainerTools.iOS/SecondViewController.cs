using System;
using System.Diagnostics;

using UIKit;

namespace LRXTrainerTools.iOS
{
	public partial class SecondViewController : UIViewController
	{
		public SecondViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();	
			// Perform any additional setup after loading the view, typically from a nib.
			Stopwatch stopwatch = new Stopwatch ();

		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

