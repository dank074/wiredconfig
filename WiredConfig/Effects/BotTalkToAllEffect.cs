﻿using Sulakore.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiredConfig.Effects
{
    class BotTalkToAllEffect : IWired
    {
        public void SendMessage(int itemId)
        {
            HMessage message = new HMessage(Form.wiredEffectData);
            message.WriteBoolean(false);
            message.WriteInteger(5);
            message.WriteInteger(0);
            message.WriteInteger(7557);
            message.WriteInteger(itemId);
            message.WriteString(((char)9).ToString());
            message.WriteInteger(1);
            message.WriteInteger(0);
            message.WriteInteger(0);
            message.WriteInteger(23);
            message.WriteInteger(0);
            message.WriteInteger(0);
            Form.connection.SendToClientAsync(message);
        }
    }
}
