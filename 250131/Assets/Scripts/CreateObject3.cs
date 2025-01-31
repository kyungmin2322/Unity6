using UnityEngine;

public class CreateObject3 : MonoBehaviour
{
    // 직렬화
    // 특정 데이터나 오브젝트를 컴퓨터 환경에 저장하고
    // 재구성할 수 있는 형태(포맷)로 변환하는 과정
    // 유니티에서는 간단하게 private 형태의 데이터를
    // 인스펙터에서 읽을 수 있게 설정해준다 라고 이해하면 좋다.
    [SerializeField] private GameObject prefab;
    private int dummy;

    [SerializeField] GameObject sample;

    void Start()
    {
        prefab = Resources.Load<GameObject>("Prefabs/Table_Body");
    }

    void Update()
    {
        // 입력 받은 키가 스페이스일 경우
        // ~ Down : 키 한 번 입력
        // ~ Up : 입력 후 뗐을 경우
        // ~ : 누르고 있는 동안
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Resources.Load<T>("폴더위치/에셋명");
            // T는 데이터의 형태를 적어주는 위치

            // Sprite sprite = Resources.Load<Sprite>("Sprites/sprite01");

            sample = Instantiate(prefab);
            sample.AddComponent<VectorSample>();
        }
    }
}
