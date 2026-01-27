using UnityEngine;


public class DoorOpener : MonoBehaviour
{
    private Animator doorAnimator;


    void Start()
    {
        // Get the Animator component attached to the same GameObject as this script
        doorAnimator = GetComponent<Animator>();
    }

    // 기존 플레이어 문 열리는 코드 
    //private void OnTriggerEnter(Collider other)
    //{
    //    // Check if the object entering the trigger is the player (or another specified object)
    //    if (other.CompareTag("Player")) // Make sure the player GameObject has the tag "Player"
    //    {
    //        if (doorAnimator != null)
    //        {
    //            // Trigger the Door_Open animation
    //            doorAnimator.SetTrigger("Door_Open");
    //        }
    //    }
    //}

    // bonus map 문 안열려서 디버그용 코드
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("충돌 발생: 이름: " + other.name);

        // 나(자식) 뿐만 아니라 내 부모 객체 중에 "Player"가 있는지 확인!
        if (other.CompareTag("Player") || other.transform.root.CompareTag("Player"))
        {
            Debug.Log("플레이어(자식 객체) 확인됨");
            if (doorAnimator != null)
            {
                doorAnimator.SetTrigger("Door_Open");
            }
        }
    }
}