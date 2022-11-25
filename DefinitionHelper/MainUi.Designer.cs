﻿namespace LiveSplit.UI.Components
{
    partial class MainUI
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listSplits = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenGame = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.SaveGame = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.subSplitView = new System.Windows.Forms.ListView();
            this.subSplitLabel = new System.Windows.Forms.Label();
            this.addNextButton = new System.Windows.Forms.Button();
            this.addMoreButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.subSplitAddress = new System.Windows.Forms.TextBox();
            this.subSplitTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addSplitButton = new System.Windows.Forms.Button();
            this.delSplit = new System.Windows.Forms.Button();
            this.usb2snesLabel = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listSplits
            // 
            this.listSplits.HideSelection = false;
            this.listSplits.Location = new System.Drawing.Point(37, 142);
            this.listSplits.Name = "listSplits";
            this.listSplits.Size = new System.Drawing.Size(193, 264);
            this.listSplits.TabIndex = 0;
            this.listSplits.UseCompatibleStateImageBehavior = false;
            this.listSplits.View = System.Windows.Forms.View.List;
            this.listSplits.SelectedIndexChanged += new System.EventHandler(this.listSplits_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Definitions";
            // 
            // OpenGame
            // 
            this.OpenGame.Location = new System.Drawing.Point(467, 12);
            this.OpenGame.Name = "OpenGame";
            this.OpenGame.Size = new System.Drawing.Size(75, 23);
            this.OpenGame.TabIndex = 2;
            this.OpenGame.Text = "Open";
            this.OpenGame.UseVisualStyleBackColor = true;
            this.OpenGame.Click += new System.EventHandler(this.OpenGame_Click);
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(386, 12);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(75, 23);
            this.NewGame.TabIndex = 3;
            this.NewGame.Text = "New";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // SaveGame
            // 
            this.SaveGame.Location = new System.Drawing.Point(48, 12);
            this.SaveGame.Name = "SaveGame";
            this.SaveGame.Size = new System.Drawing.Size(75, 23);
            this.SaveGame.TabIndex = 4;
            this.SaveGame.Text = "Save";
            this.SaveGame.UseVisualStyleBackColor = true;
            this.SaveGame.Click += new System.EventHandler(this.SaveGame_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(197, 69);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(66, 13);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "Game Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name :";
            // 
            // splitNameTextBox
            // 
            this.splitNameTextBox.AcceptsReturn = true;
            this.splitNameTextBox.Location = new System.Drawing.Point(369, 155);
            this.splitNameTextBox.Name = "splitNameTextBox";
            this.splitNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.splitNameTextBox.TabIndex = 7;
            this.splitNameTextBox.TextChanged += new System.EventHandler(this.splitNameTextBox_TextChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.AcceptsReturn = true;
            this.addressTextBox.Location = new System.Drawing.Point(369, 194);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "eq",
            "bit",
            "lt",
            "gte",
            "lte",
            "wbit",
            "weq",
            "wgt",
            "wlt",
            "wgte",
            "wlte"});
            this.typeComboBox.Location = new System.Drawing.Point(348, 228);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Comparaison Type";
            // 
            // subSplitView
            // 
            this.subSplitView.HideSelection = false;
            this.subSplitView.Location = new System.Drawing.Point(549, 142);
            this.subSplitView.Name = "subSplitView";
            this.subSplitView.Size = new System.Drawing.Size(196, 217);
            this.subSplitView.TabIndex = 12;
            this.subSplitView.UseCompatibleStateImageBehavior = false;
            this.subSplitView.SelectedIndexChanged += new System.EventHandler(this.subSplitView_SelectedIndexChanged);
            // 
            // subSplitLabel
            // 
            this.subSplitLabel.AutoSize = true;
            this.subSplitLabel.Location = new System.Drawing.Point(589, 123);
            this.subSplitLabel.Name = "subSplitLabel";
            this.subSplitLabel.Size = new System.Drawing.Size(81, 13);
            this.subSplitLabel.TabIndex = 13;
            this.subSplitLabel.Text = "Next Sequence";
            // 
            // addNextButton
            // 
            this.addNextButton.Location = new System.Drawing.Point(549, 375);
            this.addNextButton.Name = "addNextButton";
            this.addNextButton.Size = new System.Drawing.Size(75, 23);
            this.addNextButton.TabIndex = 14;
            this.addNextButton.Text = "Add Next";
            this.addNextButton.UseVisualStyleBackColor = true;
            // 
            // addMoreButton
            // 
            this.addMoreButton.Location = new System.Drawing.Point(645, 375);
            this.addMoreButton.Name = "addMoreButton";
            this.addMoreButton.Size = new System.Drawing.Size(75, 23);
            this.addMoreButton.TabIndex = 15;
            this.addMoreButton.Text = "Add More";
            this.addMoreButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "------------------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Address";
            // 
            // subSplitAddress
            // 
            this.subSplitAddress.Location = new System.Drawing.Point(369, 305);
            this.subSplitAddress.Name = "subSplitAddress";
            this.subSplitAddress.Size = new System.Drawing.Size(100, 20);
            this.subSplitAddress.TabIndex = 18;
            // 
            // subSplitTypeComboBox
            // 
            this.subSplitTypeComboBox.FormattingEnabled = true;
            this.subSplitTypeComboBox.Items.AddRange(new object[] {
            "eq",
            "bit",
            "lt",
            "gte",
            "lte",
            "wbit",
            "weq",
            "wgt",
            "wlt",
            "wgte",
            "wlte"});
            this.subSplitTypeComboBox.Location = new System.Drawing.Point(348, 338);
            this.subSplitTypeComboBox.Name = "subSplitTypeComboBox";
            this.subSplitTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.subSplitTypeComboBox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Comparaison Type";
            // 
            // addSplitButton
            // 
            this.addSplitButton.Location = new System.Drawing.Point(37, 427);
            this.addSplitButton.Name = "addSplitButton";
            this.addSplitButton.Size = new System.Drawing.Size(86, 23);
            this.addSplitButton.TabIndex = 21;
            this.addSplitButton.Text = "Add Definition";
            this.addSplitButton.UseVisualStyleBackColor = true;
            this.addSplitButton.Click += new System.EventHandler(this.addSplitButton_Click);
            // 
            // delSplit
            // 
            this.delSplit.Location = new System.Drawing.Point(131, 427);
            this.delSplit.Name = "delSplit";
            this.delSplit.Size = new System.Drawing.Size(99, 23);
            this.delSplit.TabIndex = 22;
            this.delSplit.Text = "Delete Definition";
            this.delSplit.UseVisualStyleBackColor = true;
            // 
            // usb2snesLabel
            // 
            this.usb2snesLabel.AutoSize = true;
            this.usb2snesLabel.Location = new System.Drawing.Point(585, 69);
            this.usb2snesLabel.Name = "usb2snesLabel";
            this.usb2snesLabel.Size = new System.Drawing.Size(85, 13);
            this.usb2snesLabel.TabIndex = 23;
            this.usb2snesLabel.Text = "Usb2snes status";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(588, 427);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 24;
            this.checkButton.Text = "Check Split";
            this.checkButton.UseVisualStyleBackColor = true;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.usb2snesLabel);
            this.Controls.Add(this.delSplit);
            this.Controls.Add(this.addSplitButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.subSplitTypeComboBox);
            this.Controls.Add(this.subSplitAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addMoreButton);
            this.Controls.Add(this.addNextButton);
            this.Controls.Add(this.subSplitLabel);
            this.Controls.Add(this.subSplitView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.splitNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SaveGame);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.OpenGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listSplits);
            this.Name = "MainUI";
            this.Text = "Definition Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listSplits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenGame;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button SaveGame;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox splitNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView subSplitView;
        private System.Windows.Forms.Label subSplitLabel;
        private System.Windows.Forms.Button addNextButton;
        private System.Windows.Forms.Button addMoreButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox subSplitAddress;
        private System.Windows.Forms.ComboBox subSplitTypeComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addSplitButton;
        private System.Windows.Forms.Button delSplit;
        private System.Windows.Forms.Label usb2snesLabel;
        private System.Windows.Forms.Button checkButton;
    }
}

