using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemChecker : MonoBehaviour
{
    public bool Handheld = false;
    public bool Desktop = false;
    private void Awake()
    {
        if(SystemInfo.deviceType == DeviceType.Desktop)
        {
            Desktop = true;
        }
        else if(SystemInfo.deviceType == DeviceType.Handheld)
        {
            Handheld = true;
        }
    }
}