// <auto-generated>
// DO NOT EDIT
// </auto-generated>

using System.CodeDom.Compiler;
using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

namespace WowPacketParserModule.V11_0_0_55666.UpdateFields.V11_0_5_57171
{
    [GeneratedCode("UpdateFieldCodeGenerator.Formats.WowPacketParserHandler", "1.0.0.0")]
    public class ConversationLine : IConversationLine
    {
        public int ConversationLineID { get; set; }
        public int BroadcastTextID { get; set; }
        public uint StartTime { get; set; }
        public int UiCameraID { get; set; }
        public byte ActorIndex { get; set; }
        public byte Flags { get; set; }
        public byte ChatType { get; set; }
    }
}
