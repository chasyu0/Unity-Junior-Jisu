using UnityEngine;

public class Collectible : MonoBehaviour
{

    public float rotationSpeed;
    public GameObject onCollectEffect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }

    // Rigidbody 컴포넌트를 가진 오브젝트가 수집품과 충돌할 때 실행 
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject);

            // 파티클 효과 인스턴스화 (플레이어가 수집품과 충돌시 발생할 파티클 효과)
            Instantiate (onCollectEffect, transform.position, transform.rotation);
        }
    }

}
