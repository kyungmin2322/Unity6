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
        Debug.Log("�ƾ� ����ũ �׽�Ʈ");
        yield return new WaitForSeconds(1);

        // yield�� �Ͻ������� CPU�� ������ �ٸ� �Լ��� �����ϴ� Ű�����̴�.

        Debug.Log("�丸 �԰� �ð�");
        yield return new WaitForSeconds(5);
        Debug.Log("�ٽ� ���� �غ���?");
    }
}
