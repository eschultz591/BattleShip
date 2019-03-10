using UnityEngine;
using UnityEngine.Events;

public class CharacterController : MonoBehaviour
{

    public Rigidbody2D rb;
    public GameObject Attack;

    #region Movement Variables
    [SerializeField] private float m_HorizontalSpeed;
    [SerializeField] private float m_VerticalSpeed;

    //limits speed of diagonal movement
    private float moveLimiter = .7f;
    private Vector3 MoveVector;
    private Vector3 m_Velocity = Vector3.zero;
    #endregion



    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

    }

    public void Move(float VSpeed, float HSpeed)
    {

        rb.velocity = new Vector3(HSpeed * moveLimiter, VSpeed * moveLimiter, 0);


    }
    
    public void Click(Vector3 mouseLocation)
    {
       
        Vector3 pos = mouseLocation;
        pos.z = 10;
        pos = Camera.main.ScreenToWorldPoint(pos);
        Instantiate(Attack, pos, Quaternion.identity);




        //Vector3 mouseWorldLocation = (Camera.main.ScreenToViewportPoint(pos));



        // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();


        Debug.DrawRay(transform.position, pos);
        Debug.Log("You clicked: " + (pos));
        /*  if (Physics.Raycast (ray, out hit))
         {
             Debug.Log(hit.collider.gameObject.name);

         }*/
    }




}
