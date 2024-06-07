//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.AI;

//public class Patrol : BaseState
//{
//    int currentindex = -1;

//    public Patrol(GameObject _npc, NavMeshAgent _agent, Transform _player)
//            : base(_npc, _agent, _player)
//    {
//        name = STATE.PATROL;
//        agent.speed = 7f;
//        agent.isStopped = false; 
//    }

//    public override void Enter()
//    {
//        base.Enter();
//    }    
    
//    public override void Update()
//    {
//        if (Spotted())
//        {
//            NextState = new Chase(npc, agent, player);
//            stage = Event.EXIT;
//        }
//    }
    

//    public override void Exit()
//    {
//        base.Exit();
//    }
//}
