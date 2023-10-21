// HelloWorldScript.cs
using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class HelloWorldScript : MonoBehaviour
{
    /*// Import the DLL function
    [DllImport("DllTestPrint")] // Update "YourDLLName" with the actual name of your DLL without extension
    public static extern IntPtr printHello();*/
    [DllImport("DllTestPrint")]
    public static extern int Double(int number);

    private void Start()
    {
        // Call the DLL function
        /* string helloMessage = Marshal.PtrToStringAnsi(printHello());
        Debug.Log(helloMessage); */
        int i = Double(56);
        Debug.Log(i);
    }
}
