using System;
using System.Runtime.InteropServices;

static class WebGLLibPlugin
{
    [DllImport("__Internal")]
    public static extern void RegisterScreenOrientation(Action<string> callback);


}

public static class WebGLLib
{
    public static void RegisterScreenOrientation(Action<string> callback)
    {
        WebGLLibPlugin.RegisterScreenOrientation(callback);
    }
}
