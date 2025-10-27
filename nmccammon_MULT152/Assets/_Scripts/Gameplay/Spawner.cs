using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Rigidbody car;
    public Transform spawnPoint;

    void Start()
    {
        InvokeRepeating(nameof(SpawnCar), 2.0f, 2.0f);
    }

    void SpawnCar()
    {
        Rigidbody instance = Instantiate(car, spawnPoint.position, spawnPoint.rotation);
    }
}
