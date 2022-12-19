using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NPCState
{
    Search,
    LadderSet,

}

public class NonPlayer : MonoBehaviour
{

    // 상태 전환을 통해 NonPlayer의 상태를 관리한다.

    /* 탐색
     * 내 범위 내로 들어온 바닥에 놓여진 사다리로 랜덤하게 이동한다.
     * - 레이어 처리를 통해 습득한 사다리, 놓여진 사다리 등은 탐지하지 않게 구분한다.
     * - 
     * 
     */

    /* 습득
     * 인터페이스나 abstract로 받아서 사다리가 쌓이는 부분 관리
     * 
     */

    /* 사다리 설치
     * 일정 개수 이상의 사다리가 쌓이면 가까운 설치 구역으로 이동하여 설치한다.
     * 설치를 하면 습득한 사다리가 하나씩 감소하고, 해당 구역에 사다리가 추가된다.
     * 사다리가 없을 때 까지 내려간다.
     * 사다리가 없으면 다시 위로 올라가서 탐색 상태가 된다.
     * 설치된 사다리의 자신의 사다리가 다 쌓여져 있는지 체크하고, 다 쌓이면 아래층으로 내려간다. 
     */
}
