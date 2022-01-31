﻿using Grimoire.Game;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Grimoire.Botting.Commands.Misc.Statements
{
    public class CmdPlayerIsNotInMyCell : StatementCommand, IBotCommand
    {
        public CmdPlayerIsNotInMyCell()
        {
            Tag = "Player";
            Text = "Player is not in my cell";
        }

        public Task Execute(IBotEngine instance)
        {
            if (World.CellPsInMyCell.FirstOrDefault((PlayerInfo p) => p.Name.Equals(instance.IsVar(Value1) ? Configuration.Tempvariable[instance.GetVar(Value1)] : Value1, StringComparison.OrdinalIgnoreCase)) != null)
            {
                instance.Index++;
            }
            return Task.FromResult<object>(null);
        }

        public override string ToString()
        {
            return "Player is not in my cell: " + Value1;
        }
    }
}