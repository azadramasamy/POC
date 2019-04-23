package md565d09d7a2db690ccfe8339446820d050;


public class JsObject
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_ShowDevice:()Ljava/lang/String;:__export__\n" +
			"";
		mono.android.Runtime.register ("POC.Droid.JsObject, POC.Android", JsObject.class, __md_methods);
	}


	public JsObject ()
	{
		super ();
		if (getClass () == JsObject.class)
			mono.android.TypeManager.Activate ("POC.Droid.JsObject, POC.Android", "", this, new java.lang.Object[] {  });
	}

	@android.webkit.JavascriptInterface

	public java.lang.String ShowDevice ()
	{
		return n_ShowDevice ();
	}

	private native java.lang.String n_ShowDevice ();

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
