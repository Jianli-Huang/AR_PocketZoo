using HedgehogTeam.EasyTouch;
using UnityEngine;

public class GestureEvents : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        //初始化 Animator 组件，用户切换动画
        animator = GetComponent<Animator>();
    }

    //在脚本被激活时，将切换动画的事件绑定到 Tap 手势上
    private void OnEnable()
    {
        EasyTouch.On_SimpleTap += NextAnimationEvent;
    }

    //在脚本被关闭时，移除 Tap 手势上的切换动画事件
    private void OnDisable()
    {
        EasyTouch.On_SimpleTap -= NextAnimationEvent;
    }

    //切换动画的具体事件
    private void NextAnimationEvent(Gesture gesture)
    {
        animator.SetTrigger("Next");

    }
}