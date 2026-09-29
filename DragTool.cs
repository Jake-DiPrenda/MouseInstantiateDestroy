using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class DragTool : MonoBehaviour
{
    private Vector3 mousePositionOffset;

    private Vector3 GetMouseWroldPosition()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDown()
    {
        mousePositionOffset = transform.position - GetMouseWroldPosition();
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWroldPosition() + mousePositionOffset;
    }

}