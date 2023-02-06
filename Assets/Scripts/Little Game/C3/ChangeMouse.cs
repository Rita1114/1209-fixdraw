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

    public Button CloseB;

    public bool isclick=false;
    void Start()
    {
        CloseB.onClick.AddListener(CloseButten);
    }

    
    void Update()
    {
       isclick = Input.GetMouseButton(0);
        Debug.Log("¨åÄy");
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
        Cursor.SetCursor(oldcursor, hotSpot, cursorMode);
    }
    
}
