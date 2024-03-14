using UnityEngine;

public class BananaBomb : MonoBehaviour
{
    //Задай параметры радиуса, урона, таймера и скорости запуска
    public float Radius = 5;
    public float Damage = 80;
    public float Timer = 3;
    public float LaunchSpeed = 20;

    void Start()
    {
        //Ставим таймер на вызов взрыва
        Invoke("Explode", ???);
        //Запускаем банановую бомбу вперед
        GetComponent<Rigidbody>().velocity = transform.forward * LaunchSpeed;
    }

    void Explode()
    {
        //Находим все коллайдеры в радиусе взрыва
        Collider[] colliders = Physics.OverlapSphere(transform.position, ???);
        for (int i = 0; i < colliders.Length; i++)
        {
            //Предполагаем, что коллайдер - это враг
            EnemyHealth enemyHealth = colliders[i].GetComponent<???>();
            if (enemyHealth != null)
            {
                //Если это так, то наносим урон
                enemyHealth.TakeDamage(???);
            }
        }
        //Уничтожаем бомбу
        Destroy(???);
    }
}