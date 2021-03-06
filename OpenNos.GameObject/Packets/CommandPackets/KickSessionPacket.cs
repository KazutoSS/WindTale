////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using OpenNos.Core;
using OpenNos.Domain;

namespace OpenNos.GameObject.CommandPackets
{
    [PacketHeader("$KickSession", PassNonParseablePacket = true, Authorities = new AuthorityType[]{ AuthorityType.GM } )]
    public class KickSessionPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public string AccountName { get; set; }

        [PacketIndex(1)]
        public int? SessionId { get; set; }

        public static string ReturnHelp() => "$KickSession <Username> <?SessionId>";

        #endregion
    }
}