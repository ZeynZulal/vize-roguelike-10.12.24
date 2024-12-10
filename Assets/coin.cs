using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour //"coin" sýnýfý
    //"coin" sýnýfýnda "int deðeri, string isim" baþlýklarý bulunur.
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnTriggerEnter2D(Collider2D collision)//"Player" deydiðinde coin sayýsý artsýn
    {
        if (collision.gameObject.tag == "Player")
        {
            Coin_Manager.coinCount++;
            Destroy(gameObject);
        }
    }
}
