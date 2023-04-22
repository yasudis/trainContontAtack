using UnityEngine;

public class BulletForEnemyTank : MonoBehaviour
{
    // Start is called before the first frame update
    private float damadge = 0.5f;
    PlayerUnit damadgePlayer;
    // private float time;
    // Start is called before the first frame update
    void Start()
    {
        damadge = EnemyManadger.damadgeTank;
        // time = 0;
    }
    void FixedUpdate()
    {
        transform.position += transform.forward * 100f * Time.deltaTime;
        //time += time + Time.time;
        Destroy(gameObject, 5f);
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject whois = other.gameObject;

        if (whois.tag == "Player")
        {
            damadgePlayer = whois.GetComponent<PlayerUnit>();
            Debug.Log("Zadel Player");
            Destroy(gameObject);
            damadgePlayer.DamadgePlayer(damadge);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
