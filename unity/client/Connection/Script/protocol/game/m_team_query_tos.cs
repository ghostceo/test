using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class m_team_query_tos:OutgoingBase{
	//ID
	public int protocolID = 1715;

	//fields
	public int op_type = 0;
	//special field
	private short __bytesLen;


	//fill method for tos
	public override void fill2s(ByteArray ba){
		ba.WriteInt(10);
		ba.WriteInt(1715);
		ba.WriteInt(this.op_type);
	}
}