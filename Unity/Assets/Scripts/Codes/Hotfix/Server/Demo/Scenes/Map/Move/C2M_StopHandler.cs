﻿namespace ET.Server
{
	[ActorMessageHandler(SceneType.Map)]
	public class C2M_StopHandler : AMActorLocationHandler<Unit, C2M_Stop>
	{
		protected override async ETTask Run(Unit unit, C2M_Stop message)
		{
			unit.Stop(0);
			await ETTask.CompletedTask;
		}
	}
}