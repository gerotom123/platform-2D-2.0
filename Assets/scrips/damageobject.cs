﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageobject : MonoBehaviour
{          
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Player la quedo");
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
        }
    }

}
