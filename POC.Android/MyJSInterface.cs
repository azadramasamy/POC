using System;
using Android.Content;
using Android.Webkit;
using Java.Interop;
using Java.Lang;
using Xamarin.Essentials;

namespace POC.Droid
{
    public class MyJSInterface : Java.Lang.Object
    {
        Context context;

        public MyJSInterface(Context context)
        {
            this.context = context;
        }

        public void Run()
        {
            //throw new NotImplementedException();
        }
        [Export("DeviceInfo")]
        [JavascriptInterface]
        public string DeviceInfo()
        {
            return "my phone";
        }

        [Export("ShowToast")]
        [JavascriptInterface]
        public void ShowToast()
        {
           // var device ="DeviceInfo.Model";
            Android.Widget.Toast.MakeText(context, "Hello from C#", Android.Widget.ToastLength.Short).Show();
        }
    }
}
