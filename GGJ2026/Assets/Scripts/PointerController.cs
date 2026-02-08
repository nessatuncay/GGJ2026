// using UnityEngine;
// using UnityEngine.InputSystem;

// public class PointerController : MonoBehaviour
// {

//     public GameObject Bar; 
//     public Transform pointA; // Reference to the starting point
//     public Transform pointB; // Reference to the ending point
//     public RectTransform safeZone; // Reference to the safe zone RectTransform
//     public float moveSpeed = 200f; // Speed of the pointer movement
 
//     private float direction = 1f; // 1 for moving towards B, -1 for moving towards A
//     private RectTransform pointerTransform;
//     private Vector3 targetPosition;
    
//     // Added by Darren to use InputSystem
//     Keyboard keyboard;
 
//     void Start()
//     {
//         // Added by Darren to use InputSystem
//         keyboard = InputSystem.GetDevice<Keyboard>();
//         ObjectHiding();
//         pointerTransform = GetComponent<RectTransform>();
//         targetPosition = pointB.position;
        
//     }
 
//     void Update()
//     {
//         // Move the pointer towards the target position
//         pointerTransform.position = Vector3.MoveTowards(pointerTransform.position, targetPosition, moveSpeed * Time.deltaTime);
 
//         // Change direction if the pointer reaches one of the points
//         if (Vector3.Distance(pointerTransform.position, pointA.position) < 0.1f)
//         {
//             targetPosition = pointB.position;
//             direction = 1f;
//         }
//         else if (Vector3.Distance(pointerTransform.position, pointB.position) < 0.1f)
//         {
//             targetPosition = pointA.position;
//             direction = -1f;
//         }
//         // Check for input
//         if (keyboard.aKey.isPressed)
//         {
//             Debug.Log("Key Pressed: A");
//             ObjectShowing();
//             CheckSuccess();

//         }
//         if (keyboard.sKey.isPressed)
//         {
//             Debug.Log("Key Pressed: S");
//             ObjectShowing();
//             CheckSuccess();
//         }
//         if (keyboard.dKey.isPressed)
//         {
//             Debug.Log("Key Pressed: D");
//             ObjectShowing();
//             CheckSuccess();
//         }
       
        
//     }
 
//     void CheckSuccess()
//     {
//         // Check if the pointer is within the safe zone
//         if (RectTransformUtility.RectangleContainsScreenPoint(safeZone, pointerTransform.position, null))
//         {
//             Debug.Log("Pointer Check... Success!");
//         }
//         else
//         {
//             Debug.Log("Pointer Check... Failure!");
//         }
//     }


//     void ObjectHiding()
//     {
//         Bar.SetActive(false);
//     }

//     void ObjectShowing()
//     {
//         Bar.SetActive(true);
//     }
// }
