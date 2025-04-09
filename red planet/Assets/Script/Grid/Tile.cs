using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private GameObject highlight;

    private bool isClickable;

    [SerializeField] private GameObject inventoryManager;
    private Inventory inventory;

    private void Start()
    {
        inventoryManager = GameObject.FindGameObjectWithTag("Inventory Manager");
        inventory = inventoryManager.GetComponent<Inventory>();
    }


    private void OnMouseEnter()
    {
        if (inventory.isInvetoryOpened)
        {
            highlight.SetActive(true);
            isClickable = true;
        }
    }

    private void OnMouseExit()
    {
        if (inventory.isInvetoryOpened)
        {
            highlight.SetActive(false);
            isClickable = false;
        }
    }

    private void Update()
    { 
        if (isClickable && Input.GetMouseButtonDown(0))
        {
            Debug.Log(gameObject.transform.position);
            Debug.Log(gameObject.name);
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            highlight.SetActive(false);
            isClickable = false;
        }
    }
}
