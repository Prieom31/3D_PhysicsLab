using UnityEngine;
using UnityEngine.UI; 

public class WobbleCtrl : MonoBehaviour
{
    public Text l;
    public GameObject liquidObject; // Reference to the Liquid game object with the Wobble script
    public float adder = 0.1f;
    private bool isPositive = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sphere"))
        {
            Wobble wobbleScript = liquidObject.GetComponent<Wobble>();
            if (wobbleScript != null)
            {
                float increment = isPositive ? -adder : adder;
                wobbleScript.wobbleAmountToAddX += increment; 
                wobbleScript.wobbleAmountToAddZ += increment;
                isPositive = !isPositive;
                l.text = increment.ToString();
            }
        }
    }
}
