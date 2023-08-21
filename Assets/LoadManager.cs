using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LoadManager : MonoBehaviour
{
    public void OpenLinkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/vinay-katamble");
    }

    public void OpenInstagram()
    {
        Application.OpenURL("https://instagram.com/vinaykatamble?utm_source=qr&igshid=ZDc4ODBmNjlmNQ%3D%3D");
    }
}
