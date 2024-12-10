using UnityEngine;

public class Player : MonoBehaviour //"Player" s�n�f�
    //Player s�n�f�nda "hareket, toplanabilir e�yalar ile ba�lant�lar, int can, sald�r()" ba�l�klar� bulunur
    {
        Animator player;
        public Coin_Manager cm; //tan�mlamalar 
        public int coinCount = 0;  
    void Start()
    {
        player = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))//W tu�una bas�ld���nda hareket etme do�rultusu, y�n� ve �al��t�rmas� gereken animasyon
        {
            player.SetBool("runup", true);
            transform.Translate(0, 5 * Time.deltaTime, 0);
        }
        else
        if (Input.GetKey(KeyCode.S))//S tu�una bas�ld���nda hareket etme do�rultusu, y�n� ve �al��t�rmas� gereken animasyon
        {
            player.SetBool("rundown", true);
            transform.Translate(0, -5 * Time.deltaTime, 0);
            player.SetBool("runup", false);
        }

            if (Input.GetKey(KeyCode.D))//D tu�una bas�ld���nda hareket etme do�rultusu, y�n� ve �al��t�rmas� gereken animasyon
            {
                player.SetBool("runright", true);
                transform.Translate(5 * Time.deltaTime, 0, 0);
            player.SetBool("runleft", false);
            }
            else
            if (Input.GetKey(KeyCode.A))//A tu�una bas�ld���nda hareket etme do�rultusu, y�n� ve �al��t�rmas� gereken animasyon
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

