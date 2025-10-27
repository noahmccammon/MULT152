using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{
    public GameManager manager;
    public float speed = 20f;
    [SerializeField] private int damageAmount = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<HealthComponent>();
        if (player != null)
        {       
            player.Damage(damageAmount);
            Destroy(gameObject);
        }
    }
}
