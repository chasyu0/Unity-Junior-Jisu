using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    private float turnSpeed = 45f;    // 회전 속도를 조절하는 변수 
    // Horizontal = 수평, Vertical = 세로 
    private float horizontalInput;
    private float verticalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Horizontal 축 입력 값 가져오기 (WASD, 좌우 화살표 키)
        horizontalInput = Input.GetAxis("Horizontal");
        // Vertical 축 입력 값 가져오기 (W/S, 상하 화살표 키)
        verticalInput = Input.GetAxis("Vertical");
        //Debug.Log("입력값: " + verticalInput); //디버그용 코드 

        // 현재 위치에서 자신의 앞 방향으로 초당 moveSpeed 만큼 이동
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // Rotates 물체를 회전시키는 함, 왼쪽을 누르면 음수가 되어 왼쪽으로 돌고, 오른쪽을 누르면 양수가 되어 오른쪽
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
