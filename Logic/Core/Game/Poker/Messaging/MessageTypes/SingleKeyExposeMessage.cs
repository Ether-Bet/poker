﻿using System.Numerics;
using EtherBetClientLib.Crypto.Encryption.SRA;
using ProtoBuf;

namespace EtherBetClientLib.Core.Game.Poker.Messaging.MessageTypes
{
    [ProtoContract]
    class SingleKeyExposeMessage : IPokerMessage
    {
        [ProtoMember(1)]
        public int CardIndex { get; set; }

        /// <summary>
        /// 0-based index of card
        /// </summary>
        [ProtoMember(2)]
        public SraParameters Key { get; set; }
    }
}
