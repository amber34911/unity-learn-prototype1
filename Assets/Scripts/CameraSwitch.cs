using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera firstPersonCamera;
    public Camera overheadCamera;

    private void Update()
    {
        if (Input.GetButtonDown("SwitchCamera"))
        {
            if (firstPersonCamera.isActiveAndEnabled)
            {
                firstPersonCamera.enabled = false;
                overheadCamera.enabled = true;
            }
            else
            {
                firstPersonCamera.enabled = true;
                overheadCamera.enabled = false;
            }
        }
    }
}
