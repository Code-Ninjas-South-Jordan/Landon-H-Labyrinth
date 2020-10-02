using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject Coin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.isTouching(Player)){
            Destroy(Coin);
        }
    }
}
