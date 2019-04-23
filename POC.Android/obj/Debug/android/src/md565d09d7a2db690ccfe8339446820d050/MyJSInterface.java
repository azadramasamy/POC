package md565d09d7a2db690ccfe8339446820d050;


public class MyJSInterface
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_DeviceInfo:()Ljava/lang/String;:__export__\n" +
			"n_ShowToast:()V:__export__\n" +
			"";
		mono.android.Runtime.register ("POC.Droid.MyJSInterface, POC.Android", MyJSInterface.class, __md_methods);
	}


	public MyJSInterface ()
	{
		super ();
		if (getClass () == MyJSInterface.class)
			mono.android.TypeManager.Activate ("POC.Droid.MyJSInterface, POC.Android", "", this, new java.lang.Object[] {  });
	}

	public MyJSInterface (android.content.Context p0)
	{
		super ();
		if (getClass () == MyJSInterface.class)
			mono.android.TypeManager.Activate ("POC.Droid.MyJSInterface, POC.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	@android.webkit.JavascriptInterface

	public java.lang.String DeviceInfo ()
	{
		return n_DeviceInfo ();
	}

	private native java.lang.String n_DeviceInfo ();

	@android.webkit.JavascriptInterface

	public void ShowToast ()
	{
		n_ShowToast ();
	}

	private native void n_ShowToast ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
