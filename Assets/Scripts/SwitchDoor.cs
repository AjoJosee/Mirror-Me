
using UnityEngine;

public class SwitchDoor : MonoBehaviour
{
    public GameObject door;
    public int requiredSwitches = 2;
    private int switchesActivated = 0;

    public void ActivateSwitch()
    {
        switchesActivated++;
        CheckDoorState();
    }

    public void DeactivateSwitch()
    {
        switchesActivated--;
        CheckDoorState();
    }

  public void CheckDoorState()
    {
        if (switchesActivated >= requiredSwitches)
        {
            door.SetActive(false); // Open the door
        }
        else
        {
            door.SetActive(true); // Close the door
        }
    }
}

