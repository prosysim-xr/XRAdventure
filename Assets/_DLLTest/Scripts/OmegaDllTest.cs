using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class OmegaDllTest : MonoBehaviour
{

    [DllImport("MathLibOmegaDll")]
    public static extern void fibonacci_init(ulong number1, ulong number2); 
    [DllImport("MathLibOmegaDll")]
    public static extern ulong fibonacci_index(); 
    [DllImport("MathLibOmegaDll")]
    public static extern ulong fibonacci_current(); 
    [DllImport("MathLibOmegaDll")]
    public static extern bool fibonacci_next();

    // Start is called before the first frame update
    void Start()
    {
        // Initialize a Fibonacci relation sequence.
        fibonacci_init(1, 1);
        // Write out the sequence values until overflow.
        do {
            Debug.Log(fibonacci_index() + ": "
                +fibonacci_current() + "\n");
        } while (fibonacci_next());
        // Report count of values written before overflow.
        Debug.Log( fibonacci_index() + 1 +
            " Fibonacci sequence values fit in an " +
            "unsigned 64-bit integer."+"\n" );
    }
}
