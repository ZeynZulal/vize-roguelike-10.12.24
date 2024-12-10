using UnityEngine;

public class Player : MonoBehaviour //"Player" sýnýfý
    //Player sýnýfýnda "hareket, toplanabilir eþyalar ile baðlantýlar, int can, saldýr()" baþlýklarý bulunur
    {
        Animator player;
        public Coin_Manager cm; //tanýmlamalar 
        public int coinCount = 0;  
    void Start()
    {
        player = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))//W tuþuna basýldýðýnda hareket etme doðrultusu, yönü ve çalýþtýrmasý gereken animasyon
        {
            player.SetBool("runup", true);
            transform.Translate(0, 5 * Time.deltaTime, 0);
        }
        else
        if (Input.GetKey(KeyCode.S))//S tuþuna basýldýðýnda hareket etme doðrultusu, yönü ve çalýþtýrmasý gereken animasyon
        {
            player.SetBool("rundown", true);
            transform.Translate(0, -5 * Time.deltaTime, 0);
            player.SetBool("runup", false);
        }

            if (Input.GetKey(KeyCode.D))//D tuþuna basýldýðýnda hareket etme doðrultusu, yönü ve çalýþtýrmasý gereken animasyon
            {
                player.SetBool("runright", true);
                transform.Translate(5 * Time.deltaTime, 0, 0);
            player.SetBool("runleft", false);
            }
            else
            if (Input.GetKey(KeyCode.A))//A tuþuna basýldýðýnda hareket etme doðrultusu, yönü ve çalýþtýrmasý gereken animasyon
            {
                player.SetBool("runleft", true);
                transform.Translate(-5 * Time.deltaTime, 0, 0);
            player.SetBool("runright", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      if(other.gameObject.tag=="VictoryPoint" )
        {
            FindObjectOfType<SceneManagement>().LoadLevel();
        }
    }
}

