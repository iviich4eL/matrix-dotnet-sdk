﻿using System;
using System.Collections.Generic;
namespace MatrixSDK.Structures
{
	/// <summary>
	/// http://matrix.org/docs/spec/r0.0.1/client_server.html#m-room-power-levels
	/// </summary>
	public class MatrixMRoomPowerLevels : MatrixEventContent
	{
		public Dictionary<string,int> users;
		public int state_default;
		public int users_default;
		public int events_default;
		public int redact;
		public int ban;
		public int kick;
		public Dictionary<string,int> events;

	}
}

