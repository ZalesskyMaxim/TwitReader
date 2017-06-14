using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace TwitReader.iOS
{
    [Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	//public partial class AppDelegate : UIApplicationDelegate 
	{
        public UIWindow window;
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            //window = new UIWindow(UIScreen.MainScreen.Bounds);
            LoadApplication(new App());
            //window.RootViewController = 

            return base.FinishedLaunching(app, options);
        }
    }
}
