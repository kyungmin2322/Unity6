using UnityEngine;

public class VectorSample : MonoBehaviour
{
    // �⺻ ���� (x, y, z) ������ ���� �ۼ���.
    Vector3 vec = new Vector3();

    float x = 10.0f, y = 20.0f, z = 30.0f;

    Vector3 custom_vec = new Vector3();

    // ����Ƽ �⺻ ����(���� ��)
    // Vector3 a = Vector3.up;
    // up : (0, 1, 0)
    // down : (0, -1, 0)
    // left : (-1, 0, 0)
    // right : (1, 0, 0)
    // forward : (0, 0, 1)

    // ���� �⺻ ����(����, ����, ������, ����)
    Vector3 a = new Vector3(1, 2, 0);
    Vector3 b = new Vector3(3, 4, 0);

    Vector3 some = Vector3.zero;
    float point = 5.0f;

    // ���� ����

    void Start()
    {
        // ���� : �ܰ������� �ϳ��� ���ʴ�� ó���Ѵ�.
        // ������ ����Ǿ ����� ����.
        // Ư�� �����ǿ��� ������ ������ ��� ó��
        Vector3 c = a + b;

        var trap_air = some + new Vector3(0, point);
    }

    void Update()
    {
        
    }
}
