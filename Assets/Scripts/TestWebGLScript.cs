using UnityEngine;

public class TestWebGLScript : MonoBehaviour
{
    private void Start()
    {
        WebGLLib.OnScreenOrientation = OnScreenOrientation;
        WebGLLibPlugin.RegisterScreenOrientation(WebGLLib.RegisterScreenOrientation);
    }

    private void OnScreenOrientation(string orientation)
    {
        Debug.Log("Screen orientation: " + orientation);
    }
}
