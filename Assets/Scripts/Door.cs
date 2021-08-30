using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private GameObject door_left;
    [SerializeField] private GameObject door_right;
    [SerializeField] private float moveXLeftDoor;
    [SerializeField] private float moveXRightDoor;
    private Vector3 leftDoorPos;
    private Vector3 rightDoorPos;
    private bool isDoorOpen;

    // Start is called before the first frame update
    void Start()
    {
        leftDoorPos = door_left.transform.localPosition;
        rightDoorPos = door_right.transform.localPosition;
        isDoorOpen = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(MainManager.instance.GetPlayerTag()) && !isDoorOpen)
        {
            isDoorOpen = true;
           
            LeanTween.moveLocalX(door_left, leftDoorPos.x + moveXLeftDoor, 1f);
            LeanTween.moveLocalX(door_right, rightDoorPos.x -moveXRightDoor, 1f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(MainManager.instance.GetPlayerTag()))
        {
            if (isDoorOpen)
            {
                isDoorOpen = false;

                LeanTween.moveLocalX(door_left, leftDoorPos.x, 1f);
                LeanTween.moveLocalX(door_right, rightDoorPos.x, 1f);

            }
        }
    }

}
