using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


[RequireComponent(typeof(Collider))]

public class Coin : MonoBehaviour
{

    [Header("Behviour")]

    private Collider _colliderComp;
    // Start is called before the first frame update
    void Start()
    {
        _colliderComp = GetComponent<Collider>();
        if (_colliderComp)
            _colliderComp.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {

        CoinText.coinValue += 1;
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
