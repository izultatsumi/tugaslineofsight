using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class enemy : MonoBehaviour
{


    void Start()
    {
    }

    void Update()
    {
        Look();
    }

    

    void Look()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo))
        {
            Vector3 lookDir = new Vector3(hitInfo.point.x, transform.position.y, hitInfo.point.z);
            Vector3 targetRotation = Quaternion.LookRotation(lookDir - transform.position).eulerAngles;
            targetRotation = new Vector3(0, targetRotation.y, 0);

            transform.rotation = Quaternion.Euler(targetRotation);
        }
    }
}
