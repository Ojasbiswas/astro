using UnityEngine;

public class Sword : MonoBehaviour
{
    private Transform m_transform;
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_transform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
       
        LAMouse();
    }

    private void LAMouse()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - m_transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        bool isFacingLeft = player.transform.localScale.x < 0;

        if (isFacingLeft)
        {
            // Flip the angle for left side
            angle += 180f;

            // Keep angle between -180 and 180
            if (angle > 180f) angle -= 360f;
        }

        // Now clamp the flipped or normal angle between -40 and 40
        angle = Mathf.Clamp(angle, -40f, 40f);

        // Apply rotation in world space
        m_transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }



}
