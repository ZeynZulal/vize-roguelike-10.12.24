using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public float FollowSpeed = 0.125f;
    public Transform target;
    void FixedUpdate()//çalýþan ama gerekli olmayan kodlar(sorunun daha kolay çözüm yolu bulunuyor)
    {

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Vector3 newPos = new Vector3(target.position.x, target.position.y, 10f);
            transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
        }
    }
}