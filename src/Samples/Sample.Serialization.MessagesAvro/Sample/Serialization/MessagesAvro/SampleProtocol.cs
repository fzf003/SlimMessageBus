// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen, version 1.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Sample.Serialization.MessagesAvro
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public abstract class SampleProtocol : Avro.Specific.ISpecificProtocol
	{
		private static readonly Avro.Protocol protocol = Avro.Protocol.Parse(@"{""protocol"":""SampleProtocol"",""namespace"":""Sample.Serialization.MessagesAvro"",""types"":[{""type"":""record"",""name"":""AddCommand"",""namespace"":""Sample.Serialization.MessagesAvro"",""fields"":[{""name"":""OperationId"",""type"":""string""},{""name"":""Left"",""type"":""int""},{""name"":""Right"",""type"":""int""}]},{""type"":""record"",""name"":""MultiplyRequest"",""namespace"":""Sample.Serialization.MessagesAvro"",""fields"":[{""name"":""OperationId"",""type"":""string""},{""name"":""Left"",""type"":""int""},{""name"":""Right"",""type"":""int""}]},{""type"":""record"",""name"":""MultiplyResponse"",""namespace"":""Sample.Serialization.MessagesAvro"",""fields"":[{""name"":""OperationId"",""type"":""string""},{""name"":""Result"",""type"":""int""}]}],""messages"":{}}");
		public Avro.Protocol Protocol
		{
			get
			{
				return protocol;
			}
		}
		public void Request(Avro.Specific.ICallbackRequestor requestor, string messageName, object[] args, object callback)
		{
			;
		}
	}
}
