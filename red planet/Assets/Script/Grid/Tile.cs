using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private GameObject highlight;

    private bool isClickable;



    private void OnMouseEnter()
    {
        highlight.SetActive(true);
        isClickable = true;
    }

    private void OnMouseExit()
    {
        highlight.SetActive(false);
        isClickable = false;
    }

    private void Update()
    { 
        if (isClickable && Input.GetMouseButtonDown(0))
        {
            Debug.Log(gameObject.transform.position);
            Debug.Log(gameObject.name);
        }
    }
}
