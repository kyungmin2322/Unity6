using System.Collections;
using UnityEngine;

public class TextCount : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("CountPlus");
    }

    IEnumerator CountPlus()
    {
        Debug.Log("아아 마이크 테스트");
        yield return new WaitForSeconds(1);

        // yield는 일시적으로 CPU의 권한을 다른 함수에 위임하는 키워드이다.

        Debug.Log("밥만 먹고 올게");
        yield return new WaitForSeconds(5);
        Debug.Log("다시 일을 해볼까?");
    }
}
