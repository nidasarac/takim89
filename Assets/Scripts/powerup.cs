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

        if (other.gameObject.CompareTag("powerup0"))
        {
            Destroy(other.gameObject);
        }
        
        if (other.gameObject.CompareTag("powerup1"))
        {
            Destroy(other.gameObject);
            _thirdPersonController.JumpHeight = 30.0f;
            Invoke("BackToNormalHeight",5.0f);
        }
    }

    private void BackToNormalSpeed()
    {
        _thirdPersonController.SprintSpeed = 5.33f;
    }
    
    private void BackToNormalHeight()
    {
        _thirdPersonController.JumpHeight = 1.2f;
    }
}
