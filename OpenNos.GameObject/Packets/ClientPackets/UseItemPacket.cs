////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)
using OpenNos.Core;
using OpenNos.Domain;

namespace OpenNos.GameObject.Packets.ClientPackets
{
    [PacketHeader("u_i")]
    public class UseItemPacket : PacketDefinition
    {

        [PacketIndex(2)]
        public InventoryType Type { get; set; }

        [PacketIndex(3)]
        public short Slot { get; set; }
    }
}