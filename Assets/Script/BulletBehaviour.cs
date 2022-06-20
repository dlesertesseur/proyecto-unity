using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float speed = 0.001f;
    public float damage = 0;
    public Vector3 direction;

    void Start()
    {
        direction = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Debug.Log("Bullet starting speed[" +speed+ "] direction[" + direction + "] damage["+damage+"]");
    }

    void Update()
    {
        direction.z += speed;
        transform.position = direction;
    }

    public float IncreaseDamage()
    {
        damage++;
        return(damage);
    }

    public float DecreaseDamage()
    {
        damage--;
        return (damage);
    }


}
