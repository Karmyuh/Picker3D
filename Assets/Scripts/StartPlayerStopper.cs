using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StartPlayerStopper : MonoBehaviour
{
    [SerializeField] GameObject _playerStartStopper;
    [SerializeField] Text startText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            startText.text = "";
            Destroy(_playerStartStopper);
        }
    }
}
