using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float minRotation;
    public float maxRotation;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Screen.lockCursor = false;
        rb = GetComponent<Rigidbody>();
        speed = 10;
        transform.rotation = Quaternion.identity;
        minRotation = -0.5f;
        maxRotation = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButton(0))
        {
            //rotateYAxis += 3 * Input.GetAxis("Mouse X");
            //rotateXAxis += 3 * Input.GetAxis("Mouse Y");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.back* speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
    }

    //void limitRotation()
    //{
    //    print(transform.rotation);
    //    float xrot = transform.rotation.x;
    //    float yrot = transform.rotation.y;
    //    float zrot = transform.rotation.z;


    //    if (transform.rotation.x > maxRotation)
    //    {
    //        xrot = maxRotation;
    //    }
    //    if (transform.rotation.x < minRotation)
    //    {
    //        xrot = minRotation;
    //    }
    //    if (transform.rotation.y > maxRotation)
    //    {
    //        yrot = maxRotation;
    //    }
    //    if (transform.rotation.y < minRotation)
    //    {
    //        yrot = minRotation;
    //    }
    //    if (transform.rotation.z > maxRotation)
    //    {
    //        zrot = maxRotation;
    //    }
    //    if (transform.rotation.z < minRotation)
    //    {
    //        zrot = minRotation;
    //    }

    //    Vector3 rot = new Vector3(xrot, yrot, zrot);
    //    transform.localEulerAngles = rot;
    //}
}
