using UnityEngine;

public class VectorSample : MonoBehaviour
{
    // 기본 벡터 (x, y, z) 순으로 값이 작성됨.
    Vector3 vec = new Vector3();

    float x = 10.0f, y = 20.0f, z = 30.0f;

    Vector3 custom_vec = new Vector3();

    // 유니티 기본 벡터(제공 값)
    // Vector3 a = Vector3.up;
    // up : (0, 1, 0)
    // down : (0, -1, 0)
    // left : (-1, 0, 0)
    // right : (1, 0, 0)
    // forward : (0, 0, 1)

    // 벡터 기본 연산(덧셈, 뺄셈, 나눗셈, 곱셈)
    Vector3 a = new Vector3(1, 2, 0);
    Vector3 b = new Vector3(3, 4, 0);

    Vector3 some = Vector3.zero;
    float point = 5.0f;

    // 벡터 문법

    void Start()
    {
        // 덧셈 : 단계적으로 하나씩 차례대로 처리한다.
        // 순서가 변경되어도 결과는 같다.
        // 특정 포지션에서 점프한 느낌의 계산 처리
        Vector3 c = a + b;

        var trap_air = some + new Vector3(0, point);
    }

    void Update()
    {
        
    }
}
