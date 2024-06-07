//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.AI;

//public class Chase : BaseState
//{

//    public Chase(GameObject _npc, NavMeshAgent _agent, Transform _player)
//        : base(_npc, _agent, _player)
//    {
//        name = STATE.CHASE;
//        agent.speed = 6f;
//        agent.isStopped = false;
//    }

//    public override void Enter()
//    {

//        agent.SetDestination(player.transform.position);
//        base.Enter();
//    }

//    public override void Update()
//    {
//        agent.SetDestination(player.transform.position);

//        if(agent.hasPath)
//        {
//            if(CanAttackPlayer())
//            {
//                NextState = new Attack(npc, agent, player);
//                stage = Event.EXIT;
//            }
//            //else if(!Spotted())
//            //{
//            //    NextState = this;
//            //    stage = Event.EXIT;
//            //}
//        }
//    }


//    public override void Exit()
//    {
//        base.Exit();
//    }
//}
