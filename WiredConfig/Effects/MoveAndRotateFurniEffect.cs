﻿using Sulakore.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiredConfig.Effects
{
    class MoveAndRotateFurniEffect : IWired
    {
        public void SendMessage(int itemId)
        {
            HMessage message = new HMessage(Form.wiredEffectData);
            message.WriteBoolean(false);
            message.WriteInteger(5);
            message.WriteInteger(0);
            message.WriteInteger(3371);
            message.WriteInteger(itemId);
            message.WriteString("");
            message.WriteInteger(2);
            message.WriteInteger(0);
            message.WriteInteger(0);
            message.WriteInteger(0);
            message.WriteInteger(4);
            message.WriteInteger(5);
            message.WriteInteger(0);
            Form.connection.SendToClientAsync(message);
        }
    }
}
