using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour //"coin" s�n�f�
    //"coin" s�n�f�nda "int de�eri, string isim" ba�l�klar� bulunur.
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnTriggerEnter2D(Collider2D collision)//"Player" deydi�inde coin say�s� arts�n
    {
        if (collision.gameObject.tag == "Player")
        {
            Coin_Manager.coinCount++;
            Destroy(gameObject);
        }
    }
}
