﻿using System;
using System.Collections.Generic;
using System.Text;
using EtherBetClientLib.Models;
using EtherBetClientLib.Models.Games.Poker;
using EtherBetClientLib.Models.Games.Poker.Interfaces;
using EtherBetClientLib.Networking;

namespace EtherBetClientLib.Core.Game.Poker.Logic
{
    public class PokerPlayer : Player, IPokerPlayer
    {
        public PokerTable CurrentTable { get; set; }
        public PokerRound CurrentRound { get; set; }
        public int CurrentChipAmount { get; set; }
        public int LeftChipsAfterBet { get; set; }
        public int CurrentBetAmount { get; set; }

        public PokerPlayer(PlayerNetworkClient client)
        {
        }
    }
}