﻿using System;

namespace GameServer.Templates
{
	
	public sealed class C_03_计算对象位移 : SkillTask  //C_03_CalculateObjectDisplacement
	{
		
		public C_03_计算对象位移()   //C_03_CalculateObjectDisplacement
		{
			
			
		}

		
		public bool 角色自身位移;  //角色ItSelf位移

		
		public bool 允许超出锚点;

		
		public bool 锚点反向位移;

		
		public bool 位移增加经验;  //DisplacementIncreaseExp

		
		public bool 多段位移通知;

		
		public bool 能否穿越障碍;

		
		public ushort 自身位移耗时;  //ItSelf位移耗时

		
		public ushort 自身硬直时间;  //ItSelf硬直时间

		
		public byte[] 自身位移次数;  //ItSelf位移次数

		
		public byte[] 自身位移距离;  //ItSelf位移距离

		
		public ushort 成功Buff编号;  //成功Id

		
		public float 成功Buff概率;

		
		public ushort 失败Buff编号;  //失败Id

		
		public float 失败Buff概率;

		
		public bool 推动目标位移;

		
		public bool BoostSkillExp; //BoostSkillExp

		
		public float 推动目标概率;

		
		public 指定目标类型 推动目标类型; //指定目标类型

		
		public byte 连续推动数量;

		
		public ushort 目标位移耗时;

		
		public byte[] 目标位移距离;

		
		public ushort 目标硬直时间;

		
		public ushort 目标位移编号;

		
		public float 位移Buff概率;

		
		public ushort 目标附加编号;

		
		public 指定目标类型 限定附加类型;  //指定目标类型

		
		public float 附加Buff概率;
	}
}
