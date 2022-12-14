using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EndPlatformScript : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _gamePlatform;
    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotation;
            
            _player.GetComponent<PlayerMove>()._playerSpeed = 1.6f;
            _player.GetComponent<Transform>().position = new Vector3(_player.transform.position.x, -0.075f,_player.transform.position.z);
            _player.GetComponent<Transform>().rotation = new Quaternion(0,0,0,0);


            

            StartCoroutine(DestroyPlatform());
        }
    }
    IEnumerator DestroyPlatform()
    {
        yield return new WaitForSeconds(8);
        Destroy(_gamePlatform);
    }
}
