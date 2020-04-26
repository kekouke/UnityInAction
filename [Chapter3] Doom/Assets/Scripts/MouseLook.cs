using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public enum RotationAxes
    {
        mouseX,
        mouseY,
        mouseXAndY
    }

    public RotationAxes Axes = RotationAxes.mouseX;

    public float SensitivityHor = 5;
    public float SensitivityVert = 5;
    public float MaximumVert = 45;
    public float MinimumVert = -45;

    private float _rotationX;
    private float _rotationY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Axes == RotationAxes.mouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * SensitivityHor, 0);
        }
        else if (Axes == RotationAxes.mouseY)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * SensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, MinimumVert, MaximumVert);
            float _rotationY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(_rotationX, _rotationY, 0);
        }
        else if (Axes == RotationAxes.mouseXAndY)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * SensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, MinimumVert, MaximumVert);

            _rotationY += Input.GetAxis("Mouse X") * SensitivityHor;

            transform.localEulerAngles = new Vector3(_rotationX, _rotationY, 0);
        }
    }
}
