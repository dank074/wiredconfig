namespace WiredConfig
{
    partial class Form 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

 
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.showMessage = new System.Windows.Forms.RadioButton();
            this.moveAndRotate = new System.Windows.Forms.RadioButton();
            this.teleportToFurni = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toggleFurni = new System.Windows.Forms.RadioButton();
            this.timerReset = new System.Windows.Forms.RadioButton();
            this.givePoints = new System.Windows.Forms.RadioButton();
            this.matchFurni = new System.Windows.Forms.RadioButton();
            this.botWhispers = new System.Windows.Forms.RadioButton();
            this.botTalks = new System.Windows.Forms.RadioButton();
            this.userSays = new System.Windows.Forms.RadioButton();
            this.ToggleActivation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showMessage
            // 
            this.showMessage.AutoSize = true;
            this.showMessage.Location = new System.Drawing.Point(32, 46);
            this.showMessage.Name = "showMessage";
            this.showMessage.Size = new System.Drawing.Size(98, 17);
            this.showMessage.TabIndex = 0;
            this.showMessage.TabStop = true;
            this.showMessage.Text = "Show Message";
            this.showMessage.UseVisualStyleBackColor = true;
            this.showMessage.CheckedChanged += new System.EventHandler(this.showMessage_CheckedChanged);
            // 
            // moveAndRotate
            // 
            this.moveAndRotate.AutoSize = true;
            this.moveAndRotate.Location = new System.Drawing.Point(32, 70);
            this.moveAndRotate.Name = "moveAndRotate";
            this.moveAndRotate.Size = new System.Drawing.Size(135, 17);
            this.moveAndRotate.TabIndex = 1;
            this.moveAndRotate.TabStop = true;
            this.moveAndRotate.Text = "Move And Rotate Furni";
            this.moveAndRotate.UseVisualStyleBackColor = true;
            this.moveAndRotate.CheckedChanged += new System.EventHandler(this.moveAndRotate_CheckedChanged);
            // 
            // teleportToFurni
            // 
            this.teleportToFurni.AutoSize = true;
            this.teleportToFurni.Location = new System.Drawing.Point(32, 94);
            this.teleportToFurni.Name = "teleportToFurni";
            this.teleportToFurni.Size = new System.Drawing.Size(106, 17);
            this.teleportToFurni.TabIndex = 2;
            this.teleportToFurni.TabStop = true;
            this.teleportToFurni.Text = "Teleport To Furni";
            this.teleportToFurni.UseVisualStyleBackColor = true;
            this.teleportToFurni.CheckedChanged += new System.EventHandler(this.teleportToFurni_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Effects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Triggers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Conditions";
            // 
            // toggleFurni
            // 
            this.toggleFurni.AutoSize = true;
            this.toggleFurni.Location = new System.Drawing.Point(32, 118);
            this.toggleFurni.Name = "toggleFurni";
            this.toggleFurni.Size = new System.Drawing.Size(112, 17);
            this.toggleFurni.TabIndex = 6;
            this.toggleFurni.TabStop = true;
            this.toggleFurni.Text = "Toggle Furni State";
            this.toggleFurni.UseVisualStyleBackColor = true;
            this.toggleFurni.CheckedChanged += new System.EventHandler(this.toggleFurni_CheckedChanged);
            // 
            // timerReset
            // 
            this.timerReset.AutoSize = true;
            this.timerReset.Location = new System.Drawing.Point(32, 142);
            this.timerReset.Name = "timerReset";
            this.timerReset.Size = new System.Drawing.Size(82, 17);
            this.timerReset.TabIndex = 7;
            this.timerReset.TabStop = true;
            this.timerReset.Text = "Timer Reset";
            this.timerReset.UseVisualStyleBackColor = true;
            this.timerReset.CheckedChanged += new System.EventHandler(this.timerReset_CheckedChanged);
            // 
            // givePoints
            // 
            this.givePoints.AutoSize = true;
            this.givePoints.Location = new System.Drawing.Point(32, 166);
            this.givePoints.Name = "givePoints";
            this.givePoints.Size = new System.Drawing.Size(79, 17);
            this.givePoints.TabIndex = 8;
            this.givePoints.TabStop = true;
            this.givePoints.Text = "Give Points";
            this.givePoints.UseVisualStyleBackColor = true;
            this.givePoints.CheckedChanged += new System.EventHandler(this.givePoints_CheckedChanged);
            // 
            // matchFurni
            // 
            this.matchFurni.AutoSize = true;
            this.matchFurni.Location = new System.Drawing.Point(32, 190);
            this.matchFurni.Name = "matchFurni";
            this.matchFurni.Size = new System.Drawing.Size(164, 17);
            this.matchFurni.TabIndex = 9;
            this.matchFurni.TabStop = true;
            this.matchFurni.Text = "Match Furni to Position & State";
            this.matchFurni.UseVisualStyleBackColor = true;
            this.matchFurni.CheckedChanged += new System.EventHandler(this.matchFurni_CheckedChanged);
            // 
            // botWhispers
            // 
            this.botWhispers.AutoSize = true;
            this.botWhispers.Location = new System.Drawing.Point(32, 214);
            this.botWhispers.Name = "botWhispers";
            this.botWhispers.Size = new System.Drawing.Size(157, 17);
            this.botWhispers.TabIndex = 10;
            this.botWhispers.TabStop = true;
            this.botWhispers.Text = "Bot talks or whispers to user";
            this.botWhispers.UseVisualStyleBackColor = true;
            this.botWhispers.CheckedChanged += new System.EventHandler(this.botWhispers_CheckedChanged);
            // 
            // botTalks
            // 
            this.botTalks.AutoSize = true;
            this.botTalks.Location = new System.Drawing.Point(32, 238);
            this.botTalks.Name = "botTalks";
            this.botTalks.Size = new System.Drawing.Size(165, 17);
            this.botTalks.TabIndex = 11;
            this.botTalks.TabStop = true;
            this.botTalks.Text = "Bot talks or shouts to all users";
            this.botTalks.UseVisualStyleBackColor = true;
            this.botTalks.CheckedChanged += new System.EventHandler(this.botTalks_CheckedChanged);
            // 
            // userSays
            // 
            this.userSays.AutoSize = true;
            this.userSays.Location = new System.Drawing.Point(204, 46);
            this.userSays.Name = "userSays";
            this.userSays.Size = new System.Drawing.Size(117, 17);
            this.userSays.TabIndex = 12;
            this.userSays.TabStop = true;
            this.userSays.Text = "Keyword User Says";
            this.userSays.UseVisualStyleBackColor = true;
            this.userSays.CheckedChanged += new System.EventHandler(this.userSays_CheckedChanged);
            // 
            // ToggleActivation
            // 
            this.ToggleActivation.BackColor = System.Drawing.Color.LightCoral;
            this.ToggleActivation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleActivation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ToggleActivation.Location = new System.Drawing.Point(403, 226);
            this.ToggleActivation.Name = "ToggleActivation";
            this.ToggleActivation.Size = new System.Drawing.Size(75, 23);
            this.ToggleActivation.TabIndex = 13;
            this.ToggleActivation.Text = "Disabled";
            this.ToggleActivation.UseVisualStyleBackColor = false;
            this.ToggleActivation.Click += new System.EventHandler(this.ToggleActivation_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 261);
            this.Controls.Add(this.ToggleActivation);
            this.Controls.Add(this.userSays);
            this.Controls.Add(this.botTalks);
            this.Controls.Add(this.botWhispers);
            this.Controls.Add(this.matchFurni);
            this.Controls.Add(this.givePoints);
            this.Controls.Add(this.timerReset);
            this.Controls.Add(this.toggleFurni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teleportToFurni);
            this.Controls.Add(this.moveAndRotate);
            this.Controls.Add(this.showMessage);
            this.Name = "Form";
            this.Text = "Wired Exploit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton showMessage;
        private System.Windows.Forms.RadioButton moveAndRotate;
        private System.Windows.Forms.RadioButton teleportToFurni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton toggleFurni;
        private System.Windows.Forms.RadioButton timerReset;
        private System.Windows.Forms.RadioButton givePoints;
        private System.Windows.Forms.RadioButton matchFurni;
        private System.Windows.Forms.RadioButton botWhispers;
        private System.Windows.Forms.RadioButton botTalks;
        private System.Windows.Forms.RadioButton userSays;
        private System.Windows.Forms.Button ToggleActivation;
    }
}

