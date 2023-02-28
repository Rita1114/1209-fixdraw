using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMouse : MonoBehaviour
{

    public Texture2D cursorTexture;
    public Texture2D oldcursor=null;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    public Button CloseBt;
    public GameObject Draw;

    public bool isclick=false;
    void Start()
    {
        CloseBt.onClick.AddListener(CloseButten);
    }

    
    void Update()
    {
       isclick = Input.GetMouseButton(0);
        if (isclick)
        {
            Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        }
        else
        {
            Cursor.SetCursor(oldcursor, hotSpot, cursorMode);
        }
    }
    public void CloseButten()
    {
        Debug.Log("DDDDDDDDD");
        Cursor.SetCursor(oldcursor, hotSpot, cursorMode);
        Draw.SetActive(false);
    }
    
}
