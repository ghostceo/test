using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class m_team_mirror_get_friends_tos:OutgoingBase{
	//ID
	public int protocolID = 17904;

	//fields
	public int barrier_id = 0;
	//special field
	private short __bytesLen;


	//fill method for tos
	public override void fill2s(ByteArray ba){
		ba.WriteInt(10);
		ba.WriteInt(17904);
		ba.WriteInt(this.barrier_id);
	}
}