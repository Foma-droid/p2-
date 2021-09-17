using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class coinhit : MonoBehaviour
{
    public float hp = 1;
    public float damage = 1;
    public GameObject coin;
    private float currenthp;
    public GameObject chrome;
    public TextMeshProUGUI text;
    public float MinusHP()
    {
        RaycastHit2D hit = Physics2D.CircleCast(transform.position, 8.505f, Vector2.down);
        if (hit.collider.CompareTag("Coin"))
        {
            currenthp = hp - damage;
            if (currenthp == 0)
            {
                Destroy(coin.gameObject);
            }
        }

        return currenthp;

    }

    // Start is called before the first frame update
    void Start()
    {
        text.transform.LookAt(coin.transform.position);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
