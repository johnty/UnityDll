using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;



public class DllLoaderScript : MonoBehaviour
{

    public UnityEngine.UI.Text myText;

    [DllImport("TestLib")]
    static extern void SayHello();
    [DllImport("TestLib")]
    static extern int GetInt();
    [DllImport("TestLib")]
    static extern float GetFloat();
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("starting DLLLoader");
        
        SayHello();
        
        Debug.Log(GetInt().ToString());
        Debug.Log(GetFloat().ToString());
        string msg = "dll loader f=" + GetFloat().ToString();
        myText.text = msg;
        //GetFloat();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
