using UnityEngine;
using UnityEngine.UI;

public class DropDown : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject UI1;
    public GameObject UI2;
    public Dropdown dropdown;

    private void Start()
    {
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    private void OnDropdownValueChanged(int value)
    {
        if (value == 0) // Player 1 selected
        {
            player1.SetActive(true);
            player2.SetActive(false);
            UI1.SetActive(true);
            UI2.SetActive(false);
        }
        else if (value == 1) // Player 2 selected
        {
            player1.SetActive(false);
            player2.SetActive(true);
            UI1.SetActive(false);
            UI2.SetActive(true);
        }
    }
}

