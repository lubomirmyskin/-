using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Player player = GetComponent<Player>();

        player.CollectCoins();

        Destroy(gameObject);
    }
}
