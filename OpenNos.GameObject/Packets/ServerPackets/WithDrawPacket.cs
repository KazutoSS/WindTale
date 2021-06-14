﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using OpenNos.Core;

namespace OpenNos.GameObject.Packets.ServerPackets
{
    [PacketHeader("withdraw")]
    public class WithDrawPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public byte ShopSlot { get; set; }

        [PacketIndex(1)]
        public byte InventoryId { get; set; }

        #endregion
    }
}
