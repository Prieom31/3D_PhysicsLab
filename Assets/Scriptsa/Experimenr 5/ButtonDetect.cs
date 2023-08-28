using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonDetect : MonoBehaviour, IPointerUpHandler
{
    public PlayerBehave playerBehaviour;

    public void OnPointerUp(PointerEventData eventData)
    {
      /*  playerBehaviour.OnForwardButtonReleased();
        playerBehaviour.OnBackwardButtonReleased();*/
    }
}
