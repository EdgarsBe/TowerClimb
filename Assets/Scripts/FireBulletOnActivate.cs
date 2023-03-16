using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBulletOnActivate : MonoBehaviour
{

    public GameObject bullet;
    public Transform Spawn;
    public float speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbale = GetComponent<XRGrabInteractable>();
        grabbale.activated.AddListener(FireBullet);
    }

    public void FireBullet(ActivateEventArgs arg)
    {
        GameObject SpawnBullet = Instantiate(bullet);
        SpawnBullet.transform.position = Spawn.position;
        SpawnBullet.GetComponent<Rigidbody>().velocity = Spawn.forward * speed;
        Destroy(SpawnBullet, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
