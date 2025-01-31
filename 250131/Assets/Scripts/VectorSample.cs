using UnityEngine;

public class VectorSample : MonoBehaviour
{
    // 기본 벡터 (x, y, z) 순으로 값이 작성됨.
    Vector3 vec = new Vector3();

    float x, y, z;

    Vector3 custom_vec = new Vector3(x, y, z);

    // 유니티 기본 벡터(제공 값)
    // Vector3 a = Vector3.up;
    // up : (0, 1, 0)
    // down : (0, -1, 0)
    // left : (-1, 0, 0)
    // right : (1, 0, 0)
    // forward : (0, 0, 1)

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
