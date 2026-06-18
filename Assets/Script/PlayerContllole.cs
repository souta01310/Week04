using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class PlayerContllole : MonoBehaviour
{
    private Animator anim = null;

    void Start()
    {
        EnhancedTouchSupport.Enable();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        var activeTouches = Touch.activeTouches;

        foreach (var touch in activeTouches)
        {
            // タッチした「瞬間」だけトリガーを引く
            if (touch.phase == TouchPhase.Began)
            {
                anim.SetTrigger("Attack"); 
                Debug.Log("攻撃トリガーを発動");
            }
        }
    }
}