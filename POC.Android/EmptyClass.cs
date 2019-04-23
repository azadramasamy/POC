using System;
using Android.Webkit;
using Java.Interop;

namespace POC.Droid
{
    class JsObject : Java.Lang.Object
    {
        [Export("ShowDevice")]
        [JavascriptInterface]
        public string ShowDevice()
        { 
            return "Device info";
        }
    }
}
