
using UnityEngine;

public class TankBehaviour : MonoBehaviour
{
    public GameObject bullet;
    public Transform initialPositicion;
    private float bulletLength = 0;
    private float separation = 0.1f;

    void Start()
    {
        bulletLength = bullet.transform.localScale.z + separation;
        Debug.Log("Tank starting bulletLength ["+ bulletLength + "] separation ["+ separation +"]");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Disparo();
        }

        //Dispara dos proyectiles a la vez.
        if (Input.GetKeyDown(KeyCode.J))
        {
            Disparo();
            Disparo(bulletLength);
        }

        //Dispara tres proyectiles a la vez.
        if (Input.GetKeyDown(KeyCode.K))
        {
            Disparo();
            Disparo(bulletLength);
            Disparo(bulletLength * 2.0f);
        }

        //Dispara cuatro proyectiles a la vez.
        if (Input.GetKeyDown(KeyCode.L))
        {
            Disparo();
            Disparo(bulletLength);
            Disparo(bulletLength * 2.0f);
            Disparo(bulletLength * 3.0f);
        }
    }

    private void Disparo()
    {
        Debug.Log("Disparo[" + initialPositicion.position + "]");
        Instantiate(bullet, initialPositicion.position, transform.rotation);
    }

    private void Disparo(float deltaPosition)
    {
        Vector3 pos = new Vector3(initialPositicion.position.x, initialPositicion.position.y, initialPositicion.position.z - deltaPosition); 
        Debug.Log("Disparo[" + pos + "]");
        Instantiate(bullet, pos, transform.rotation);
    }
}
