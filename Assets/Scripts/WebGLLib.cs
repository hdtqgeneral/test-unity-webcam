using System;
using System.Runtime.InteropServices;
using AOT;

static class WebGLLibPlugin
{
    [DllImport("__Internal")]
    public static extern void RegisterScreenOrientation(Action<string> callback);
}

public static class WebGLLib
{
    public static Action<string> OnScreenOrientation;

    [MonoPInvokeCallback(typeof(Action<string>))]
    public static void RegisterScreenOrientation(string orientation)
    {
        OnScreenOrientation?.Invoke(orientation);
    }
}
