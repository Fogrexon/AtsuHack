using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawBlock : MonoBehaviour
{
    public Transform blockParent;
    public GameObject blockPrefab;
    bool flag = false;
    Vector3 start;
    GameObject templateGameObject;
    Transform templateTransform;
    public int boxCount = 0;
    public bool isBoxBanned = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isBoxBanned) {
            flag = true;
            start = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            templateGameObject = Instantiate(blockPrefab);
            templateTransform = templateGameObject.transform;
            templateTransform.parent = blockParent;
        }
        if (Input.GetMouseButton(0) && flag) {
            Vector3 middlePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 center = new Vector3((middlePos.x + start.x)/2f, (middlePos.y + start.y)/2f, 0f);
            templateTransform.position = center;
            templateTransform.localScale = new Vector3(Mathf.Abs(middlePos.x - start.x), Mathf.Abs(middlePos.y - center.y) * 2f, 1f);
        }
        if (Input.GetMouseButtonUp(0) || (flag && isBoxBanned)) {
            flag = false;
            boxCount ++;
            templateGameObject.GetComponent<BoxCollider2D>().enabled = true;
            templateGameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            templateGameObject.GetComponent<Rigidbody2D>().mass = 999f;
        }
        isBoxBanned = false;
    }
}
