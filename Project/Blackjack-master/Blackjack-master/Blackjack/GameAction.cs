// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GameAction.cs" company="Konstantin Tarkus">
//   Copyright © 2013 Konstantin Tarkus (hello@tarkus.me)
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Blackjack
{
    using System;

    
    [Flags]
    public enum GameAction : byte
    {
        // TODO: Add support of other actions
        None  = 1,
        Deal  = 2,
        Stand = 4,
        Hit   = 8
    }
}
