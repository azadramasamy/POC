using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Webkit;
using Android.Text;
using Xamarin.Essentials;
using System.Net.NetworkInformation;
using System.Net;

namespace POC.Droid
{
    [Activity(Label = "POC", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
           
             global::Android.Webkit.WebView.SetWebContentsDebuggingEnabled(true);
             base.OnCreate(savedInstanceState);

             Xamarin.Essentials.Platform.Init(this, savedInstanceState);
             global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            WebView view = new WebView(this);
            //SetContentView(Resource.Layout.Main);
            //WebView view = FindViewById<WebView>(Resource.Id.LocalWebView);//--
            view.SetWebViewClient(new WebViewClient());

            //view.LoadUrl("http://10.0.2.2:4000/#!/login"); // -- buggy JS interface

            view.Settings.JavaScriptEnabled = true;
            view.AddJavascriptInterface(new JsObject(), "injectedObject");

            view.AddJavascriptInterface(new MyJSInterface(this), "MyJSInterface");
             LoadApplication(new App());
     }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}