using Assignment;
using UnityEngine;
using UnityEngine.UI;



public class InterFace : MonoBehaviour
{
    private int _value = 2333;
    void Start()
    {

    }



    public void ConsoleResult(int value)
    {
        switch (value)
        {

            case 0:
                _value = 2333;
                break;
            case 1:
                _value = 2323;
                break;
            case 2:
                _value = 2525;
                break;
        }

    }


    public void SetVALUE(int newVALUE)
    {
        _value = newVALUE;
    }

    public int VALUE
    {
       
        get { return _value; }
    }
}
