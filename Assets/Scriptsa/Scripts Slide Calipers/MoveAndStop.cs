using UnityEngine;

public class MoveAndStop : MonoBehaviour
{
   
    public GameObject movingObject;
    public GameObject stoppedObject;

    private Rigidbody movingObjectRB;
    private Rigidbody stoppedObjectRB;
    private bool isMovingObjectTouched = false;

    void Start()
    {
        movingObjectRB = movingObject.GetComponent<Rigidbody>();
        stoppedObjectRB = stoppedObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject == movingObject)
                    {
                        isMovingObjectTouched = true;
                        movingObjectRB.velocity = Vector3.zero;
                    }
                    else
                    {
                        isMovingObjectTouched = false;
                    }
                }
            }

            if (touch.phase == TouchPhase.Moved && !isMovingObjectTouched)
            {
                Vector2 deltaPos = touch.deltaPosition;
                stoppedObjectRB.AddForce(0, 0, deltaPos.y * 10);
            }
        }
        else if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit))
            {
                if (hit.collider.gameObject == movingObject)
                {
                    isMovingObjectTouched = true;
                    movingObjectRB.velocity = Vector3.zero;
                }
                else
                {
                    isMovingObjectTouched = false;
                }
            }

            if (!isMovingObjectTouched)
            {
                float mouseX = Input.GetAxis("Mouse X");
                stoppedObjectRB.AddForce(mouseX * (-0.001f), 0, 0);
            }
        }
    }
}