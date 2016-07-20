using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;


namespace XamarinUniversal
{
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        public override UIWindow Window { get; set; }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            Window = new UIWindow(UIScreen.MainScreen.Bounds);
            Window.RootViewController = new MyViewController();
            Window.MakeKeyAndVisible();
            return true;
        }

    }
}
