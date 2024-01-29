using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] List<GameObject> cameras;

    private GameObject currentCamera;

    private int currentCameraIndex = 0;

    void Start()
    {
        SetCurrentCamera();
    }

    public void SetMainCamera()
    {
        currentCameraIndex = 0;
        SetCurrentCamera();
    }

    public void SetBullbarCam()
    {
        currentCameraIndex = 1;
        SetCurrentCamera();
    }

    public void SetRoofCam()
    {
        currentCameraIndex = 6;
        SetCurrentCamera();
    }
    public void SetWeaponCam()
    {
        currentCameraIndex = 5;
        SetCurrentCamera();
    }
    public void SetTiresCam()
    {
        currentCameraIndex = 4;
        SetCurrentCamera();
    }

    public void SetCurrentCamera()
    {
        if (currentCamera == null)
        {
            currentCamera = cameras[0];
            currentCamera.SetActive(true);
            return;
        }

        if (currentCameraIndex >= cameras.Count)
        {
            currentCameraIndex = 0;
        }
        if (currentCameraIndex < 0)
        {
            currentCameraIndex = cameras.Count - 1;
        }

        currentCamera.SetActive(false);
        
        currentCamera = cameras[currentCameraIndex];
        currentCamera.SetActive(true);
    }
}
