namespace Soccercards
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.pbPlayerPhoto = new System.Windows.Forms.PictureBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblGoals = new System.Windows.Forms.Label();
            this.lblAssists = new System.Windows.Forms.Label();
            this.lblPasses = new System.Windows.Forms.Label();
            this.lblTackles = new System.Windows.Forms.Label();
            this.lblYellowCards = new System.Windows.Forms.Label();
            this.lblApperances = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblRedCards = new System.Windows.Forms.Label();
            this.panelCard = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerPhoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPlayers
            // 
            this.lbPlayers.BackColor = System.Drawing.Color.RosyBrown;
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.ItemHeight = 16;
            this.lbPlayers.Location = new System.Drawing.Point(1, 2);
            this.lbPlayers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(303, 180);
            this.lbPlayers.TabIndex = 0;
            this.lbPlayers.SelectedIndexChanged += new System.EventHandler(this.LbPlayers_SelectedIndexChanged);
            // 
            // pbPlayerPhoto
            // 
            this.pbPlayerPhoto.BackColor = System.Drawing.Color.RosyBrown;
            this.pbPlayerPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPlayerPhoto.Location = new System.Drawing.Point(309, 2);
            this.pbPlayerPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPlayerPhoto.Name = "pbPlayerPhoto";
            this.pbPlayerPhoto.Size = new System.Drawing.Size(309, 180);
            this.pbPlayerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerPhoto.TabIndex = 1;
            this.pbPlayerPhoto.TabStop = false;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(36, 9);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(82, 29);
            this.lblPlayerName.TabIndex = 2;
            this.lblPlayerName.Text = "Name";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.Location = new System.Drawing.Point(37, 107);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(56, 22);
            this.lblTeam.TabIndex = 3;
            this.lblTeam.Text = "Team";
            this.lblTeam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGoals
            // 
            this.lblGoals.AutoSize = true;
            this.lblGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoals.Location = new System.Drawing.Point(37, 153);
            this.lblGoals.Name = "lblGoals";
            this.lblGoals.Size = new System.Drawing.Size(57, 22);
            this.lblGoals.TabIndex = 4;
            this.lblGoals.Text = "Goals";
            this.lblGoals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAssists
            // 
            this.lblAssists.AutoSize = true;
            this.lblAssists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssists.Location = new System.Drawing.Point(37, 199);
            this.lblAssists.Name = "lblAssists";
            this.lblAssists.Size = new System.Drawing.Size(67, 22);
            this.lblAssists.TabIndex = 5;
            this.lblAssists.Text = "Assists";
            this.lblAssists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPasses
            // 
            this.lblPasses.AutoSize = true;
            this.lblPasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasses.Location = new System.Drawing.Point(37, 246);
            this.lblPasses.Name = "lblPasses";
            this.lblPasses.Size = new System.Drawing.Size(69, 22);
            this.lblPasses.TabIndex = 6;
            this.lblPasses.Text = "Passes";
            this.lblPasses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTackles
            // 
            this.lblTackles.AutoSize = true;
            this.lblTackles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTackles.Location = new System.Drawing.Point(37, 293);
            this.lblTackles.Name = "lblTackles";
            this.lblTackles.Size = new System.Drawing.Size(73, 22);
            this.lblTackles.TabIndex = 7;
            this.lblTackles.Text = "Tackles";
            this.lblTackles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYellowCards
            // 
            this.lblYellowCards.AutoSize = true;
            this.lblYellowCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYellowCards.Location = new System.Drawing.Point(37, 377);
            this.lblYellowCards.Name = "lblYellowCards";
            this.lblYellowCards.Size = new System.Drawing.Size(116, 22);
            this.lblYellowCards.TabIndex = 8;
            this.lblYellowCards.Text = "Yellow Cards";
            this.lblYellowCards.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApperances
            // 
            this.lblApperances.AutoSize = true;
            this.lblApperances.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApperances.Location = new System.Drawing.Point(37, 334);
            this.lblApperances.Name = "lblApperances";
            this.lblApperances.Size = new System.Drawing.Size(116, 22);
            this.lblApperances.TabIndex = 9;
            this.lblApperances.Text = "Appearances";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.panelCard);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.lblRedCards);
            this.panel1.Controls.Add(this.lblApperances);
            this.panel1.Controls.Add(this.lblYellowCards);
            this.panel1.Controls.Add(this.lblAssists);
            this.panel1.Controls.Add(this.lblTackles);
            this.panel1.Controls.Add(this.lblPlayerName);
            this.panel1.Controls.Add(this.lblTeam);
            this.panel1.Controls.Add(this.lblGoals);
            this.panel1.Controls.Add(this.lblPasses);
            this.panel1.Location = new System.Drawing.Point(1, 188);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 454);
            this.panel1.TabIndex = 10;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(37, 62);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(42, 22);
            this.lblAge.TabIndex = 11;
            this.lblAge.Text = "Age";
            // 
            // lblRedCards
            // 
            this.lblRedCards.AutoSize = true;
            this.lblRedCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedCards.Location = new System.Drawing.Point(37, 417);
            this.lblRedCards.Name = "lblRedCards";
            this.lblRedCards.Size = new System.Drawing.Size(96, 22);
            this.lblRedCards.TabIndex = 10;
            this.lblRedCards.Text = "Red Cards";
            // 
            // panelCard
            // 
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Location = new System.Drawing.Point(308, 4);
            this.panelCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(309, 277);
            this.panelCard.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 646);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbPlayerPhoto);
            this.Controls.Add(this.lbPlayers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Soccer Trading Cards";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerPhoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListBox lbPlayers;
        private System.Windows.Forms.PictureBox pbPlayerPhoto;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblGoals;
        private System.Windows.Forms.Label lblAssists;
        private System.Windows.Forms.Label lblPasses;
        private System.Windows.Forms.Label lblTackles;
        private System.Windows.Forms.Label lblYellowCards;
        private System.Windows.Forms.Label lblApperances;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRedCards;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Panel panelCard;

    }
}
