using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositioner : MonoBehaviour
{
    public Vector3 leftPosition, rightPosition;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerController.inst.direction == Direction.Left)
        {
            PlayerController.inst.transform.position = rightPosition;
        }
        if(PlayerController.inst.direction == Direction.Right)
        {
            PlayerController.inst.transform.position = leftPosition;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(leftPosition, 1.0f);
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(rightPosition, 1.0f);
    }
}
