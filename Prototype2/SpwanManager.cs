using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomAnimal() {
        // 1. 무작위 동물을 고름
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        // 2. 무작위 생성 위치 계산 (x값 랜덤, z값은 고정)
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        // 3. 생성 실행! (위치 자리에 spawnpos만 정확히 넣어줌)
        Instantiate(animalPrefabs[animalIndex], spawnpos, animalPrefabs[animalIndex].transform.rotation);
    }
}

