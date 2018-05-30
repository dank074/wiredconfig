using WiredConfig.Effects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Sulakore.Communication;
using Sulakore.Habbo.Messages;
using Sulakore.Modules;
using Sulakore.Protocol;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tangine;
using WiredConfig.Triggers;

namespace WiredConfig
{

    [Module("Wired Config", "Noob retros didnt implement server checks lmfao")]
    [Author("lincoln67", HabboName = "furiousdragon", Hotel = Sulakore.Habbo.HHotel.Com)]
    public partial class Form : ExtensionForm
    {
        public static ushort wiredEffectData = 0;
        public static ushort wiredTriggerData = 0;
        public static ushort wiredConditionData = 0;
        public static ushort wiredSaved = 0;
        public static IHConnection connection;

        private Boolean isActivated = false;
        Hashtable wireds = new Hashtable();
        private String selected = "showMessage";


        public Form()
        {
            InitializeComponent();
            wiredEffectData = this.In.WiredEffectData;
            wiredTriggerData = this.In.WiredTriggerData;
            wiredSaved = this.In.WiredSaved;
            wiredConditionData = this.In.WiredConditionData;
            connection = this.Connection;

            wireds.Add("showMessage", new ShowMessageEffect());
            wireds.Add("moveAndRotate", new MoveAndRotateFurniEffect());
            wireds.Add("teleportToFurni", new TeleportToFurni());
            wireds.Add("toggleFurni", new ToggleFurniStateEffect());
            wireds.Add("timerReset", new TimerResetEffect());
            wireds.Add("givePoints", new GivePointsEffect());
            wireds.Add("matchFurni", new MatchFurniToPositionStateEffect());
            wireds.Add("botWhispers", new BotTalksToUserEffect());
            wireds.Add("botTalks", new BotTalkToAllEffect());
            wireds.Add("userSays", new UserSaysTrigger());
        }

        public override void HandleOutgoing(DataInterceptedEventArgs e)
        {
            //    Console.WriteLine("OuTOING! > " + e.Packet.Header);
            //

            if (e.Packet.Header == this.Out.ToggleFloorItem && this.isActivated)
            {
                ((IWired)wireds[selected]).SendMessage(e.Packet.ReadInteger());
            }
            base.HandleOutgoing(e);
        }
        public override void HandleIncoming(DataInterceptedEventArgs e)
        {
            base.HandleIncoming(e);
        }


        public const string version = "221";


        private void ToggleActivation_Click(object sender, EventArgs e)
        {
            this.isActivated = !isActivated;
            ToggleActivation.Text = this.isActivated ? "Enabled" : "Disabled";
            ToggleActivation.BackColor = this.isActivated ? Color.LightGreen : Color.LightCoral;
            if (this.isActivated)
            {
                HMessage message = new HMessage(this.In.UserPermissions);
                message.WriteInteger(9);
                message.WriteInteger(9);
                message.WriteBoolean(true);
                this.Connection.SendToClientAsync(message);
            }
        }

        private void showMessage_CheckedChanged(object sender, EventArgs e)
        {
            if (showMessage.Checked)
            {
                selected = "showMessage";
            }
        }

        private void moveAndRotate_CheckedChanged(object sender, EventArgs e)
        {
            if (moveAndRotate.Checked)
            {
                selected = "moveAndRotate";
            }
        }

        private void teleportToFurni_CheckedChanged(object sender, EventArgs e)
        {
            if (teleportToFurni.Checked)
            {
                selected = "teleportToFurni";
            }
        }

        private void toggleFurni_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleFurni.Checked)
            {
                selected = "toggleFurni";
            }
        }

        private void timerReset_CheckedChanged(object sender, EventArgs e)
        {
            if (timerReset.Checked)
            {
                selected = "timerReset";
            }
        }

        private void givePoints_CheckedChanged(object sender, EventArgs e)
        {
            if (givePoints.Checked)
            {
                selected = "givePoints";
            }
        }

        private void matchFurni_CheckedChanged(object sender, EventArgs e)
        {
            if (matchFurni.Checked)
            {
                selected = "matchFurni";
            }
        }

        private void botWhispers_CheckedChanged(object sender, EventArgs e)
        {
            if (botWhispers.Checked)
            {
                selected = "botWhispers";
            }
        }

        private void botTalks_CheckedChanged(object sender, EventArgs e)
        {
            if (botTalks.Checked)
            {
                selected = "botTalks";
            }
        }

        private void userSays_CheckedChanged(object sender, EventArgs e)
        {
            if (userSays.Checked)
            {
                selected = "userSays";
            }
        }
    }
}
