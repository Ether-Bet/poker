﻿using System.Security.Cryptography;
using MPLib.Networking;

namespace MPLib.Models.Games
{
    public class Player
    {
        public static Player Me { get; } = null;

        /// <summary>
        /// ECDSA singing key of player. this property contains full (private + public) key if this player is "our" (local)  player
        /// Otherwise if this player is remotely connected this property contains only public key
        /// </summary>
        public CngKey Key { get; set; }

        public virtual string Name { get; internal set; }

        public bool IsPlaying { get; internal set; }

        public bool IsMyPlayer => NetworkStream != null;

        internal PlayerNetworkStream NetworkStream { get; }

    }
}
