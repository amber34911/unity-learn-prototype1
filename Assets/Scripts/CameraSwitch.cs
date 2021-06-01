using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera firstPersonCamera;
    public Camera overheadCamera;

    public void Toggle()
    {
        
        firstPersonCamera.enabled = !firstPersonCamera.isActiveAndEnabled;
        overheadCamera.enabled = !overheadCamera.isActiveAndEnabled;
    }
}
