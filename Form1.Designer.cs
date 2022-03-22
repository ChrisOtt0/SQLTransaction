﻿
namespace SQL_transaktion_Forms
{
    partial class Form1
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
            this.FlyNummerLabel = new System.Windows.Forms.Label();
            this.FlyNummerComboBox = new System.Windows.Forms.ComboBox();
            this.TransactionLabel = new System.Windows.Forms.Label();
            this.GetSeatLabel = new System.Windows.Forms.Label();
            this.GetSeatsLabel = new System.Windows.Forms.Label();
            this.UncommitedButton = new System.Windows.Forms.Button();
            this.SerializableButton = new System.Windows.Forms.Button();
            this.FreeSeatsLabel = new System.Windows.Forms.Label();
            this.FreeSeatsTextbox = new System.Windows.Forms.TextBox();
            this.NumberOfSeatsLabel = new System.Windows.Forms.Label();
            this.ReserveTextbox = new System.Windows.Forms.TextBox();
            this.ReserveButton = new System.Windows.Forms.Button();
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.FeedbackTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FlyNummerLabel
            // 
            this.FlyNummerLabel.AutoSize = true;
            this.FlyNummerLabel.Location = new System.Drawing.Point(39, 35);
            this.FlyNummerLabel.Name = "FlyNummerLabel";
            this.FlyNummerLabel.Size = new System.Drawing.Size(63, 13);
            this.FlyNummerLabel.TabIndex = 0;
            this.FlyNummerLabel.Text = "Fly nummer:";
            // 
            // FlyNummerComboBox
            // 
            this.FlyNummerComboBox.FormattingEnabled = true;
            this.FlyNummerComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.FlyNummerComboBox.Location = new System.Drawing.Point(131, 35);
            this.FlyNummerComboBox.Name = "FlyNummerComboBox";
            this.FlyNummerComboBox.Size = new System.Drawing.Size(121, 21);
            this.FlyNummerComboBox.TabIndex = 1;
            // 
            // TransactionLabel
            // 
            this.TransactionLabel.AutoSize = true;
            this.TransactionLabel.Location = new System.Drawing.Point(39, 94);
            this.TransactionLabel.Name = "TransactionLabel";
            this.TransactionLabel.Size = new System.Drawing.Size(66, 13);
            this.TransactionLabel.TabIndex = 2;
            this.TransactionLabel.Text = "Transaction:";
            // 
            // GetSeatLabel
            // 
            this.GetSeatLabel.AutoSize = true;
            this.GetSeatLabel.Location = new System.Drawing.Point(59, 125);
            this.GetSeatLabel.Name = "GetSeatLabel";
            this.GetSeatLabel.Size = new System.Drawing.Size(55, 13);
            this.GetSeatLabel.TabIndex = 3;
            this.GetSeatLabel.Text = "Get seats:";
            // 
            // GetSeatsLabel
            // 
            this.GetSeatsLabel.AutoSize = true;
            this.GetSeatsLabel.Location = new System.Drawing.Point(62, 157);
            this.GetSeatsLabel.Name = "GetSeatsLabel";
            this.GetSeatsLabel.Size = new System.Drawing.Size(152, 13);
            this.GetSeatsLabel.TabIndex = 4;
            this.GetSeatsLabel.Text = "Get available seats by method:";
            // 
            // UncommitedButton
            // 
            this.UncommitedButton.Location = new System.Drawing.Point(30, 193);
            this.UncommitedButton.Name = "UncommitedButton";
            this.UncommitedButton.Size = new System.Drawing.Size(102, 23);
            this.UncommitedButton.TabIndex = 5;
            this.UncommitedButton.Text = "Read uncommited";
            this.UncommitedButton.UseVisualStyleBackColor = true;
            // 
            // SerializableButton
            // 
            this.SerializableButton.Location = new System.Drawing.Point(162, 193);
            this.SerializableButton.Name = "SerializableButton";
            this.SerializableButton.Size = new System.Drawing.Size(75, 23);
            this.SerializableButton.TabIndex = 6;
            this.SerializableButton.Text = "Serializable";
            this.SerializableButton.UseVisualStyleBackColor = true;
            // 
            // FreeSeatsLabel
            // 
            this.FreeSeatsLabel.AutoSize = true;
            this.FreeSeatsLabel.Location = new System.Drawing.Point(39, 240);
            this.FreeSeatsLabel.Name = "FreeSeatsLabel";
            this.FreeSeatsLabel.Size = new System.Drawing.Size(131, 13);
            this.FreeSeatsLabel.TabIndex = 7;
            this.FreeSeatsLabel.Text = "Free seats on the flightNo:";
            // 
            // FreeSeatsTextbox
            // 
            this.FreeSeatsTextbox.Location = new System.Drawing.Point(180, 240);
            this.FreeSeatsTextbox.Name = "FreeSeatsTextbox";
            this.FreeSeatsTextbox.Size = new System.Drawing.Size(100, 20);
            this.FreeSeatsTextbox.TabIndex = 8;
            // 
            // NumberOfSeatsLabel
            // 
            this.NumberOfSeatsLabel.AutoSize = true;
            this.NumberOfSeatsLabel.Location = new System.Drawing.Point(39, 335);
            this.NumberOfSeatsLabel.Name = "NumberOfSeatsLabel";
            this.NumberOfSeatsLabel.Size = new System.Drawing.Size(140, 13);
            this.NumberOfSeatsLabel.TabIndex = 9;
            this.NumberOfSeatsLabel.Text = "Number og seats to reserve:";
            // 
            // ReserveTextbox
            // 
            this.ReserveTextbox.Location = new System.Drawing.Point(188, 335);
            this.ReserveTextbox.Name = "ReserveTextbox";
            this.ReserveTextbox.Size = new System.Drawing.Size(100, 20);
            this.ReserveTextbox.TabIndex = 10;
            // 
            // ReserveButton
            // 
            this.ReserveButton.Location = new System.Drawing.Point(86, 383);
            this.ReserveButton.Name = "ReserveButton";
            this.ReserveButton.Size = new System.Drawing.Size(96, 23);
            this.ReserveButton.TabIndex = 11;
            this.ReserveButton.Text = "Reserve Seats";
            this.ReserveButton.UseVisualStyleBackColor = true;
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.Location = new System.Drawing.Point(39, 448);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(113, 13);
            this.FeedbackLabel.TabIndex = 12;
            this.FeedbackLabel.Text = "Feedback from server:";
            // 
            // FeedbackTextbox
            // 
            this.FeedbackTextbox.Location = new System.Drawing.Point(162, 448);
            this.FeedbackTextbox.Name = "FeedbackTextbox";
            this.FeedbackTextbox.Size = new System.Drawing.Size(100, 20);
            this.FeedbackTextbox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 534);
            this.Controls.Add(this.FeedbackTextbox);
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.ReserveButton);
            this.Controls.Add(this.ReserveTextbox);
            this.Controls.Add(this.NumberOfSeatsLabel);
            this.Controls.Add(this.FreeSeatsTextbox);
            this.Controls.Add(this.FreeSeatsLabel);
            this.Controls.Add(this.SerializableButton);
            this.Controls.Add(this.UncommitedButton);
            this.Controls.Add(this.GetSeatsLabel);
            this.Controls.Add(this.GetSeatLabel);
            this.Controls.Add(this.TransactionLabel);
            this.Controls.Add(this.FlyNummerComboBox);
            this.Controls.Add(this.FlyNummerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FlyNummerLabel;
        private System.Windows.Forms.ComboBox FlyNummerComboBox;
        private System.Windows.Forms.Label TransactionLabel;
        private System.Windows.Forms.Label GetSeatLabel;
        private System.Windows.Forms.Label GetSeatsLabel;
        private System.Windows.Forms.Button UncommitedButton;
        private System.Windows.Forms.Button SerializableButton;
        private System.Windows.Forms.Label FreeSeatsLabel;
        private System.Windows.Forms.TextBox FreeSeatsTextbox;
        private System.Windows.Forms.Label NumberOfSeatsLabel;
        private System.Windows.Forms.TextBox ReserveTextbox;
        private System.Windows.Forms.Button ReserveButton;
        private System.Windows.Forms.Label FeedbackLabel;
        private System.Windows.Forms.TextBox FeedbackTextbox;
    }
}
