using System.Collections;
using UnityEngine;

public class PinchZoom : MonoBehaviour
{

    public float perspectiveZoomSpeed = 0.5f;        // The rate of change of the field of view in perspective mode.
    public float orthoZoomSpeed = 0.5f;        // The rate of change of the orthographic size in orthographic mode.
    public float panSpeed = 10F;
    public float maxZoom; //farthest you can get
    public float minZoom; //closest you can get


    public Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        //maxZoom = Camera.main.orthographicSize * Screen.height / Screen.width * 2.0f;
    }


    void Update()
    {

        if (Input.touchCount == 2)
        {

            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);


            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;


            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            //Find distances between each frame.
            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            // If the camera is orthographic...
            if (GetComponent<Camera>().orthographic)
            {


                float i = GetComponent<Camera>().orthographicSize + deltaMagnitudeDiff * orthoZoomSpeed;

                //set the max and min of the scene
                GetComponent<Camera>().fieldOfView += i * orthoZoomSpeed;
                GetComponent<Camera>().fieldOfView = Mathf.Clamp(GetComponent<Camera>().fieldOfView, minZoom, maxZoom);

                if (i >= maxZoom)
                { //if i is greater than maxZoom, set camera to max
                    GetComponent<Camera>().orthographicSize = maxZoom;

                }
                else if (i <= minZoom)
                { //same but with min
                    GetComponent<Camera>().orthographicSize = minZoom;
                }
                else
                { //otherwise just update it to i
                    GetComponent<Camera>().orthographicSize = i;
                }


            }
        }

        ////to pan the camera
        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        //{

        //    Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
        //    transform.position = new Vector2(Mathf.Clamp(touchDeltaPosition.x, -1500, 1500), Mathf.Clamp(touchDeltaPosition.y, -1500, 1500));

        //    transform.Translate(-touchDeltaPosition.x * panSpeed * Time.deltaTime, -touchDeltaPosition.y * panSpeed * Time.deltaTime, 0);

        //}


    }


}