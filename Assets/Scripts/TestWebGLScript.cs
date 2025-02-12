using UnityEngine;

public class TestWebGLScript : MonoBehaviour
{
    private void Start()
    {
        WebGLLib.RegisterScreenOrientation(OnScreenOrientation);
    }

    private void OnScreenOrientation(string orientation)
    {
        Debug.Log("Screen orientation: " + orientation);
    }
}
