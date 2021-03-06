﻿namespace klondike
{
    partial class KlondikeGame
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemRestart = new System.Windows.Forms.MenuItem();
            this.menuItemRules = new System.Windows.Forms.MenuItem();
            this.cardMappingSpades = new klondike.CardMapping();
            this.cardMappingClubs = new klondike.CardMapping();
            this.cardMappingDiamonds = new klondike.CardMapping();
            this.cardMappingHearts = new klondike.CardMapping();
            this.cardMappingTable7 = new klondike.CardMapping();
            this.cardMappingTable6 = new klondike.CardMapping();
            this.cardMappingTable5 = new klondike.CardMapping();
            this.cardMappingTable4 = new klondike.CardMapping();
            this.cardMappingTable3 = new klondike.CardMapping();
            this.cardMappingTable2 = new klondike.CardMapping();
            this.cardMappingTable1 = new klondike.CardMapping();
            this.cardMappingUnused = new klondike.CardMapping();
            this.cardMappingStack = new klondike.CardMapping();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingSpades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingClubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingDiamonds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingHearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingTable7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingUnused)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingStack)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemRestart,
            this.menuItemRules});
            // 
            // menuItemRestart
            // 
            this.menuItemRestart.Index = 0;
            this.menuItemRestart.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
            this.menuItemRestart.Text = "Перезапуск (Ctrl + R)";
            // 
            // menuItemRules
            // 
            this.menuItemRules.Index = 1;
            this.menuItemRules.Shortcut = System.Windows.Forms.Shortcut.F1;
            this.menuItemRules.Text = "Правила (F1)";
            // 
            // cardMappingSpades
            // 
            this.cardMappingSpades.AllowDrop = true;
            this.cardMappingSpades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMappingSpades.columnNumber = 0;
            this.cardMappingSpades.Image = global::klondike.Properties.Resources.SPADES;
            this.cardMappingSpades.Location = new System.Drawing.Point(1181, 15);
            this.cardMappingSpades.Margin = new System.Windows.Forms.Padding(4);
            this.cardMappingSpades.Name = "cardMappingSpades";
            this.cardMappingSpades.Size = new System.Drawing.Size(146, 172);
            this.cardMappingSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardMappingSpades.TabIndex = 12;
            this.cardMappingSpades.TabStop = false;
            this.cardMappingSpades.Tag = "Drop";
            // 
            // cardMappingClubs
            // 
            this.cardMappingClubs.AllowDrop = true;
            this.cardMappingClubs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMappingClubs.columnNumber = 0;
            this.cardMappingClubs.Image = global::klondike.Properties.Resources.CLUBS;
            this.cardMappingClubs.Location = new System.Drawing.Point(791, 15);
            this.cardMappingClubs.Margin = new System.Windows.Forms.Padding(4);
            this.cardMappingClubs.Name = "cardMappingClubs";
            this.cardMappingClubs.Size = new System.Drawing.Size(146, 172);
            this.cardMappingClubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardMappingClubs.TabIndex = 11;
            this.cardMappingClubs.TabStop = false;
            this.cardMappingClubs.Tag = "Drop";
            // 
            // cardMappingDiamonds
            // 
            this.cardMappingDiamonds.AllowDrop = true;
            this.cardMappingDiamonds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMappingDiamonds.columnNumber = 0;
            this.cardMappingDiamonds.Image = global::klondike.Properties.Resources.DIAMONDS;
            this.cardMappingDiamonds.Location = new System.Drawing.Point(995, 16);
            this.cardMappingDiamonds.Margin = new System.Windows.Forms.Padding(4);
            this.cardMappingDiamonds.Name = "cardMappingDiamonds";
            this.cardMappingDiamonds.Size = new System.Drawing.Size(146, 172);
            this.cardMappingDiamonds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardMappingDiamonds.TabIndex = 10;
            this.cardMappingDiamonds.TabStop = false;
            this.cardMappingDiamonds.Tag = "Drop";
            // 
            // cardMappingHearts
            // 
            this.cardMappingHearts.AllowDrop = true;
            this.cardMappingHearts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMappingHearts.columnNumber = 0;
            this.cardMappingHearts.Image = global::klondike.Properties.Resources.HEARTS;
            this.cardMappingHearts.Location = new System.Drawing.Point(596, 16);
            this.cardMappingHearts.Margin = new System.Windows.Forms.Padding(4);
            this.cardMappingHearts.Name = "cardMappingHearts";
            this.cardMappingHearts.Size = new System.Drawing.Size(146, 172);
            this.cardMappingHearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardMappingHearts.TabIndex = 9;
            this.cardMappingHearts.TabStop = false;
            this.cardMappingHearts.Tag = "Drop";
            // 
            // cardMappingTable7
            // 
            this.cardMappingTable7.AllowDrop = true;
            this.cardMappingTable7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMappingTable7.columnNumber = 0;
            this.cardMappingTable7.Location = new System.Drawing.Point(1181, 235);
            this.cardMappingTable7.Margin = new System.Windows.Forms.Padding(4);
            this.cardMappingTable7.Name = "cardMappingTable7";
            this.cardMappingTable7.Size = new System.Drawing.Size(146, 172);
            this.cardMappingTable7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardMappingTable7.TabIndex = 8;
            this.cardMappingTable7.TabStop = false;
            this.cardMappingTable7.Tag = "Table";
            // 
            // cardMappingTable6
            // 
            this.cardMappingTable6.AllowDrop = true;
            this.cardMappingTable6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMappingTable6.columnNumber = 0;
            this.cardMappingTable6.Location = new System.Drawing.Point(995, 235);
            this.cardMappingTable6.Margin = new System.Windows.Forms.Padding(4);
            this.cardMappingTable6.Name = "cardMappingTable6";
            this.cardMappingTable6.Size = new System.Drawing.Size(146, 172);
            this.cardMappingTable6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardMappingTable6.TabIndex = 7;
            this.cardMappingTable6.TabStop = false;
            this.cardMappingTable6.Tag = "Table";
            // 
            // cardMappingTable5
            // 
            this.cardMappingTable5.AllowDrop = true;
            this.cardMappingTable5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMappingTable5.columnNumber = 0;
            this.cardMappingTable5.Location = new System.Drawing.Point(791, 235);
            this.cardMappingTable5.Margin = new System.Windows.Forms.Padding(4);
            this.cardMappingTable5.Name = "cardMappingTable5";
            this.cardMappingTable5.Size = new System.Drawing.Size(146, 172);
            this.cardMappingTable5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardMappingTable5.TabIndex = 6;
            this.cardMappingTable5.TabStop = false;
            this.cardMappingTable5.Tag = "Table";
            // 
            // cardMappingTable4
            // 
            this.cardMappingTable4.AllowDrop = true;
            this.cardMappingTable4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMappingTable4.columnNumber = 0;
            this.cardMappingTable4.Location = new System.Drawing.Point(596, 235);
            this.cardMappingTable4.Margin = new System.Windows.Forms.Padding(4);
            this.cardMappingTable4.Name = "cardMappingTable4";
            this.cardMappingTable4.Size = new System.Drawing.Size(146, 172);
            this.cardMappingTable4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardMappingTable4.TabIndex = 5;
            this.cardMappingTable4.TabStop = false;
            this.cardMappingTable4.Tag = "Table";
            // 
            // cardMappingTable3
            // 
            this.cardMappingTable3.AllowDrop = true;
            this.cardMappingTable3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMappingTable3.columnNumber = 0;
            this.cardMappingTable3.Location = new System.Drawing.Point(403, 235);
            this.cardMappingTable3.Margin = new System.Windows.Forms.Padding(4);
            this.cardMappingTable3.Name = "cardMappingTable3";
            this.cardMappingTable3.Size = new System.Drawing.Size(146, 172);
            this.cardMappingTable3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardMappingTable3.TabIndex = 4;
            this.cardMappingTable3.TabStop = false;
            this.cardMappingTable3.Tag = "Table";
            // 
            // cardMappingTable2
            // 
            this.cardMappingTable2.AllowDrop = true;
            this.cardMappingTable2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMappingTable2.columnNumber = 0;
            this.cardMappingTable2.Location = new System.Drawing.Point(209, 235);
            this.cardMappingTable2.Margin = new System.Windows.Forms.Padding(4);
            this.cardMappingTable2.Name = "cardMappingTable2";
            this.cardMappingTable2.Size = new System.Drawing.Size(146, 172);
            this.cardMappingTable2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardMappingTable2.TabIndex = 3;
            this.cardMappingTable2.TabStop = false;
            this.cardMappingTable2.Tag = "Table";
            // 
            // cardMappingTable1
            // 
            this.cardMappingTable1.AllowDrop = true;
            this.cardMappingTable1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMappingTable1.columnNumber = 0;
            this.cardMappingTable1.Location = new System.Drawing.Point(17, 235);
            this.cardMappingTable1.Margin = new System.Windows.Forms.Padding(4);
            this.cardMappingTable1.Name = "cardMappingTable1";
            this.cardMappingTable1.Size = new System.Drawing.Size(146, 172);
            this.cardMappingTable1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardMappingTable1.TabIndex = 2;
            this.cardMappingTable1.TabStop = false;
            this.cardMappingTable1.Tag = "Table";
            // 
            // cardMappingUnused
            // 
            this.cardMappingUnused.AllowDrop = true;
            this.cardMappingUnused.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMappingUnused.columnNumber = 0;
            this.cardMappingUnused.Location = new System.Drawing.Point(209, 16);
            this.cardMappingUnused.Margin = new System.Windows.Forms.Padding(4);
            this.cardMappingUnused.Name = "cardMappingUnused";
            this.cardMappingUnused.Size = new System.Drawing.Size(146, 172);
            this.cardMappingUnused.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardMappingUnused.TabIndex = 1;
            this.cardMappingUnused.TabStop = false;
            this.cardMappingUnused.Tag = "Unused";
            // 
            // cardMappingStack
            // 
            this.cardMappingStack.AllowDrop = true;
            this.cardMappingStack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMappingStack.columnNumber = 0;
            this.cardMappingStack.Location = new System.Drawing.Point(17, 16);
            this.cardMappingStack.Margin = new System.Windows.Forms.Padding(4);
            this.cardMappingStack.Name = "cardMappingStack";
            this.cardMappingStack.Size = new System.Drawing.Size(146, 172);
            this.cardMappingStack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardMappingStack.TabIndex = 0;
            this.cardMappingStack.TabStop = false;
            this.cardMappingStack.Tag = "Drop";
            // 
            // KlondikeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1344, 871);
            this.Controls.Add(this.cardMappingSpades);
            this.Controls.Add(this.cardMappingClubs);
            this.Controls.Add(this.cardMappingDiamonds);
            this.Controls.Add(this.cardMappingHearts);
            this.Controls.Add(this.cardMappingTable7);
            this.Controls.Add(this.cardMappingTable6);
            this.Controls.Add(this.cardMappingTable5);
            this.Controls.Add(this.cardMappingTable4);
            this.Controls.Add(this.cardMappingTable3);
            this.Controls.Add(this.cardMappingTable2);
            this.Controls.Add(this.cardMappingTable1);
            this.Controls.Add(this.cardMappingUnused);
            this.Controls.Add(this.cardMappingStack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Menu = this.mainMenu1;
            this.Name = "KlondikeGame";
            this.Text = "klondike";
            this.Load += new System.EventHandler(this.Klondike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingSpades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingClubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingDiamonds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingHearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingTable7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingUnused)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMappingStack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CardMapping cardMappingStack;
        private CardMapping cardMappingUnused;
        private CardMapping cardMappingTable1;
        private CardMapping cardMappingTable2;
        private CardMapping cardMappingTable3;
        private CardMapping cardMappingTable4;
        private CardMapping cardMappingTable5;
        private CardMapping cardMappingTable6;
        private CardMapping cardMappingTable7;
        private CardMapping cardMappingHearts;
        private CardMapping cardMappingDiamonds;
        private CardMapping cardMappingClubs;
        private CardMapping cardMappingSpades;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItemRestart;
        private System.Windows.Forms.MenuItem menuItemRules;
    }
}

