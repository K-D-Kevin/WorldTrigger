using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveAxisUiDebug : MonoBehaviour
{
    [SerializeField]
    private RectTransform Joystick;
    [SerializeField]
    private RectTransform JoystickInitialPosition;
    [SerializeField]
    private RectTransform MaxBoundsY;
    [SerializeField]
    private RectTransform MaxBoundsX;

    public void SetJoystickPosition(Vector2 InputRange, bool Normalize = false)
    {
        Vector2 tempRange = InputRange;
        if (Normalize)
            tempRange = tempRange.normalized;
        float PositionX = tempRange.x * (MaxBoundsX.position.x - JoystickInitialPosition.position.x);
        float PositionY = tempRange.y * (MaxBoundsY.position.y - JoystickInitialPosition.position.y);
        Joystick.position = new Vector3(JoystickInitialPosition.position.x + PositionX, JoystickInitialPosition.position.y + PositionY, 0);
    }
}
