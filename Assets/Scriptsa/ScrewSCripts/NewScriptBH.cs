using UnityEngine;

public class NewScriptBH : MonoBehaviour
{
    public DragDrop3 script1;
    public GetClickRotate script2;

    private void Start()
    {
        DragDrop3[] script1Array = GetComponentsInChildren<DragDrop3>();
        GetClickRotate[] script2Array = GetComponentsInChildren<GetClickRotate>();

        if (script1Array.Length > 0)
        {
            script1 = script1Array[0];
        }

        if (script2Array.Length > 0)
        {
            script2 = script2Array[1];
        }
    }

    public void EnableTheScriptDrag()
    {
        script1.gameObject.AddComponent<MonoBehaviour>();
    }

    public void DisableTheScriptDrag()
    {
        MonoBehaviour script = script1.gameObject.GetComponent<MonoBehaviour>();
        if (script != null)
        {
            Destroy(script);
        }
    }

    public void EnableTheScriptRotate()
    {
        script2.gameObject.AddComponent<MonoBehaviour>();
    }

    public void DisableTheScriptRotate()
    {
        MonoBehaviour script = script2.gameObject.GetComponent<MonoBehaviour>();
        if (script != null)
        {
            Destroy(script);
        }
    }
}


