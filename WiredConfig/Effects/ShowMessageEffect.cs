﻿using Sulakore.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiredConfig.Effects
{
    class ShowMessageEffect : IWired
    {

        public void SendMessage(int itemId)
        {
            HMessage message = new HMessage(Form.wiredEffectData);
            message.WriteBoolean(false);
            message.WriteInteger(5);
            message.WriteInteger(0);
            message.WriteInteger(3389);
            message.WriteInteger(itemId);
            message.WriteString("");
            message.WriteInteger(0);
            message.WriteInteger(0);
            message.WriteInteger(7);
            message.WriteInteger(0);
            message.WriteInteger(0);
            Form.connection.SendToClientAsync(message);
        }
    }
}
