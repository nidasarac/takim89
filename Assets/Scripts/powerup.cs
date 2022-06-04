using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class powerup : MonoBehaviour
{
    private ThirdPersonController _thirdPersonController;
    private void Start()
    {
        _thirdPersonController = GetComponent<ThirdPersonController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("powerup"))
        {
            Destroy(other.gameObject);
            _thirdPersonController.SprintSpeed = 10.0f;
            Invoke("BackToNormalSpeed",3.0f);
        }
    }

    private void BackToNormalSpeed()
    {
        _thirdPersonController.SprintSpeed = 5.33f;
    }
}
