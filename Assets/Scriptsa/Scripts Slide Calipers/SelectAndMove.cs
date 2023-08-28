using UnityEngine;

public class SelectAndMove : MonoBehaviour
{
    public float speed = 10.0f;
    private bool isSelected = false;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
        {
            isSelected = true;
        }
    }

    void FixedUpdate()
    {
        if (isSelected)
        {
            float horizontal = Input.GetAxis("Horizontal");
            Vector3 force = new Vector3(horizontal, 0, 0) * speed;
            rb.AddForce(force);
        }
    }
}
