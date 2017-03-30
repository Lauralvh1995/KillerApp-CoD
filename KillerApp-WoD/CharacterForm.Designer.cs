namespace KillerApp_WoD
{
    partial class CharacterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCharacters = new System.Windows.Forms.TabControl();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.tabActualCharacter = new System.Windows.Forms.TabPage();
            this.tabCharacters.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCharacters
            // 
            this.tabCharacters.Controls.Add(this.tabProfile);
            this.tabCharacters.Controls.Add(this.tabActualCharacter);
            this.tabCharacters.Location = new System.Drawing.Point(13, 13);
            this.tabCharacters.Name = "tabCharacters";
            this.tabCharacters.SelectedIndex = 0;
            this.tabCharacters.Size = new System.Drawing.Size(600, 489);
            this.tabCharacters.TabIndex = 0;
            // 
            // tabProfile
            // 
            this.tabProfile.Location = new System.Drawing.Point(4, 25);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(592, 460);
            this.tabProfile.TabIndex = 0;
            this.tabProfile.Text = "Profiel";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // tabActualCharacter
            // 
            this.tabActualCharacter.Location = new System.Drawing.Point(4, 25);
            this.tabActualCharacter.Name = "tabActualCharacter";
            this.tabActualCharacter.Padding = new System.Windows.Forms.Padding(3);
            this.tabActualCharacter.Size = new System.Drawing.Size(592, 460);
            this.tabActualCharacter.TabIndex = 1;
            this.tabActualCharacter.Text = "Personage";
            this.tabActualCharacter.UseVisualStyleBackColor = true;
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 514);
            this.Controls.Add(this.tabCharacters);
            this.Name = "CharacterForm";
            this.Text = "Personages";
            this.tabCharacters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCharacters;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabActualCharacter;
    }
}