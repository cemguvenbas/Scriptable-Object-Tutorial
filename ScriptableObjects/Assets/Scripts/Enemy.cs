using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyType enemyType = null;
    void Start()
    {
        GetComponent<Renderer>().material.color = enemyType.enemyColor;
        transform.localScale = enemyType.enemyScale;
    }

}
