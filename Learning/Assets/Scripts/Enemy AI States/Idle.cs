//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.AI;

//public class Idle : BaseState
//{
//    public Idle(GameObject _npc, NavMeshAgent _agent, Transform _player)
//        : base(_npc, _agent, _player)
//    {
//        name = STATE.IDLE;
//    }

//    public override void Enter()
//    {
//        base.Enter();
//    }

//    public override void Update()
//    {
//        if(Spotted())
//        {
//            NextState = new Chase(npc, agent, player);
//            stage = Event.EXIT;
//        }
//        else if(true)
//        {
//            NextState = new Patrol(npc, agent, player);
//            stage = Event.EXIT;
//        }

//    }

//    public override void Exit()
//    {
//        base.Exit();
//    }
//}