using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class connection : MonoBehaviour
{

    public float x = 1;
    public float z = 1;
    private CharacterController _characterController;
    private Camera _camera;


    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _camera = transform.GetChild(0).GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.deltaTime;
        Vector3 move = new Vector3(x * Input.GetAxis("Horizontal") * time, 0, z * Input.GetAxis("Vertical") * time);
        _characterController.Move(transform.TransformDirection(move));

        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);

        _camera.transform.Rotate(-Input.GetAxis("Mouse Y"), 0, 0);
        print(_camera.transform.eulerAngles);

        if (_camera.transform.eulerAngles.x >= 50)
        {
            _camera.transform.eulerAngles = new Vector3(Mathf.Clamp(_camera.transform.eulerAngles.x -360, -30, 0), _camera.transform.eulerAngles.y,0);
        }
        else
        {
            _camera.transform.eulerAngles = new Vector3(Mathf.Clamp(_camera.transform.eulerAngles.x, 0, 45), _camera.transform.eulerAngles.y, 0);

        }
    }
}
